namespace Proyecto
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.TopPanel = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutChangePasswordTop = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.lblAuthUserEmail = new MetroFramework.Controls.MetroLabel();
            this.lblAuthUserName = new MetroFramework.Controls.MetroLabel();
            this.lblAuthUserId = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword2 = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new MetroFramework.Controls.MetroTile();
            this.btnAceptar = new MetroFramework.Controls.MetroTile();
            this.TopPanel.SuspendLayout();
            this.tableLayoutChangePasswordTop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.tableLayoutChangePasswordTop);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.HorizontalScrollbarBarColor = true;
            this.TopPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.TopPanel.HorizontalScrollbarSize = 10;
            this.TopPanel.Location = new System.Drawing.Point(20, 60);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(410, 74);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.VerticalScrollbarBarColor = true;
            this.TopPanel.VerticalScrollbarHighlightOnWheel = false;
            this.TopPanel.VerticalScrollbarSize = 10;
            // 
            // tableLayoutChangePasswordTop
            // 
            this.tableLayoutChangePasswordTop.ColumnCount = 3;
            this.tableLayoutChangePasswordTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutChangePasswordTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutChangePasswordTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutChangePasswordTop.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutChangePasswordTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutChangePasswordTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutChangePasswordTop.Name = "tableLayoutChangePasswordTop";
            this.tableLayoutChangePasswordTop.RowCount = 1;
            this.tableLayoutChangePasswordTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutChangePasswordTop.Size = new System.Drawing.Size(410, 74);
            this.tableLayoutChangePasswordTop.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.avatarPictureBox);
            this.flowLayoutPanel1.Controls.Add(this.lblAuthUserEmail);
            this.flowLayoutPanel1.Controls.Add(this.lblAuthUserName);
            this.flowLayoutPanel1.Controls.Add(this.lblAuthUserId);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(85, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 68);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Location = new System.Drawing.Point(3, 17);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(48, 48);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.avatarPictureBox.TabIndex = 7;
            this.avatarPictureBox.TabStop = false;
            // 
            // lblAuthUserEmail
            // 
            this.lblAuthUserEmail.AutoSize = true;
            this.lblAuthUserEmail.Location = new System.Drawing.Point(57, 49);
            this.lblAuthUserEmail.Name = "lblAuthUserEmail";
            this.lblAuthUserEmail.Size = new System.Drawing.Size(95, 19);
            this.lblAuthUserEmail.TabIndex = 9;
            this.lblAuthUserEmail.Text = "AuthUser.Email";
            this.lblAuthUserEmail.UseStyleColors = true;
            // 
            // lblAuthUserName
            // 
            this.lblAuthUserName.AutoSize = true;
            this.lblAuthUserName.Location = new System.Drawing.Point(57, 30);
            this.lblAuthUserName.Name = "lblAuthUserName";
            this.lblAuthUserName.Size = new System.Drawing.Size(99, 19);
            this.lblAuthUserName.TabIndex = 8;
            this.lblAuthUserName.Text = "AuthUser.Name";
            this.lblAuthUserName.UseStyleColors = true;
            // 
            // lblAuthUserId
            // 
            this.lblAuthUserId.AutoSize = true;
            this.lblAuthUserId.Location = new System.Drawing.Point(57, 11);
            this.lblAuthUserId.Name = "lblAuthUserId";
            this.lblAuthUserId.Size = new System.Drawing.Size(74, 19);
            this.lblAuthUserId.TabIndex = 10;
            this.lblAuthUserId.Text = "AuthUser.Id";
            this.lblAuthUserId.UseStyleColors = true;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.Icon = global::Proyecto.Properties.Resources.Password;
            this.txtPassword.IconRight = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(75, 161);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Contraseña";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(250, 33);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Contraseña";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword2
            // 
            // 
            // 
            // 
            this.txtPassword2.CustomButton.Image = null;
            this.txtPassword2.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtPassword2.CustomButton.Name = "";
            this.txtPassword2.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtPassword2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword2.CustomButton.TabIndex = 1;
            this.txtPassword2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword2.CustomButton.UseSelectable = true;
            this.txtPassword2.CustomButton.Visible = false;
            this.txtPassword2.DisplayIcon = true;
            this.txtPassword2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword2.Icon = global::Proyecto.Properties.Resources.Password2;
            this.txtPassword2.IconRight = true;
            this.txtPassword2.Lines = new string[0];
            this.txtPassword2.Location = new System.Drawing.Point(75, 206);
            this.txtPassword2.MaxLength = 32767;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '●';
            this.txtPassword2.PromptText = "Repetir contraseña";
            this.txtPassword2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword2.SelectedText = "";
            this.txtPassword2.SelectionLength = 0;
            this.txtPassword2.SelectionStart = 0;
            this.txtPassword2.ShortcutsEnabled = true;
            this.txtPassword2.Size = new System.Drawing.Size(250, 33);
            this.txtPassword2.TabIndex = 2;
            this.txtPassword2.UseSelectable = true;
            this.txtPassword2.UseStyleColors = true;
            this.txtPassword2.UseSystemPasswordChar = true;
            this.txtPassword2.WaterMark = "Repetir contraseña";
            this.txtPassword2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveControl = null;
            this.btnCancelar.Location = new System.Drawing.Point(250, 249);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 48);
            this.btnCancelar.TabIndex = 8;
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
            // btnAceptar
            // 
            this.btnAceptar.ActiveControl = null;
            this.btnAceptar.Location = new System.Drawing.Point(75, 249);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 48);
            this.btnAceptar.TabIndex = 7;
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
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePassword";
            this.Resizable = false;
            this.Text = "Cambiar contraseña";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.TopPanel.ResumeLayout(false);
            this.tableLayoutChangePasswordTop.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel TopPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutChangePasswordTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private MetroFramework.Controls.MetroLabel lblAuthUserEmail;
        private MetroFramework.Controls.MetroLabel lblAuthUserName;
        private MetroFramework.Controls.MetroLabel lblAuthUserId;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword2;
        private MetroFramework.Controls.MetroTile btnCancelar;
        private MetroFramework.Controls.MetroTile btnAceptar;
    }
}