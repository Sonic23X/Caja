namespace BDD
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblUsuario_Login = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cbDBB = new System.Windows.Forms.ComboBox();
            this.bwHilo = new System.ComponentModel.BackgroundWorker();
            this.tHilo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(27, 28);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(46, 13);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor";
            // 
            // lblUsuario_Login
            // 
            this.lblUsuario_Login.AutoSize = true;
            this.lblUsuario_Login.Location = new System.Drawing.Point(30, 65);
            this.lblUsuario_Login.Name = "lblUsuario_Login";
            this.lblUsuario_Login.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario_Login.TabIndex = 1;
            this.lblUsuario_Login.Text = "Usuario";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(12, 103);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(61, 13);
            this.lblContra.TabIndex = 2;
            this.lblContra.Text = "Contraseña";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(91, 25);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(153, 20);
            this.txtServer.TabIndex = 3;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(91, 62);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(153, 20);
            this.txtUser.TabIndex = 4;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConectar.Location = new System.Drawing.Point(43, 181);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(152, 181);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 7;
            this.btnPrueba.Text = "Probar";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(20, 139);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 8;
            this.lblDatabase.Text = "Database";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(91, 100);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(153, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // cbDBB
            // 
            this.cbDBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDBB.FormattingEnabled = true;
            this.cbDBB.Location = new System.Drawing.Point(91, 136);
            this.cbDBB.Name = "cbDBB";
            this.cbDBB.Size = new System.Drawing.Size(153, 21);
            this.cbDBB.TabIndex = 9;
            // 
            // bwHilo
            // 
            this.bwHilo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwHilo_DoWork);
            this.bwHilo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwHilo_RunWorkerCompleted);
            // 
            // tHilo
            // 
            this.tHilo.Enabled = true;
            this.tHilo.Interval = 500;
            this.tHilo.Tick += new System.EventHandler(this.tHilo_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 222);
            this.Controls.Add(this.cbDBB);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblUsuario_Login);
            this.Controls.Add(this.lblServidor);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(277, 261);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(277, 261);
            this.Name = "Login";
            this.Text = "Iniciar Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblUsuario_Login;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ComboBox cbDBB;
        private System.ComponentModel.BackgroundWorker bwHilo;
        private System.Windows.Forms.Timer tHilo;
    }
}

