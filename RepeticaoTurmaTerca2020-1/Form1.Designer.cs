﻿namespace RepeticaoTurmaTerca2020_1
{
    partial class FrmNumeros
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
            this.lbNumeros = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumeros
            // 
            this.lbNumeros.FormattingEnabled = true;
            this.lbNumeros.Location = new System.Drawing.Point(13, 13);
            this.lbNumeros.Name = "lbNumeros";
            this.lbNumeros.Size = new System.Drawing.Size(120, 342);
            this.lbNumeros.TabIndex = 0;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(157, 13);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(75, 23);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(157, 72);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 23);
            this.btnWhile.TabIndex = 2;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(157, 137);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 23);
            this.btnDo.TabIndex = 3;
            this.btnDo.Text = "Do - While";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(157, 332);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 370);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.lbNumeros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNumeros";
            this.Text = "Teste Estruturas de Repetição";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNumeros;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnLimpar;
    }
}

