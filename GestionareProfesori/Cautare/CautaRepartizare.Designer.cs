namespace GestionareProfesori
{
    partial class CautaRepartizare
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
            this.lblLiceu = new System.Windows.Forms.Label();
            this.lblOras = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.comboBoxLiceu = new System.Windows.Forms.ComboBox();
            this.comboBoxOras = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLiceu
            // 
            this.lblLiceu.AutoSize = true;
            this.lblLiceu.Location = new System.Drawing.Point(316, 46);
            this.lblLiceu.Name = "lblLiceu";
            this.lblLiceu.Size = new System.Drawing.Size(33, 13);
            this.lblLiceu.TabIndex = 24;
            this.lblLiceu.Text = "Liceu";
            // 
            // lblOras
            // 
            this.lblOras.AutoSize = true;
            this.lblOras.Location = new System.Drawing.Point(12, 46);
            this.lblOras.Name = "lblOras";
            this.lblOras.Size = new System.Drawing.Size(29, 13);
            this.lblOras.TabIndex = 23;
            this.lblOras.Text = "Oras";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 191);
            this.dataGridView1.TabIndex = 22;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(220, 172);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 21;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(220, 111);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 20;
            this.lblNume.Text = "Nume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(305, 165);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(176, 20);
            this.txtPrenume.TabIndex = 19;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(305, 111);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(176, 20);
            this.txtNume.TabIndex = 18;
            // 
            // comboBoxLiceu
            // 
            this.comboBoxLiceu.FormattingEnabled = true;
            this.comboBoxLiceu.Location = new System.Drawing.Point(355, 43);
            this.comboBoxLiceu.Name = "comboBoxLiceu";
            this.comboBoxLiceu.Size = new System.Drawing.Size(355, 21);
            this.comboBoxLiceu.TabIndex = 17;
            // 
            // comboBoxOras
            // 
            this.comboBoxOras.FormattingEnabled = true;
            this.comboBoxOras.Location = new System.Drawing.Point(66, 43);
            this.comboBoxOras.Name = "comboBoxOras";
            this.comboBoxOras.Size = new System.Drawing.Size(226, 21);
            this.comboBoxOras.TabIndex = 16;
            // 
            // CautaRepartizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.lblLiceu);
            this.Controls.Add(this.lblOras);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.comboBoxLiceu);
            this.Controls.Add(this.comboBoxOras);
            this.Name = "CautaRepartizare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CautaRepartizare";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLiceu;
        private System.Windows.Forms.Label lblOras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.ComboBox comboBoxLiceu;
        private System.Windows.Forms.ComboBox comboBoxOras;
    }
}