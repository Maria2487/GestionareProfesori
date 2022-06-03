namespace GestionareProfesori
{
    partial class MeniuProfesor
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.comboBoxMaterie = new System.Windows.Forms.ComboBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.lblMaterie = new System.Windows.Forms.Label();
            this.buttonResetare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(152, 44);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(176, 20);
            this.txtNume.TabIndex = 2;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(149, 102);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(176, 20);
            this.txtPrenume.TabIndex = 3;
            // 
            // comboBoxMaterie
            // 
            this.comboBoxMaterie.FormattingEnabled = true;
            this.comboBoxMaterie.Location = new System.Drawing.Point(152, 170);
            this.comboBoxMaterie.Name = "comboBoxMaterie";
            this.comboBoxMaterie.Size = new System.Drawing.Size(176, 21);
            this.comboBoxMaterie.TabIndex = 4;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(67, 44);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 5;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(67, 105);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 6;
            this.lblPrenume.Text = "Prenume";
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonSalvare.Location = new System.Drawing.Point(318, 285);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvare.TabIndex = 17;
            this.buttonSalvare.Text = "Salveaza";
            this.buttonSalvare.UseVisualStyleBackColor = false;
            this.buttonSalvare.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonSterge.Location = new System.Drawing.Point(442, 285);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(75, 23);
            this.buttonSterge.TabIndex = 18;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = false;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // lblMaterie
            // 
            this.lblMaterie.AutoSize = true;
            this.lblMaterie.Location = new System.Drawing.Point(70, 177);
            this.lblMaterie.Name = "lblMaterie";
            this.lblMaterie.Size = new System.Drawing.Size(42, 13);
            this.lblMaterie.TabIndex = 19;
            this.lblMaterie.Text = "Materie";
            // 
            // buttonResetare
            // 
            this.buttonResetare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonResetare.Location = new System.Drawing.Point(371, 105);
            this.buttonResetare.Name = "buttonResetare";
            this.buttonResetare.Size = new System.Drawing.Size(131, 23);
            this.buttonResetare.TabIndex = 20;
            this.buttonResetare.Text = "Resetare date initiale";
            this.buttonResetare.UseVisualStyleBackColor = false;
            this.buttonResetare.Click += new System.EventHandler(this.buttonResetare_Click);
            // 
            // MeniuProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(528, 324);
            this.Controls.Add(this.buttonResetare);
            this.Controls.Add(this.lblMaterie);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.comboBoxMaterie);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Name = "MeniuProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuPersoana";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeniuProfesor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.ComboBox comboBoxMaterie;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Label lblMaterie;
        private System.Windows.Forms.Button buttonResetare;
    }
}