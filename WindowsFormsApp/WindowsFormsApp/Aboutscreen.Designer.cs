﻿namespace WindowsFormsApp
{
    partial class Aboutscreen
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Board Game\r\n\r\nProducers: YUNUS EMRE KARAGÖZ - MEVLÜT TALHA DOĞANAY\r\nDesign: YUNUS" +
    " EMRE KARAGÖZ - MEVLÜT TALHA DOĞANAY\r\nDevelopment:  YUNUS EMRE KARAGÖZ - MEVLÜT " +
    "TALHA DOĞANAY\r\nDevelopment Date: 2022";
            // 
            // Aboutscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 224);
            this.Controls.Add(this.label1);
            this.Name = "Aboutscreen";
            this.Text = "Aboutscreen";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}