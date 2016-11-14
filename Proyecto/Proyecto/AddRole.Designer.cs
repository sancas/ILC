namespace Proyecto
{
    partial class AddRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRole));
            this.btnCancelar = new MetroFramework.Controls.MetroTile();
            this.btnAceptar = new MetroFramework.Controls.MetroTile();
            this.txtRole = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveControl = null;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(213, 194);
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
            this.btnAceptar.Location = new System.Drawing.Point(38, 194);
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
            // txtRole
            // 
            // 
            // 
            // 
            this.txtRole.CustomButton.Image = global::Proyecto.Properties.Resources.Email;
            this.txtRole.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtRole.CustomButton.Name = "";
            this.txtRole.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtRole.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRole.CustomButton.TabIndex = 1;
            this.txtRole.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRole.CustomButton.UseSelectable = true;
            this.txtRole.CustomButton.Visible = false;
            this.txtRole.DisplayIcon = true;
            this.txtRole.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRole.Icon = global::Proyecto.Properties.Resources.Roles;
            this.txtRole.Lines = new string[0];
            this.txtRole.Location = new System.Drawing.Point(63, 111);
            this.txtRole.MaxLength = 32767;
            this.txtRole.Name = "txtRole";
            this.txtRole.PasswordChar = '\0';
            this.txtRole.PromptText = "Role";
            this.txtRole.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRole.SelectedText = "";
            this.txtRole.SelectionLength = 0;
            this.txtRole.SelectionStart = 0;
            this.txtRole.ShortcutsEnabled = true;
            this.txtRole.ShowClearButton = true;
            this.txtRole.Size = new System.Drawing.Size(250, 33);
            this.txtRole.TabIndex = 9;
            this.txtRole.UseSelectable = true;
            this.txtRole.UseStyleColors = true;
            this.txtRole.WaterMark = "Role";
            this.txtRole.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRole.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 269);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddRole";
            this.Resizable = false;
            this.Text = "Agregar Role";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnCancelar;
        private MetroFramework.Controls.MetroTile btnAceptar;
        private MetroFramework.Controls.MetroTextBox txtRole;
    }
}