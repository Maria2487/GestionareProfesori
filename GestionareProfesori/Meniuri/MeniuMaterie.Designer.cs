﻿namespace GestionareProfesori
{
    partial class MeniuMaterie
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
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.buttonResetare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(56, 88);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(52, 13);
            this.lblNume.TabIndex = 6;
            this.lblNume.Text = "Denumire";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(149, 88);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 20);
            this.txtNume.TabIndex = 7;
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(373, 201);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(75, 23);
            this.buttonSterge.TabIndex = 20;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.Location = new System.Drawing.Point(274, 201);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvare.TabIndex = 19;
            this.buttonSalvare.Text = "Salveaza";
            this.buttonSalvare.UseVisualStyleBackColor = true;
            this.buttonSalvare.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // buttonResetare
            // 
            this.buttonResetare.Location = new System.Drawing.Point(304, 86);
            this.buttonResetare.Name = "buttonResetare";
            this.buttonResetare.Size = new System.Drawing.Size(151, 23);
            this.buttonResetare.TabIndex = 22;
            this.buttonResetare.Text = "Resetare date initiale";
            this.buttonResetare.UseVisualStyleBackColor = true;
            this.buttonResetare.Click += new System.EventHandler(this.buttonResetare_Click);
            // 
            // MeniuMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 240);
            this.Controls.Add(this.buttonResetare);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Name = "MeniuMaterie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuMaterie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeniuMaterie_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.Button buttonResetare;
    }
}