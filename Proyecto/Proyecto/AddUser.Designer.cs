namespace Proyecto
{
    partial class AddUser
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
            this.components = new System.ComponentModel.Container();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.cmbUserRol = new MetroFramework.Controls.MetroComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.btnAceptar = new MetroFramework.Controls.MetroTile();
            this.btnCancelar = new MetroFramework.Controls.MetroTile();
            this.cmbGender = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DisplayIcon = true;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtName.Icon = global::Proyecto.Properties.Resources.Password;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(75, 129);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Nombre";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.ShowClearButton = true;
            this.txtName.Size = new System.Drawing.Size(300, 33);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.UseStyleColors = true;
            this.txtName.WaterMark = "Nombre";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.Icon = global::Proyecto.Properties.Resources.Password2;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(75, 298);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Contraseña";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.Size = new System.Drawing.Size(300, 33);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Contraseña";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbUserRol
            // 
            this.cmbUserRol.DataSource = this.roleBindingSource;
            this.cmbUserRol.DisplayMember = "Name";
            this.cmbUserRol.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbUserRol.FormattingEnabled = true;
            this.cmbUserRol.ItemHeight = 29;
            this.cmbUserRol.Location = new System.Drawing.Point(75, 241);
            this.cmbUserRol.Name = "cmbUserRol";
            this.cmbUserRol.PromptText = "Elija un Rol";
            this.cmbUserRol.Size = new System.Drawing.Size(300, 35);
            this.cmbUserRol.TabIndex = 3;
            this.cmbUserRol.UseSelectable = true;
            this.cmbUserRol.UseStyleColors = true;
            this.cmbUserRol.ValueMember = "Id";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(Proyecto.Data.Role);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = global::Proyecto.Properties.Resources.Email;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DisplayIcon = true;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEmail.Icon = global::Proyecto.Properties.Resources.Email;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(75, 74);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "E-Mail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.ShowClearButton = true;
            this.txtEmail.Size = new System.Drawing.Size(300, 33);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.UseStyleColors = true;
            this.txtEmail.WaterMark = "E-Mail";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAceptar
            // 
            this.btnAceptar.ActiveControl = null;
            this.btnAceptar.Location = new System.Drawing.Point(75, 367);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 48);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TileImage = global::Proyecto.Properties.Resources.Accept;
            this.btnAceptar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAceptar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            this.btnAceptar.UseTileImage = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveControl = null;
            this.btnCancelar.Location = new System.Drawing.Point(250, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 48);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TileImage = global::Proyecto.Properties.Resources.Cancel;
            this.btnCancelar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnCancelar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.UseStyleColors = true;
            this.btnCancelar.UseTileImage = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 29;
            this.cmbGender.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cmbGender.Location = new System.Drawing.Point(75, 184);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.PromptText = "Elija un genero";
            this.cmbGender.Size = new System.Drawing.Size(300, 35);
            this.cmbGender.TabIndex = 2;
            this.cmbGender.UseSelectable = true;
            this.cmbGender.UseStyleColors = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbUserRol);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Name = "AddUser";
            this.Resizable = false;
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroComboBox cmbUserRol;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private MetroFramework.Controls.MetroTile btnAceptar;
        private MetroFramework.Controls.MetroTile btnCancelar;
        private MetroFramework.Controls.MetroComboBox cmbGender;
    }
}