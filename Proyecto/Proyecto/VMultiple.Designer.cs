namespace Proyecto
{
    partial class VMultiple
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
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtValor.Lines = new string[0];
            this.txtValor.Location = new System.Drawing.Point(85, 86);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.PromptText = "WaterMark";
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(200, 29);
            this.txtValor.TabIndex = 0;
            this.txtValor.UseSelectable = true;
            this.txtValor.UseStyleColors = true;
            this.txtValor.WaterMark = "WaterMark";
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAceptar.Highlight = true;
            this.btnAceptar.Location = new System.Drawing.Point(55, 147);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 29);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancelar.Highlight = true;
            this.btnCancelar.Location = new System.Drawing.Point(215, 147);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 29);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.UseStyleColors = true;
            // 
            // VMultiple
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(370, 226);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtValor);
            this.KeyPreview = true;
            this.Name = "VMultiple";
            this.Text = "Text";
            this.Load += new System.EventHandler(this.VMultiple_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        public MetroFramework.Controls.MetroTextBox txtValor;
    }
}