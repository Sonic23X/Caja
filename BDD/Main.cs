using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BDD
{
    public partial class Main : Form
    {
        private String servidor;
        private String usuario;
        private String contra;
        private String bgatos;

        public Main()
        {
            InitializeComponent();
        }

        #region Set's

        public void Set(String h, String u, String p, String b)
        {
            servidor = h;
            usuario = u;
            contra = p;
            bgatos = b;
        }

        public void Set(String h, String u, String p)
        {
            servidor = h;
            usuario = u;
            contra = p;
            bgatos = "No database";
        }

        #endregion

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "Conectado a " + servidor + " -Usuario: " + usuario + " -BDD: " + bgatos;
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_N crear = new User_N();
            if (bgatos != String.Empty)
                crear.Set(servidor, usuario, contra, bgatos);
            else
                crear.Set(servidor, usuario, contra);
            crear.Show();
        }

        private void editarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String direccion = "C:\\ProgramData\\MySQL\\MySQL Server 5.7\\my.ini";
            Process.Start("notepad++.exe", direccion);
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login inicio = new Login();

            this.Hide();
            inicio.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EQuery editor = new EQuery();
            editor.Set(usuario, usuario, contra, bgatos);

            editor.Show();
        }

    }
}
