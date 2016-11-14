namespace Proyecto
{
    partial class NuevoArco
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
            this.cmbNodoInicial = new MetroFramework.Controls.MetroComboBox();
            this.cmbNodoFinal = new MetroFramework.Controls.MetroComboBox();
            this.travelProblems = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPeso = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new MetroFramework.Controls.MetroTile();
            this.btnAceptar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // cmbNodoInicial
            // 
            this.cmbNodoInicial.DisplayMember = "Id";
            this.cmbNodoInicial.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbNodoInicial.FormattingEnabled = true;
            this.cmbNodoInicial.ItemHeight = 29;
            this.cmbNodoInicial.Location = new System.Drawing.Point(72, 82);
            this.cmbNodoInicial.Name = "cmbNodoInicial";
            this.cmbNodoInicial.PromptText = "Nodo Origen";
            this.cmbNodoInicial.Size = new System.Drawing.Size(194, 35);
            this.cmbNodoInicial.TabIndex = 0;
            this.cmbNodoInicial.UseSelectable = true;
            this.cmbNodoInicial.UseStyleColors = true;
            this.cmbNodoInicial.ValueMember = "Id";
            // 
            // cmbNodoFinal
            // 
            this.cmbNodoFinal.DisplayMember = "Id";
            this.cmbNodoFinal.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbNodoFinal.FormattingEnabled = true;
            this.cmbNodoFinal.ItemHeight = 29;
            this.cmbNodoFinal.Location = new System.Drawing.Point(72, 136);
            this.cmbNodoFinal.Name = "cmbNodoFinal";
            this.cmbNodoFinal.PromptText = "Nodo Destino";
            this.cmbNodoFinal.Size = new System.Drawing.Size(194, 35);
            this.cmbNodoFinal.TabIndex = 1;
            this.cmbNodoFinal.UseSelectable = true;
            this.cmbNodoFinal.UseStyleColors = true;
            this.cmbNodoFinal.ValueMember = "Id";
            // 
            // travelProblems
            // 
            this.travelProblems.AutoScroll = true;
            this.travelProblems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.travelProblems.Location = new System.Drawing.Point(72, 190);
            this.travelProblems.Name = "travelProblems";
            this.travelProblems.Size = new System.Drawing.Size(194, 100);
            this.travelProblems.TabIndex = 11;
            // 
            // txtPeso
            // 
            // 
            // 
            // 
            this.txtPeso.CustomButton.Image = null;
            this.txtPeso.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtPeso.CustomButton.Name = "";
            this.txtPeso.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtPeso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPeso.CustomButton.TabIndex = 1;
            this.txtPeso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPeso.CustomButton.UseSelectable = true;
            this.txtPeso.CustomButton.Visible = false;
            this.txtPeso.DisplayIcon = true;
            this.txtPeso.Enabled = false;
            this.txtPeso.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPeso.Icon = global::Proyecto.Properties.Resources.Peso1;
            this.txtPeso.Lines = new string[0];
            this.txtPeso.Location = new System.Drawing.Point(72, 309);
            this.txtPeso.MaxLength = 32767;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PasswordChar = '\0';
            this.txtPeso.PromptText = "Peso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPeso.SelectedText = "";
            this.txtPeso.SelectionLength = 0;
            this.txtPeso.SelectionStart = 0;
            this.txtPeso.ShortcutsEnabled = true;
            this.txtPeso.Size = new System.Drawing.Size(194, 35);
            this.txtPeso.TabIndex = 12;
            this.txtPeso.UseSelectable = true;
            this.txtPeso.UseStyleColors = true;
            this.txtPeso.WaterMark = "Peso";
            this.txtPeso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPeso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveControl = null;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(194, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 48);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TileImage = global::Proyecto.Properties.Resources.Cancel;
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
            this.btnAceptar.Location = new System.Drawing.Point(19, 370);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 48);
            this.btnAceptar.TabIndex = 9;
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
            // NuevoArco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 441);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.travelProblems);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbNodoFinal);
            this.Controls.Add(this.cmbNodoInicial);
            this.MaximizeBox = false;
            this.Name = "NuevoArco";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Agregar Arista";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.NuevoArco_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnCancelar;
        private MetroFramework.Controls.MetroTile btnAceptar;
        private System.Windows.Forms.FlowLayoutPanel travelProblems;
        public MetroFramework.Controls.MetroTextBox txtPeso;
        public MetroFramework.Controls.MetroComboBox cmbNodoInicial;
        public MetroFramework.Controls.MetroComboBox cmbNodoFinal;
    }
}