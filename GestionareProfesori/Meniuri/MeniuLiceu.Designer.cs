namespace GestionareProfesori
{
    partial class MeniuLiceu
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
            this.comboBoxOras = new System.Windows.Forms.ComboBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblOras = new System.Windows.Forms.Label();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.buttonResetare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonLiceu = new System.Windows.Forms.RadioButton();
            this.radioButtonColegiu = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // comboBoxOras
            // 
            this.comboBoxOras.FormattingEnabled = true;
            this.comboBoxOras.Location = new System.Drawing.Point(152, 135);
            this.comboBoxOras.Name = "comboBoxOras";
            this.comboBoxOras.Size = new System.Drawing.Size(242, 21);
            this.comboBoxOras.TabIndex = 0;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(52, 73);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(52, 13);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Denumire";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(152, 73);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(242, 20);
            this.txtNume.TabIndex = 2;
            // 
            // lblOras
            // 
            this.lblOras.AutoSize = true;
            this.lblOras.Location = new System.Drawing.Point(52, 138);
            this.lblOras.Name = "lblOras";
            this.lblOras.Size = new System.Drawing.Size(29, 13);
            this.lblOras.TabIndex = 8;
            this.lblOras.Text = "Oras";
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(418, 192);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(75, 23);
            this.buttonSterge.TabIndex = 20;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.Location = new System.Drawing.Point(319, 192);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvare.TabIndex = 19;
            this.buttonSalvare.Text = "Salveaza";
            this.buttonSalvare.UseVisualStyleBackColor = true;
            this.buttonSalvare.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // buttonResetare
            // 
            this.buttonResetare.Location = new System.Drawing.Point(415, 96);
            this.buttonResetare.Name = "buttonResetare";
            this.buttonResetare.Size = new System.Drawing.Size(151, 23);
            this.buttonResetare.TabIndex = 21;
            this.buttonResetare.Text = "Resetare date initiale";
            this.buttonResetare.UseVisualStyleBackColor = true;
            this.buttonResetare.Click += new System.EventHandler(this.buttonResetare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Introduceti doar numele Liceului";
            // 
            // radioButtonLiceu
            // 
            this.radioButtonLiceu.AutoSize = true;
            this.radioButtonLiceu.Location = new System.Drawing.Point(199, 29);
            this.radioButtonLiceu.Name = "radioButtonLiceu";
            this.radioButtonLiceu.Size = new System.Drawing.Size(51, 17);
            this.radioButtonLiceu.TabIndex = 23;
            this.radioButtonLiceu.TabStop = true;
            this.radioButtonLiceu.Text = "Liceu";
            this.radioButtonLiceu.UseVisualStyleBackColor = true;
            // 
            // radioButtonColegiu
            // 
            this.radioButtonColegiu.AutoSize = true;
            this.radioButtonColegiu.Location = new System.Drawing.Point(274, 29);
            this.radioButtonColegiu.Name = "radioButtonColegiu";
            this.radioButtonColegiu.Size = new System.Drawing.Size(60, 17);
            this.radioButtonColegiu.TabIndex = 24;
            this.radioButtonColegiu.TabStop = true;
            this.radioButtonColegiu.Text = "Colegiu";
            this.radioButtonColegiu.UseVisualStyleBackColor = true;
            // 
            // MeniuLiceu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 227);
            this.Controls.Add(this.radioButtonColegiu);
            this.Controls.Add(this.radioButtonLiceu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonResetare);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.lblOras);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.comboBoxOras);
            this.Name = "MeniuLiceu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuLiceu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeniuLiceu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOras;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblOras;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.Button buttonResetare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonLiceu;
        private System.Windows.Forms.RadioButton radioButtonColegiu;
    }
}