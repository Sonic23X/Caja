namespace BDD
{
    partial class User_N
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBDD = new System.Windows.Forms.TextBox();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.gbPermisos = new System.Windows.Forms.GroupBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.cbCreate = new System.Windows.Forms.CheckBox();
            this.cbDrop = new System.Windows.Forms.CheckBox();
            this.cbAlter = new System.Windows.Forms.CheckBox();
            this.cbInsert = new System.Windows.Forms.CheckBox();
            this.cbLTables = new System.Windows.Forms.CheckBox();
            this.cbSelect = new System.Windows.Forms.CheckBox();
            this.cbSDatabase = new System.Windows.Forms.CheckBox();
            this.cbSView = new System.Windows.Forms.CheckBox();
            this.cbTrigger = new System.Windows.Forms.CheckBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.cbGOption = new System.Windows.Forms.CheckBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbPermisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Rep. Contraseña";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(390, 16);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(167, 20);
            this.txtHost.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(105, 49);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(167, 20);
            this.txtPass.TabIndex = 6;
            // 
            // txtRPass
            // 
            this.txtRPass.Location = new System.Drawing.Point(105, 84);
            this.txtRPass.Name = "txtRPass";
            this.txtRPass.PasswordChar = '*';
            this.txtRPass.Size = new System.Drawing.Size(167, 20);
            this.txtRPass.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "*Base de datos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "*Tabla";
            // 
            // txtBDD
            // 
            this.txtBDD.Location = new System.Drawing.Point(390, 49);
            this.txtBDD.Name = "txtBDD";
            this.txtBDD.Size = new System.Drawing.Size(167, 20);
            this.txtBDD.TabIndex = 10;
            this.txtBDD.Text = "*";
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(390, 84);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(167, 20);
            this.txtTabla.TabIndex = 11;
            this.txtTabla.Text = "*";
            // 
            // gbPermisos
            // 
            this.gbPermisos.Controls.Add(this.cbGOption);
            this.gbPermisos.Controls.Add(this.cbUpdate);
            this.gbPermisos.Controls.Add(this.cbTrigger);
            this.gbPermisos.Controls.Add(this.cbSView);
            this.gbPermisos.Controls.Add(this.cbSDatabase);
            this.gbPermisos.Controls.Add(this.cbSelect);
            this.gbPermisos.Controls.Add(this.cbLTables);
            this.gbPermisos.Controls.Add(this.cbInsert);
            this.gbPermisos.Controls.Add(this.cbAlter);
            this.gbPermisos.Controls.Add(this.cbDrop);
            this.gbPermisos.Controls.Add(this.cbCreate);
            this.gbPermisos.Controls.Add(this.cbAll);
            this.gbPermisos.Location = new System.Drawing.Point(83, 125);
            this.gbPermisos.Name = "gbPermisos";
            this.gbPermisos.Size = new System.Drawing.Size(413, 93);
            this.gbPermisos.TabIndex = 12;
            this.gbPermisos.TabStop = false;
            this.gbPermisos.Text = "Privilegios";
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Checked = true;
            this.cbAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAll.Location = new System.Drawing.Point(7, 20);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(37, 17);
            this.cbAll.TabIndex = 0;
            this.cbAll.Text = "All";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // cbCreate
            // 
            this.cbCreate.AutoSize = true;
            this.cbCreate.Location = new System.Drawing.Point(7, 44);
            this.cbCreate.Name = "cbCreate";
            this.cbCreate.Size = new System.Drawing.Size(57, 17);
            this.cbCreate.TabIndex = 1;
            this.cbCreate.Text = "Create";
            this.cbCreate.UseVisualStyleBackColor = true;
            this.cbCreate.CheckedChanged += new System.EventHandler(this.cbCreate_CheckedChanged);
            // 
            // cbDrop
            // 
            this.cbDrop.AutoSize = true;
            this.cbDrop.Location = new System.Drawing.Point(7, 68);
            this.cbDrop.Name = "cbDrop";
            this.cbDrop.Size = new System.Drawing.Size(49, 17);
            this.cbDrop.TabIndex = 2;
            this.cbDrop.Text = "Drop";
            this.cbDrop.UseVisualStyleBackColor = true;
            this.cbDrop.CheckedChanged += new System.EventHandler(this.cbDrop_CheckedChanged);
            // 
            // cbAlter
            // 
            this.cbAlter.AutoSize = true;
            this.cbAlter.Location = new System.Drawing.Point(90, 19);
            this.cbAlter.Name = "cbAlter";
            this.cbAlter.Size = new System.Drawing.Size(47, 17);
            this.cbAlter.TabIndex = 3;
            this.cbAlter.Text = "Alter";
            this.cbAlter.UseVisualStyleBackColor = true;
            this.cbAlter.CheckedChanged += new System.EventHandler(this.cbAlter_CheckedChanged);
            // 
            // cbInsert
            // 
            this.cbInsert.AutoSize = true;
            this.cbInsert.Location = new System.Drawing.Point(90, 44);
            this.cbInsert.Name = "cbInsert";
            this.cbInsert.Size = new System.Drawing.Size(52, 17);
            this.cbInsert.TabIndex = 4;
            this.cbInsert.Text = "Insert";
            this.cbInsert.UseVisualStyleBackColor = true;
            this.cbInsert.CheckedChanged += new System.EventHandler(this.cbInsert_CheckedChanged);
            // 
            // cbLTables
            // 
            this.cbLTables.AutoSize = true;
            this.cbLTables.Location = new System.Drawing.Point(90, 68);
            this.cbLTables.Name = "cbLTables";
            this.cbLTables.Size = new System.Drawing.Size(85, 17);
            this.cbLTables.TabIndex = 5;
            this.cbLTables.Text = "Lock Tables";
            this.cbLTables.UseVisualStyleBackColor = true;
            this.cbLTables.CheckedChanged += new System.EventHandler(this.cbLTables_CheckedChanged);
            // 
            // cbSelect
            // 
            this.cbSelect.AutoSize = true;
            this.cbSelect.Location = new System.Drawing.Point(194, 19);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(56, 17);
            this.cbSelect.TabIndex = 6;
            this.cbSelect.Text = "Select";
            this.cbSelect.UseVisualStyleBackColor = true;
            this.cbSelect.CheckedChanged += new System.EventHandler(this.cbSelect_CheckedChanged);
            // 
            // cbSDatabase
            // 
            this.cbSDatabase.AutoSize = true;
            this.cbSDatabase.Location = new System.Drawing.Point(194, 44);
            this.cbSDatabase.Name = "cbSDatabase";
            this.cbSDatabase.Size = new System.Drawing.Size(107, 17);
            this.cbSDatabase.TabIndex = 7;
            this.cbSDatabase.Text = "Show Databases";
            this.cbSDatabase.UseVisualStyleBackColor = true;
            this.cbSDatabase.CheckedChanged += new System.EventHandler(this.cbSDatabase_CheckedChanged);
            // 
            // cbSView
            // 
            this.cbSView.AutoSize = true;
            this.cbSView.Location = new System.Drawing.Point(194, 68);
            this.cbSView.Name = "cbSView";
            this.cbSView.Size = new System.Drawing.Size(79, 17);
            this.cbSView.TabIndex = 8;
            this.cbSView.Text = "Show View";
            this.cbSView.UseVisualStyleBackColor = true;
            this.cbSView.CheckedChanged += new System.EventHandler(this.cbSView_CheckedChanged);
            // 
            // cbTrigger
            // 
            this.cbTrigger.AutoSize = true;
            this.cbTrigger.Location = new System.Drawing.Point(318, 19);
            this.cbTrigger.Name = "cbTrigger";
            this.cbTrigger.Size = new System.Drawing.Size(59, 17);
            this.cbTrigger.TabIndex = 9;
            this.cbTrigger.Text = "Trigger";
            this.cbTrigger.UseVisualStyleBackColor = true;
            this.cbTrigger.CheckedChanged += new System.EventHandler(this.cbTrigger_CheckedChanged);
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Location = new System.Drawing.Point(318, 68);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(61, 17);
            this.cbUpdate.TabIndex = 10;
            this.cbUpdate.Text = "Update";
            this.cbUpdate.UseVisualStyleBackColor = true;
            this.cbUpdate.CheckedChanged += new System.EventHandler(this.cbUpdate_CheckedChanged);
            // 
            // cbGOption
            // 
            this.cbGOption.AutoSize = true;
            this.cbGOption.Location = new System.Drawing.Point(318, 44);
            this.cbGOption.Name = "cbGOption";
            this.cbGOption.Size = new System.Drawing.Size(86, 17);
            this.cbGOption.TabIndex = 11;
            this.cbGOption.Text = "Grant Option";
            this.cbGOption.UseVisualStyleBackColor = true;
            this.cbGOption.CheckedChanged += new System.EventHandler(this.cbGOption_CheckedChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(148, 224);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 13;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // User_N
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 258);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.gbPermisos);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.txtBDD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "User_N";
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.User_N_Load);
            this.gbPermisos.ResumeLayout(false);
            this.gbPermisos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBDD;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.GroupBox gbPermisos;
        private System.Windows.Forms.CheckBox cbGOption;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.CheckBox cbTrigger;
        private System.Windows.Forms.CheckBox cbSView;
        private System.Windows.Forms.CheckBox cbSDatabase;
        private System.Windows.Forms.CheckBox cbSelect;
        private System.Windows.Forms.CheckBox cbLTables;
        private System.Windows.Forms.CheckBox cbInsert;
        private System.Windows.Forms.CheckBox cbAlter;
        private System.Windows.Forms.CheckBox cbDrop;
        private System.Windows.Forms.CheckBox cbCreate;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancel;
    }
}