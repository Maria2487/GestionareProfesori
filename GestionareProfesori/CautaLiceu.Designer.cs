namespace GestionareProfesori
{
    partial class CautaLiceu
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
            this.lblNume = new System.Windows.Forms.Label();
            this.comboBoxOras = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblOras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(240, 121);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(432, 20);
            this.txtNume.TabIndex = 5;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(118, 121);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(52, 13);
            this.lblNume.TabIndex = 4;
            this.lblNume.Text = "Denumire";
            // 
            // comboBoxOras
            // 
            this.comboBoxOras.FormattingEnabled = true;
            this.comboBoxOras.Location = new System.Drawing.Point(317, 38);
            this.comboBoxOras.Name = "comboBoxOras";
            this.comboBoxOras.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOras.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 253);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblOras
            // 
            this.lblOras.AutoSize = true;
            this.lblOras.Location = new System.Drawing.Point(237, 41);
            this.lblOras.Name = "lblOras";
            this.lblOras.Size = new System.Drawing.Size(29, 13);
            this.lblOras.TabIndex = 7;
            this.lblOras.Text = "Oras";
            // 
            // CautaLiceu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOras);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.comboBoxOras);
            this.Name = "CautaLiceu";
            this.Text = "CautaLiceu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.ComboBox comboBoxOras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblOras;
    }
}