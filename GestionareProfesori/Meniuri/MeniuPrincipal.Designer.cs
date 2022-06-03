namespace GestionareProfesori
{
    partial class MeniuPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelPrincipalUp = new System.Windows.Forms.Panel();
            this.labelTitluProiect = new System.Windows.Forms.Label();
            this.PanelPrincipalLeft = new System.Windows.Forms.Panel();
            this.buttonInformatii = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.PanelPrincipalCenter = new System.Windows.Forms.Panel();
            this.panelInformatii = new System.Windows.Forms.Panel();
            this.labelInformatii = new System.Windows.Forms.Label();
            this.buttonRaspuns = new System.Windows.Forms.Button();
            this.buttonResetare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxPanelInfo = new System.Windows.Forms.GroupBox();
            this.radioButtonNumarMaterii = new System.Windows.Forms.RadioButton();
            this.radioButtonNumarLiceeExistente = new System.Windows.Forms.RadioButton();
            this.radioButtonNumarProfesoriExistenti = new System.Windows.Forms.RadioButton();
            this.panelAdauga = new System.Windows.Forms.Panel();
            this.buttonRepartizare = new System.Windows.Forms.Button();
            this.buttonLiceu = new System.Windows.Forms.Button();
            this.buttonMaterie = new System.Windows.Forms.Button();
            this.buttonPersoana = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelInformatiiPrincipal = new System.Windows.Forms.Label();
            this.PanelPrincipalUp.SuspendLayout();
            this.PanelPrincipalLeft.SuspendLayout();
            this.PanelPrincipalCenter.SuspendLayout();
            this.panelInformatii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxPanelInfo.SuspendLayout();
            this.panelAdauga.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipalUp
            // 
            this.PanelPrincipalUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(126)))), ((int)(((byte)(105)))));
            this.PanelPrincipalUp.Controls.Add(this.labelTitluProiect);
            this.PanelPrincipalUp.Location = new System.Drawing.Point(-1, 1);
            this.PanelPrincipalUp.Name = "PanelPrincipalUp";
            this.PanelPrincipalUp.Size = new System.Drawing.Size(941, 70);
            this.PanelPrincipalUp.TabIndex = 0;
            // 
            // labelTitluProiect
            // 
            this.labelTitluProiect.AutoSize = true;
            this.labelTitluProiect.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitluProiect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(201)))));
            this.labelTitluProiect.Location = new System.Drawing.Point(351, 17);
            this.labelTitluProiect.Name = "labelTitluProiect";
            this.labelTitluProiect.Size = new System.Drawing.Size(367, 40);
            this.labelTitluProiect.TabIndex = 12;
            this.labelTitluProiect.Text = "Gestionare Profesori";
            // 
            // PanelPrincipalLeft
            // 
            this.PanelPrincipalLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(126)))), ((int)(((byte)(105)))));
            this.PanelPrincipalLeft.Controls.Add(this.buttonInformatii);
            this.PanelPrincipalLeft.Controls.Add(this.buttonModifica);
            this.PanelPrincipalLeft.Controls.Add(this.buttonAdauga);
            this.PanelPrincipalLeft.Location = new System.Drawing.Point(-1, 70);
            this.PanelPrincipalLeft.Name = "PanelPrincipalLeft";
            this.PanelPrincipalLeft.Size = new System.Drawing.Size(260, 500);
            this.PanelPrincipalLeft.TabIndex = 1;
            // 
            // buttonInformatii
            // 
            this.buttonInformatii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonInformatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInformatii.Location = new System.Drawing.Point(13, 363);
            this.buttonInformatii.Name = "buttonInformatii";
            this.buttonInformatii.Size = new System.Drawing.Size(230, 70);
            this.buttonInformatii.TabIndex = 2;
            this.buttonInformatii.Text = "Cautati informatii generale?";
            this.buttonInformatii.UseVisualStyleBackColor = false;
            this.buttonInformatii.Click += new System.EventHandler(this.buttonInformatii_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifica.Location = new System.Drawing.Point(13, 216);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(230, 70);
            this.buttonModifica.TabIndex = 1;
            this.buttonModifica.Text = "Dotiti sa cautati? Sau sa modificati?";
            this.buttonModifica.UseVisualStyleBackColor = false;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdauga.Location = new System.Drawing.Point(13, 63);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(230, 70);
            this.buttonAdauga.TabIndex = 0;
            this.buttonAdauga.Text = "Doriti sa adaugati?";
            this.buttonAdauga.UseVisualStyleBackColor = false;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // PanelPrincipalCenter
            // 
            this.PanelPrincipalCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
            this.PanelPrincipalCenter.Controls.Add(this.panelInformatii);
            this.PanelPrincipalCenter.Controls.Add(this.panelAdauga);
            this.PanelPrincipalCenter.Location = new System.Drawing.Point(254, 70);
            this.PanelPrincipalCenter.Name = "PanelPrincipalCenter";
            this.PanelPrincipalCenter.Size = new System.Drawing.Size(689, 500);
            this.PanelPrincipalCenter.TabIndex = 2;
            // 
            // panelInformatii
            // 
            this.panelInformatii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
            this.panelInformatii.Controls.Add(this.labelInformatiiPrincipal);
            this.panelInformatii.Controls.Add(this.labelInformatii);
            this.panelInformatii.Controls.Add(this.buttonRaspuns);
            this.panelInformatii.Controls.Add(this.buttonResetare);
            this.panelInformatii.Controls.Add(this.dataGridView1);
            this.panelInformatii.Controls.Add(this.groupBoxPanelInfo);
            this.panelInformatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInformatii.Location = new System.Drawing.Point(11, 15);
            this.panelInformatii.Name = "panelInformatii";
            this.panelInformatii.Size = new System.Drawing.Size(664, 470);
            this.panelInformatii.TabIndex = 4;
            // 
            // labelInformatii
            // 
            this.labelInformatii.AutoSize = true;
            this.labelInformatii.Location = new System.Drawing.Point(264, 324);
            this.labelInformatii.Name = "labelInformatii";
            this.labelInformatii.Size = new System.Drawing.Size(0, 17);
            this.labelInformatii.TabIndex = 23;
            // 
            // buttonRaspuns
            // 
            this.buttonRaspuns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonRaspuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaspuns.Location = new System.Drawing.Point(365, 154);
            this.buttonRaspuns.Name = "buttonRaspuns";
            this.buttonRaspuns.Size = new System.Drawing.Size(140, 30);
            this.buttonRaspuns.TabIndex = 22;
            this.buttonRaspuns.Text = "Raspuns";
            this.buttonRaspuns.UseVisualStyleBackColor = false;
            this.buttonRaspuns.Click += new System.EventHandler(this.buttonRaspuns_Click);
            // 
            // buttonResetare
            // 
            this.buttonResetare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonResetare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetare.Location = new System.Drawing.Point(511, 154);
            this.buttonResetare.Name = "buttonResetare";
            this.buttonResetare.Size = new System.Drawing.Size(140, 30);
            this.buttonResetare.TabIndex = 21;
            this.buttonResetare.Text = "Resetare";
            this.buttonResetare.UseVisualStyleBackColor = false;
            this.buttonResetare.Click += new System.EventHandler(this.buttonResetare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(126)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(13, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 266);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            // 
            // groupBoxPanelInfo
            // 
            this.groupBoxPanelInfo.Controls.Add(this.radioButtonNumarMaterii);
            this.groupBoxPanelInfo.Controls.Add(this.radioButtonNumarLiceeExistente);
            this.groupBoxPanelInfo.Controls.Add(this.radioButtonNumarProfesoriExistenti);
            this.groupBoxPanelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPanelInfo.Location = new System.Drawing.Point(13, 24);
            this.groupBoxPanelInfo.Name = "groupBoxPanelInfo";
            this.groupBoxPanelInfo.Size = new System.Drawing.Size(638, 124);
            this.groupBoxPanelInfo.TabIndex = 1;
            this.groupBoxPanelInfo.TabStop = false;
            this.groupBoxPanelInfo.Text = "Alegeti informatia dorita";
            // 
            // radioButtonNumarMaterii
            // 
            this.radioButtonNumarMaterii.AutoSize = true;
            this.radioButtonNumarMaterii.Location = new System.Drawing.Point(17, 92);
            this.radioButtonNumarMaterii.Name = "radioButtonNumarMaterii";
            this.radioButtonNumarMaterii.Size = new System.Drawing.Size(205, 21);
            this.radioButtonNumarMaterii.TabIndex = 2;
            this.radioButtonNumarMaterii.TabStop = true;
            this.radioButtonNumarMaterii.Text = "Numarul de materii existente";
            this.radioButtonNumarMaterii.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumarLiceeExistente
            // 
            this.radioButtonNumarLiceeExistente.AutoSize = true;
            this.radioButtonNumarLiceeExistente.Location = new System.Drawing.Point(17, 59);
            this.radioButtonNumarLiceeExistente.Name = "radioButtonNumarLiceeExistente";
            this.radioButtonNumarLiceeExistente.Size = new System.Drawing.Size(192, 21);
            this.radioButtonNumarLiceeExistente.TabIndex = 1;
            this.radioButtonNumarLiceeExistente.TabStop = true;
            this.radioButtonNumarLiceeExistente.Text = "Numarul de licee existente";
            this.radioButtonNumarLiceeExistente.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumarProfesoriExistenti
            // 
            this.radioButtonNumarProfesoriExistenti.AutoSize = true;
            this.radioButtonNumarProfesoriExistenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNumarProfesoriExistenti.Location = new System.Drawing.Point(17, 29);
            this.radioButtonNumarProfesoriExistenti.Name = "radioButtonNumarProfesoriExistenti";
            this.radioButtonNumarProfesoriExistenti.Size = new System.Drawing.Size(206, 21);
            this.radioButtonNumarProfesoriExistenti.TabIndex = 0;
            this.radioButtonNumarProfesoriExistenti.TabStop = true;
            this.radioButtonNumarProfesoriExistenti.Text = "Numarul de profesori existeti";
            this.radioButtonNumarProfesoriExistenti.UseVisualStyleBackColor = true;
            // 
            // panelAdauga
            // 
            this.panelAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
            this.panelAdauga.Controls.Add(this.buttonRepartizare);
            this.panelAdauga.Controls.Add(this.buttonLiceu);
            this.panelAdauga.Controls.Add(this.buttonMaterie);
            this.panelAdauga.Controls.Add(this.buttonPersoana);
            this.panelAdauga.Location = new System.Drawing.Point(11, 15);
            this.panelAdauga.Name = "panelAdauga";
            this.panelAdauga.Size = new System.Drawing.Size(664, 470);
            this.panelAdauga.TabIndex = 3;
            // 
            // buttonRepartizare
            // 
            this.buttonRepartizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonRepartizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRepartizare.Location = new System.Drawing.Point(223, 339);
            this.buttonRepartizare.Name = "buttonRepartizare";
            this.buttonRepartizare.Size = new System.Drawing.Size(230, 70);
            this.buttonRepartizare.TabIndex = 3;
            this.buttonRepartizare.Text = "Repartizare";
            this.buttonRepartizare.UseVisualStyleBackColor = false;
            this.buttonRepartizare.Click += new System.EventHandler(this.buttonRepartizare_Click);
            // 
            // buttonLiceu
            // 
            this.buttonLiceu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonLiceu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLiceu.Location = new System.Drawing.Point(223, 238);
            this.buttonLiceu.Name = "buttonLiceu";
            this.buttonLiceu.Size = new System.Drawing.Size(230, 70);
            this.buttonLiceu.TabIndex = 2;
            this.buttonLiceu.Text = "Liceu";
            this.buttonLiceu.UseVisualStyleBackColor = false;
            this.buttonLiceu.Click += new System.EventHandler(this.buttonLiceu_Click);
            // 
            // buttonMaterie
            // 
            this.buttonMaterie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonMaterie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaterie.Location = new System.Drawing.Point(223, 138);
            this.buttonMaterie.Name = "buttonMaterie";
            this.buttonMaterie.Size = new System.Drawing.Size(230, 70);
            this.buttonMaterie.TabIndex = 1;
            this.buttonMaterie.Text = "Materie";
            this.buttonMaterie.UseVisualStyleBackColor = false;
            this.buttonMaterie.Click += new System.EventHandler(this.buttonMaterie_Click);
            // 
            // buttonPersoana
            // 
            this.buttonPersoana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonPersoana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersoana.Location = new System.Drawing.Point(223, 41);
            this.buttonPersoana.Name = "buttonPersoana";
            this.buttonPersoana.Size = new System.Drawing.Size(230, 70);
            this.buttonPersoana.TabIndex = 0;
            this.buttonPersoana.Text = "Profesor";
            this.buttonPersoana.UseVisualStyleBackColor = false;
            this.buttonPersoana.Click += new System.EventHandler(this.buttonPersoana_Click);
            // 
            // labelInformatiiPrincipal
            // 
            this.labelInformatiiPrincipal.AutoSize = true;
            this.labelInformatiiPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(201)))));
            this.labelInformatiiPrincipal.Location = new System.Drawing.Point(17, 170);
            this.labelInformatiiPrincipal.Name = "labelInformatiiPrincipal";
            this.labelInformatiiPrincipal.Size = new System.Drawing.Size(0, 17);
            this.labelInformatiiPrincipal.TabIndex = 24;
            // 
            // MeniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 567);
            this.Controls.Add(this.PanelPrincipalCenter);
            this.Controls.Add(this.PanelPrincipalLeft);
            this.Controls.Add(this.PanelPrincipalUp);
            this.Name = "MeniuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu Principal";
            this.PanelPrincipalUp.ResumeLayout(false);
            this.PanelPrincipalUp.PerformLayout();
            this.PanelPrincipalLeft.ResumeLayout(false);
            this.PanelPrincipalCenter.ResumeLayout(false);
            this.panelInformatii.ResumeLayout(false);
            this.panelInformatii.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxPanelInfo.ResumeLayout(false);
            this.groupBoxPanelInfo.PerformLayout();
            this.panelAdauga.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipalUp;
        private System.Windows.Forms.Panel PanelPrincipalLeft;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Panel PanelPrincipalCenter;
        private System.Windows.Forms.Panel panelAdauga;
        private System.Windows.Forms.Button buttonLiceu;
        private System.Windows.Forms.Button buttonMaterie;
        private System.Windows.Forms.Button buttonPersoana;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonInformatii;
        private System.Windows.Forms.Button buttonRepartizare;
        private System.Windows.Forms.Panel panelInformatii;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonResetare;
        private System.Windows.Forms.GroupBox groupBoxPanelInfo;
        private System.Windows.Forms.RadioButton radioButtonNumarMaterii;
        private System.Windows.Forms.RadioButton radioButtonNumarLiceeExistente;
        private System.Windows.Forms.RadioButton radioButtonNumarProfesoriExistenti;
        private System.Windows.Forms.Button buttonRaspuns;
        private System.Windows.Forms.Label labelInformatii;
        private System.Windows.Forms.Label labelTitluProiect;
        private System.Windows.Forms.Label labelInformatiiPrincipal;
    }
}

