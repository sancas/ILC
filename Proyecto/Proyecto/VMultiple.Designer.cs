﻿namespace Proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VMultiple));
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new MetroFramework.Controls.MetroTile();
            this.btnAceptar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(172, 1);
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
            // btnCancelar
            // 
            this.btnCancelar.ActiveControl = null;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(194, 155);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 48);
            this.btnCancelar.TabIndex = 5;
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
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(45, 155);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 48);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.TileImage")));
            this.btnAceptar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAceptar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            this.btnAceptar.UseTileImage = true;
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
            this.MaximizeBox = false;
            this.Name = "VMultiple";
            this.Resizable = false;
            this.Text = "Text";
            this.Load += new System.EventHandler(this.VMultiple_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroTextBox txtValor;
        private MetroFramework.Controls.MetroTile btnCancelar;
        private MetroFramework.Controls.MetroTile btnAceptar;
    }
}