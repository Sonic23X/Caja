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
    public partial class User_N : Form
    {
        private String servidor;
        private String usuario;
        private String contra;
        private String bgatos;

        private MySqlConnectionStringBuilder mcsbConectar;
        private MySqlConnection mcConectar;
        private MySqlCommand mcQuery;
        private MySqlDataReader mrData;

        #region Set's

        public void Set(String h, String u, String p)
        {
            servidor = h;
            usuario = u;
            contra = p;
            bgatos = null;
        }

        public void Set(String h, String u, String p, String b)
        {
            servidor = h;
            usuario = u;
            contra = p;
            bgatos = b;
        }

        #endregion

        public User_N()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(txtName.Text == String.Empty || txtPass.Text == String.Empty || txtRPass.Text == String.Empty || 
                txtBDD.Text == String.Empty || txtTabla.Text == String.Empty)
            {
                MessageBox.Show("Los campos con * son obligatorios, rellene los campos que se le soliciten");
                return;
            }

            String nombre = txtName.Text,
                   pass = txtPass.Text,
                   rpass = txtRPass.Text,
                   server = txtHost.Text,
                   bdd = txtBDD.Text,
                   tabla = txtTabla.Text,
                   query;

            if(String.Equals(pass, rpass))
            {
                mcsbConectar = new MySqlConnectionStringBuilder();
                mcsbConectar.Server = servidor;
                mcsbConectar.UserID = usuario;
                mcsbConectar.Password = pass;

                if (bgatos != String.Empty)
                {
                    mcsbConectar.Database = bgatos;
                }

                mcConectar = new MySqlConnection(mcsbConectar.ToString());

                try
                {
                    mcConectar.Open();
                    query = "Create user '" + nombre + "'@'" + server + "' identified by '" + pass +"'";
                    mcQuery = new MySqlCommand(query, mcConectar);

                    int res = mcQuery.ExecuteNonQuery();

                    List<String> valores = new List<String>();

                    foreach(var check in gbPermisos.Controls)
                    {
                        if(check is CheckBox)
                        {
                            CheckBox item = check as CheckBox;

                            if (item.Checked)
                                valores.Add(item.Text);
                        }
                    }

                    query = "Grant " + String.Join(", ", valores.ToArray()) + " on " + bdd + "." + tabla + " to '" + nombre + "'@'" + server + "'";
                    mcQuery = new MySqlCommand(query, mcConectar);

                    res = mcQuery.ExecuteNonQuery();

                    query = "FLUSH PRIVILEGES";
                    mcQuery = new MySqlCommand(query, mcConectar);

                    res = mcQuery.ExecuteNonQuery();

                    MessageBox.Show("Usuario creado con exito!");

                    this.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
                   
        }

        private void User_N_Load(object sender, EventArgs e)
        {
            txtHost.Text = servidor;

            if (bgatos != String.Empty)
            {
                txtBDD.Text = bgatos;
            }
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAll.Checked)
            {
                cbAlter.Checked = false;
                cbCreate.Checked = false;
                cbDrop.Checked = false;
                cbGOption.Checked = false;
                cbInsert.Checked = false;
                cbLTables.Checked = false;
                cbSDatabase.Checked = false;
                cbSelect.Checked = false;
                cbSView.Checked = false;
                cbTrigger.Checked = false;
                cbUpdate.Checked = false;

            }
        }

        private void cbCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked && cbCreate.Checked)
                cbAll.Checked = false;
        }

        private void cbDrop_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked && cbDrop.Checked)
                cbAll.Checked = false;
        }

        private void cbAlter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked && cbAlter.Checked)
                cbAll.Checked = false;
        }

        private void cbInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked && cbInsert.Checked)
                cbAll.Checked = false;
        }

        private void cbLTables_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked && cbLTables.Checked)
                cbAll.Checked = false;
        }

        private void cbSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked && cbSelect.Checked)
                cbAll.Checked = false;
        }

        private void cbSDatabase_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked && cbSDatabase.Checked)
                cbAll.Checked = false;
        }

        private void cbSView_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked && cbSView.Checked)
                cbAll.Checked = false;
        }

        private void cbTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked && cbTrigger.Checked)
                cbAll.Checked = false;
        }

        private void cbGOption_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked && cbGOption.Checked)
                cbAll.Checked = false;
        }

        private void cbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked && cbUpdate.Checked)
                cbAll.Checked = false;
        }
    }
}
