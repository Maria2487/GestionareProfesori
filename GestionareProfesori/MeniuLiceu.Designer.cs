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
            this.SuspendLayout();
            // 
            // comboBoxOras
            // 
            this.comboBoxOras.FormattingEnabled = true;
            this.comboBoxOras.Location = new System.Drawing.Point(221, 44);
            this.comboBoxOras.Name = "comboBoxOras";
            this.comboBoxOras.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOras.TabIndex = 0;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(146, 126);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(52, 13);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Denumire";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(268, 126);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 20);
            this.txtNume.TabIndex = 2;
            // 
            // lblOras
            // 
            this.lblOras.AutoSize = true;
            this.lblOras.Location = new System.Drawing.Point(156, 47);
            this.lblOras.Name = "lblOras";
            this.lblOras.Size = new System.Drawing.Size(29, 13);
            this.lblOras.TabIndex = 8;
            this.lblOras.Text = "Oras";
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(507, 297);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(75, 23);
            this.buttonSterge.TabIndex = 20;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.Location = new System.Drawing.Point(408, 297);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvare.TabIndex = 19;
            this.buttonSalvare.Text = "Salveaza";
            this.buttonSalvare.UseVisualStyleBackColor = true;
            // 
            // MeniuLiceu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.lblOras);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.comboBoxOras);
            this.Name = "MeniuLiceu";
            this.Text = "MeniuLiceu";
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
    }
}