using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BDD
{
    public partial class Login : Form
    {
        private String host;
        private String user;
        private String pass;
        private String bd = "";
        private bool paser = false;

        private MySqlConnectionStringBuilder mcsbConectar;
        private MySqlConnection mcConectar;
        private MySqlCommand mcQuery;
        private MySqlDataReader mrData;

        public Login()
        {
            InitializeComponent();
            bwHilo.RunWorkerAsync();

            host = "";
            user = "";
            pass = "";
            bd = "";
        }

        private bool Validar()
        {
            if (txtServer.Text != String.Empty)
                if (txtUser.Text != String.Empty)
                    if (txtPass.Text != String.Empty)
                        return true;
            return false;
        }

        #region Hilo

        private void bwHilo_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Validar())
            {
                host = txtServer.Text;
                user = txtUser.Text;
                pass = txtPass.Text;

                mcsbConectar = new MySqlConnectionStringBuilder();
                mcsbConectar.Server = host;
                mcsbConectar.UserID = user;
                mcsbConectar.Password = pass;

                mcConectar = new MySqlConnection(mcsbConectar.ToString());
                paser = true;
            }
            else
                paser = false;
        }

        private void bwHilo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(paser)
            {
                try
                {
                    mcConectar.Open();
                    mcQuery = new MySqlCommand("Show Databases", mcConectar);

                    mrData = mcQuery.ExecuteReader();

                    while(mrData.Read())
                    {
                        cbDBB.Items.Add(Convert.ToString(mrData["Database"]));
                    }

                    mcConectar.Close();

                    tHilo.Enabled = false;
                }
                catch(MySqlException ex)
                {

                }
                paser = false;
            }
        }

        private void tHilo_Tick(object sender, EventArgs e)
        {
            if(!bwHilo.IsBusy && Validar())
            {
                bwHilo.RunWorkerAsync();
            }
        }

        #endregion

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (cbDBB.SelectedItem != null)
                    if (cbDBB.SelectedIndex.ToString() != String.Empty)
                        bd = cbDBB.SelectedItem.ToString();

                mcsbConectar = new MySqlConnectionStringBuilder();
                mcsbConectar.Server = host;
                mcsbConectar.UserID = user;
                mcsbConectar.Password = pass;

                if (bd != String.Empty)
                    mcsbConectar.Database = bd;

                mcConectar = new MySqlConnection(mcsbConectar.ToString());

                try
                {
                    mcConectar.Open();
                    if (mcConectar.State == ConnectionState.Open)
                        MessageBox.Show("Conexión Establecida");
                    mcConectar.Close();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
                MessageBox.Show("Verifique los Campos");
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (cbDBB.SelectedItem != null)
                    bd = cbDBB.SelectedItem.ToString();
                
                mcsbConectar = new MySqlConnectionStringBuilder();
                mcsbConectar.Server = host;
                mcsbConectar.UserID = user;
                mcsbConectar.Password = pass;

                if (bd != String.Empty)
                    mcsbConectar.Database = bd;

                mcConectar = new MySqlConnection(mcsbConectar.ToString());

                try
                {
                    mcConectar.Open();
                    if (mcConectar.State == ConnectionState.Open)
                    {
                        mcConectar.Close();
                        Main obj = new Main();
                        if (bd != String.Empty)
                            obj.Set(host, user, pass, bd);
                        else
                            obj.Set(host, user, pass);
                        this.Hide();
                        obj.Show();
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
                MessageBox.Show("Verifique los Campos");
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            tHilo.Enabled = true;
            cbDBB.Items.Clear();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            tHilo.Enabled = true;
            cbDBB.Items.Clear();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            tHilo.Enabled = true;
            cbDBB.Items.Clear();
        }
    }
}
