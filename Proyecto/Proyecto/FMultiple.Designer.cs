namespace Proyecto
{
    partial class FMultiple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMultiple));
            this.cmbInicial = new MetroFramework.Controls.MetroComboBox();
            this.cmbFinal = new MetroFramework.Controls.MetroComboBox();
            this.btnCancelar = new MetroFramework.Controls.MetroTile();
            this.btnAceptar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // cmbInicial
            // 
            this.cmbInicial.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbInicial.FormattingEnabled = true;
            this.cmbInicial.ItemHeight = 29;
            this.cmbInicial.Location = new System.Drawing.Point(87, 80);
            this.cmbInicial.Name = "cmbInicial";
            this.cmbInicial.PromptText = "WaterMark";
            this.cmbInicial.Size = new System.Drawing.Size(200, 35);
            this.cmbInicial.TabIndex = 0;
            this.cmbInicial.UseSelectable = true;
            this.cmbInicial.UseStyleColors = true;
            // 
            // cmbFinal
            // 
            this.cmbFinal.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbFinal.FormattingEnabled = true;
            this.cmbFinal.ItemHeight = 29;
            this.cmbFinal.Location = new System.Drawing.Point(87, 121);
            this.cmbFinal.Name = "cmbFinal";
            this.cmbFinal.PromptText = "WaterMark";
            this.cmbFinal.Size = new System.Drawing.Size(200, 35);
            this.cmbFinal.TabIndex = 1;
            this.cmbFinal.UseSelectable = true;
            this.cmbFinal.UseStyleColors = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveControl = null;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(196, 167);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 48);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TileImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.TileImage")));
            this.btnCancelar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnCancelar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.UseStyleColors = true;
            this.btnCancelar.UseTileImage = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.ActiveControl = null;
            this.btnAceptar.Location = new System.Drawing.Point(47, 167);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 48);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.TileImage")));
            this.btnAceptar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAceptar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            this.btnAceptar.UseTileImage = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(374, 238);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbFinal);
            this.Controls.Add(this.cmbInicial);
            this.Name = "FMultiple";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Text";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnCancelar;
        private MetroFramework.Controls.MetroTile btnAceptar;
        public MetroFramework.Controls.MetroComboBox cmbInicial;
        public MetroFramework.Controls.MetroComboBox cmbFinal;
    }
}