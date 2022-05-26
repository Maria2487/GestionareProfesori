namespace GestionareProfesori
{
    partial class CautaProfesor
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
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.comboBoxLiceu = new System.Windows.Forms.ComboBox();
            this.comboBoxOras = new System.Windows.Forms.ComboBox();
            this.dataGridViewPersoana = new System.Windows.Forms.DataGridView();
            this.lblOras = new System.Windows.Forms.Label();
            this.lblLiceu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoana)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(220, 203);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 12;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(220, 142);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 11;
            this.lblNume.Text = "Nume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(305, 196);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(176, 20);
            this.txtPrenume.TabIndex = 10;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(305, 142);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(176, 20);
            this.txtNume.TabIndex = 9;
            // 
            // comboBoxLiceu
            // 
            this.comboBoxLiceu.FormattingEnabled = true;
            this.comboBoxLiceu.Location = new System.Drawing.Point(369, 74);
            this.comboBoxLiceu.Name = "comboBoxLiceu";
            this.comboBoxLiceu.Size = new System.Drawing.Size(387, 21);
            this.comboBoxLiceu.TabIndex = 8;
            // 
            // comboBoxOras
            // 
            this.comboBoxOras.FormattingEnabled = true;
            this.comboBoxOras.Location = new System.Drawing.Point(66, 74);
            this.comboBoxOras.Name = "comboBoxOras";
            this.comboBoxOras.Size = new System.Drawing.Size(154, 21);
            this.comboBoxOras.TabIndex = 7;
            // 
            // dataGridViewPersoana
            // 
            this.dataGridViewPersoana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersoana.Location = new System.Drawing.Point(15, 247);
            this.dataGridViewPersoana.Name = "dataGridViewPersoana";
            this.dataGridViewPersoana.Size = new System.Drawing.Size(773, 191);
            this.dataGridViewPersoana.TabIndex = 13;
            // 
            // lblOras
            // 
            this.lblOras.AutoSize = true;
            this.lblOras.Location = new System.Drawing.Point(12, 77);
            this.lblOras.Name = "lblOras";
            this.lblOras.Size = new System.Drawing.Size(29, 13);
            this.lblOras.TabIndex = 14;
            this.lblOras.Text = "Oras";
            // 
            // lblLiceu
            // 
            this.lblLiceu.AutoSize = true;
            this.lblLiceu.Location = new System.Drawing.Point(313, 82);
            this.lblLiceu.Name = "lblLiceu";
            this.lblLiceu.Size = new System.Drawing.Size(33, 13);
            this.lblLiceu.TabIndex = 15;
            this.lblLiceu.Text = "Liceu";
            // 
            // CautaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLiceu);
            this.Controls.Add(this.lblOras);
            this.Controls.Add(this.dataGridViewPersoana);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.comboBoxLiceu);
            this.Controls.Add(this.comboBoxOras);
            this.Name = "CautaProfesor";
            this.Text = "CautaPersoana";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.ComboBox comboBoxLiceu;
        private System.Windows.Forms.ComboBox comboBoxOras;
        private System.Windows.Forms.DataGridView dataGridViewPersoana;
        private System.Windows.Forms.Label lblOras;
        private System.Windows.Forms.Label lblLiceu;
    }
}