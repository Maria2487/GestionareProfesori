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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.comboBoxOras = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblOras = new System.Windows.Forms.Label();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.buttonResetare = new System.Windows.Forms.Button();
            this.buttonInapoiLaMeniu = new System.Windows.Forms.Button();
            this.labelInformatiiGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(189, 154);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(432, 20);
            this.txtNume.TabIndex = 5;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(40, 145);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(118, 29);
            this.lblNume.TabIndex = 4;
            this.lblNume.Text = "Denumire";
            // 
            // comboBoxOras
            // 
            this.comboBoxOras.FormattingEnabled = true;
            this.comboBoxOras.Location = new System.Drawing.Point(189, 85);
            this.comboBoxOras.Name = "comboBoxOras";
            this.comboBoxOras.Size = new System.Drawing.Size(432, 21);
            this.comboBoxOras.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(126)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 241);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblOras
            // 
            this.lblOras.AutoSize = true;
            this.lblOras.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOras.Location = new System.Drawing.Point(40, 77);
            this.lblOras.Name = "lblOras";
            this.lblOras.Size = new System.Drawing.Size(65, 29);
            this.lblOras.TabIndex = 7;
            this.lblOras.Text = "Oras";
            // 
            // buttonCauta
            // 
            this.buttonCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCauta.Location = new System.Drawing.Point(648, 117);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(140, 30);
            this.buttonCauta.TabIndex = 8;
            this.buttonCauta.Text = "Cauta";
            this.buttonCauta.UseVisualStyleBackColor = false;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // buttonResetare
            // 
            this.buttonResetare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonResetare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetare.Location = new System.Drawing.Point(648, 191);
            this.buttonResetare.Name = "buttonResetare";
            this.buttonResetare.Size = new System.Drawing.Size(140, 30);
            this.buttonResetare.TabIndex = 9;
            this.buttonResetare.Text = "Resetare";
            this.buttonResetare.UseVisualStyleBackColor = false;
            this.buttonResetare.Click += new System.EventHandler(this.buttonResetare_Click);
            // 
            // buttonInapoiLaMeniu
            // 
            this.buttonInapoiLaMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonInapoiLaMeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInapoiLaMeniu.Location = new System.Drawing.Point(648, 12);
            this.buttonInapoiLaMeniu.Name = "buttonInapoiLaMeniu";
            this.buttonInapoiLaMeniu.Size = new System.Drawing.Size(140, 30);
            this.buttonInapoiLaMeniu.TabIndex = 10;
            this.buttonInapoiLaMeniu.Text = "Pagina Principala";
            this.buttonInapoiLaMeniu.UseVisualStyleBackColor = false;
            this.buttonInapoiLaMeniu.Click += new System.EventHandler(this.buttonInapoiLaMeniu_Click);
            // 
            // labelInformatiiGrid
            // 
            this.labelInformatiiGrid.AutoSize = true;
            this.labelInformatiiGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
            this.labelInformatiiGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformatiiGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(201)))));
            this.labelInformatiiGrid.Location = new System.Drawing.Point(24, 473);
            this.labelInformatiiGrid.Name = "labelInformatiiGrid";
            this.labelInformatiiGrid.Size = new System.Drawing.Size(570, 17);
            this.labelInformatiiGrid.TabIndex = 11;
            this.labelInformatiiGrid.Text = "Apasati dublu click pe elementul dorit din lista pentu a continua spre meniul de " +
    "modificare";
            // 
            // CautaLiceu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.labelInformatiiGrid);
            this.Controls.Add(this.buttonInapoiLaMeniu);
            this.Controls.Add(this.buttonResetare);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.lblOras);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.comboBoxOras);
            this.Name = "CautaLiceu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.Button buttonResetare;
        private System.Windows.Forms.Button buttonInapoiLaMeniu;
        private System.Windows.Forms.Label labelInformatiiGrid;
    }
}