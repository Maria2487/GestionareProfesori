namespace GestionareProfesori
{
    partial class MeniuRepartizare
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
            this.lblMaterie = new System.Windows.Forms.Label();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.lblLiceu = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.comboBoxLiceu = new System.Windows.Forms.ComboBox();
            this.txtMaterie = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonResetare = new System.Windows.Forms.Button();
            this.buttonCautaProfesor = new System.Windows.Forms.Button();
            this.labelInformatiiGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaterie
            // 
            this.lblMaterie.AutoSize = true;
            this.lblMaterie.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterie.Location = new System.Drawing.Point(12, 188);
            this.lblMaterie.Name = "lblMaterie";
            this.lblMaterie.Size = new System.Drawing.Size(94, 29);
            this.lblMaterie.TabIndex = 31;
            this.lblMaterie.Text = "Materie";
            // 
            // buttonSterge
            // 
            this.buttonSterge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSterge.Location = new System.Drawing.Point(698, 449);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(150, 30);
            this.buttonSterge.TabIndex = 30;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = false;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvare.Location = new System.Drawing.Point(698, 398);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(150, 30);
            this.buttonSalvare.TabIndex = 29;
            this.buttonSalvare.Text = "Salveaza";
            this.buttonSalvare.UseVisualStyleBackColor = false;
            this.buttonSalvare.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // lblLiceu
            // 
            this.lblLiceu.AutoSize = true;
            this.lblLiceu.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiceu.Location = new System.Drawing.Point(12, 25);
            this.lblLiceu.Name = "lblLiceu";
            this.lblLiceu.Size = new System.Drawing.Size(71, 29);
            this.lblLiceu.TabIndex = 28;
            this.lblLiceu.Text = "Liceu";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.Location = new System.Drawing.Point(12, 146);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(111, 29);
            this.lblPrenume.TabIndex = 26;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(12, 104);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(78, 29);
            this.lblNume.TabIndex = 25;
            this.lblNume.Text = "Nume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(158, 155);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.ReadOnly = true;
            this.txtPrenume.Size = new System.Drawing.Size(297, 20);
            this.txtPrenume.TabIndex = 23;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(158, 113);
            this.txtNume.Name = "txtNume";
            this.txtNume.ReadOnly = true;
            this.txtNume.Size = new System.Drawing.Size(297, 20);
            this.txtNume.TabIndex = 22;
            // 
            // comboBoxLiceu
            // 
            this.comboBoxLiceu.FormattingEnabled = true;
            this.comboBoxLiceu.Location = new System.Drawing.Point(158, 34);
            this.comboBoxLiceu.Name = "comboBoxLiceu";
            this.comboBoxLiceu.Size = new System.Drawing.Size(387, 21);
            this.comboBoxLiceu.TabIndex = 21;
            // 
            // txtMaterie
            // 
            this.txtMaterie.Location = new System.Drawing.Point(158, 197);
            this.txtMaterie.Name = "txtMaterie";
            this.txtMaterie.ReadOnly = true;
            this.txtMaterie.Size = new System.Drawing.Size(297, 20);
            this.txtMaterie.TabIndex = 32;
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 246);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonResetare
            // 
            this.buttonResetare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonResetare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetare.Location = new System.Drawing.Point(529, 143);
            this.buttonResetare.Name = "buttonResetare";
            this.buttonResetare.Size = new System.Drawing.Size(150, 30);
            this.buttonResetare.TabIndex = 34;
            this.buttonResetare.Text = "Resetare date initiale";
            this.buttonResetare.UseVisualStyleBackColor = false;
            this.buttonResetare.Click += new System.EventHandler(this.buttonResetare_Click);
            // 
            // buttonCautaProfesor
            // 
            this.buttonCautaProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonCautaProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCautaProfesor.Location = new System.Drawing.Point(529, 191);
            this.buttonCautaProfesor.Name = "buttonCautaProfesor";
            this.buttonCautaProfesor.Size = new System.Drawing.Size(150, 30);
            this.buttonCautaProfesor.TabIndex = 35;
            this.buttonCautaProfesor.Text = "Cauta Profesorul Dorit";
            this.buttonCautaProfesor.UseVisualStyleBackColor = false;
            this.buttonCautaProfesor.Click += new System.EventHandler(this.buttonCautaProfesor_Click);
            // 
            // labelInformatiiGrid
            // 
            this.labelInformatiiGrid.AutoSize = true;
            this.labelInformatiiGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformatiiGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(201)))));
            this.labelInformatiiGrid.Location = new System.Drawing.Point(9, 482);
            this.labelInformatiiGrid.Name = "labelInformatiiGrid";
            this.labelInformatiiGrid.Size = new System.Drawing.Size(386, 17);
            this.labelInformatiiGrid.TabIndex = 36;
            this.labelInformatiiGrid.Text = "Apasati dublu click pe elementul dorit din lista pentu selectie";
            // 
            // MeniuRepartizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(860, 506);
            this.Controls.Add(this.labelInformatiiGrid);
            this.Controls.Add(this.buttonCautaProfesor);
            this.Controls.Add(this.buttonResetare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMaterie);
            this.Controls.Add(this.lblMaterie);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.lblLiceu);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.comboBoxLiceu);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MeniuRepartizare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuRepartizare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeniuRepartizare_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterie;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.Label lblLiceu;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.ComboBox comboBoxLiceu;
        private System.Windows.Forms.TextBox txtMaterie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonResetare;
        private System.Windows.Forms.Button buttonCautaProfesor;
        private System.Windows.Forms.Label labelInformatiiGrid;
    }
}