using System;
using System.Collections;
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
    public partial class EQuery : Form
    {
        private String servidor;
        private String usuario;
        private String contra;
        private String bgatos;

        private MySqlConnectionStringBuilder mcsbConectar;
        private MySqlConnection mcConectar;
        private MySqlCommand mcQuery;
        private MySqlDataReader mrData;

        public EQuery()
        {
            InitializeComponent();
        }

        public void Set(String h, String u, String p, String b)
        {
            servidor = h;
            usuario = u;
            contra = p;
            bgatos = b;
        }

        private void ejecutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.Equals(bgatos, "No database"))
            {
                MessageBox.Show("Seleccione una Base de Datos");
                return;
            }
            else
            {
                if (rtbCuerpo.Text != String.Empty)
                {
                    String[] texto = rtbCuerpo.Text.Split('\n');
                    String code = "";
                    
                    foreach(String linea in texto)
                    {
                        if (linea != String.Empty)
                        {
                            code += linea + " ";
                        }
                    }

                    String[] instrucciones = code.Split(';');

                    mcsbConectar = new MySqlConnectionStringBuilder();
                    mcsbConectar.Server = servidor;
                    mcsbConectar.UserID = usuario;
                    mcsbConectar.Password = contra;
                    mcsbConectar.Database = bgatos;
                    mcConectar = new MySqlConnection(mcsbConectar.ToString());

                    try
                    {
                        mcConectar.Open();




                    }
                    catch(MySqlException ex)
                    {

                    }

                }
                else
                    return;
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EQuery_Load(object sender, EventArgs e)
        {
            this.Text = "Editor -Servidor: " + servidor + " -Usuario: " + usuario + " -Database: " + bgatos;
        }

    }
}
