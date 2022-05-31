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
            this.PanelPrincipalUp = new System.Windows.Forms.Panel();
            this.PanelPrincipalLeft = new System.Windows.Forms.Panel();
            this.buttonInformatii = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.PanelPrincipalCenter = new System.Windows.Forms.Panel();
            this.panelInformatii = new System.Windows.Forms.Panel();
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
            this.labelInformatii = new System.Windows.Forms.Label();
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
            this.PanelPrincipalUp.Location = new System.Drawing.Point(-1, 1);
            this.PanelPrincipalUp.Name = "PanelPrincipalUp";
            this.PanelPrincipalUp.Size = new System.Drawing.Size(802, 70);
            this.PanelPrincipalUp.TabIndex = 0;
            // 
            // PanelPrincipalLeft
            // 
            this.PanelPrincipalLeft.Controls.Add(this.buttonInformatii);
            this.PanelPrincipalLeft.Controls.Add(this.buttonModifica);
            this.PanelPrincipalLeft.Controls.Add(this.buttonAdauga);
            this.PanelPrincipalLeft.Location = new System.Drawing.Point(-1, 70);
            this.PanelPrincipalLeft.Name = "PanelPrincipalLeft";
            this.PanelPrincipalLeft.Size = new System.Drawing.Size(213, 380);
            this.PanelPrincipalLeft.TabIndex = 1;
            // 
            // buttonInformatii
            // 
            this.buttonInformatii.Location = new System.Drawing.Point(13, 174);
            this.buttonInformatii.Name = "buttonInformatii";
            this.buttonInformatii.Size = new System.Drawing.Size(183, 53);
            this.buttonInformatii.TabIndex = 2;
            this.buttonInformatii.Text = "Cautati informatii?";
            this.buttonInformatii.UseVisualStyleBackColor = true;
            this.buttonInformatii.Click += new System.EventHandler(this.buttonInformatii_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Location = new System.Drawing.Point(13, 247);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(183, 56);
            this.buttonModifica.TabIndex = 1;
            this.buttonModifica.Text = "Doriti sa modificati?";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(13, 98);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(183, 56);
            this.buttonAdauga.TabIndex = 0;
            this.buttonAdauga.Text = "Doriti sa adaugati?";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // PanelPrincipalCenter
            // 
            this.PanelPrincipalCenter.Controls.Add(this.panelInformatii);
            this.PanelPrincipalCenter.Controls.Add(this.panelAdauga);
            this.PanelPrincipalCenter.Location = new System.Drawing.Point(211, 70);
            this.PanelPrincipalCenter.Name = "PanelPrincipalCenter";
            this.PanelPrincipalCenter.Size = new System.Drawing.Size(590, 380);
            this.PanelPrincipalCenter.TabIndex = 2;
            // 
            // panelInformatii
            // 
            this.panelInformatii.Controls.Add(this.labelInformatii);
            this.panelInformatii.Controls.Add(this.buttonRaspuns);
            this.panelInformatii.Controls.Add(this.buttonResetare);
            this.panelInformatii.Controls.Add(this.dataGridView1);
            this.panelInformatii.Controls.Add(this.groupBoxPanelInfo);
            this.panelInformatii.Location = new System.Drawing.Point(21, 19);
            this.panelInformatii.Name = "panelInformatii";
            this.panelInformatii.Size = new System.Drawing.Size(556, 349);
            this.panelInformatii.TabIndex = 4;
            // 
            // buttonRaspuns
            // 
            this.buttonRaspuns.Location = new System.Drawing.Point(354, 141);
            this.buttonRaspuns.Name = "buttonRaspuns";
            this.buttonRaspuns.Size = new System.Drawing.Size(75, 23);
            this.buttonRaspuns.TabIndex = 22;
            this.buttonRaspuns.Text = "Raspuns";
            this.buttonRaspuns.UseVisualStyleBackColor = true;
            this.buttonRaspuns.Click += new System.EventHandler(this.buttonRaspuns_Click);
            // 
            // buttonResetare
            // 
            this.buttonResetare.Location = new System.Drawing.Point(449, 141);
            this.buttonResetare.Name = "buttonResetare";
            this.buttonResetare.Size = new System.Drawing.Size(75, 23);
            this.buttonResetare.TabIndex = 21;
            this.buttonResetare.Text = "Resetare";
            this.buttonResetare.UseVisualStyleBackColor = true;
            this.buttonResetare.Click += new System.EventHandler(this.buttonResetare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 147);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBoxPanelInfo
            // 
            this.groupBoxPanelInfo.Controls.Add(this.radioButtonNumarMaterii);
            this.groupBoxPanelInfo.Controls.Add(this.radioButtonNumarLiceeExistente);
            this.groupBoxPanelInfo.Controls.Add(this.radioButtonNumarProfesoriExistenti);
            this.groupBoxPanelInfo.Location = new System.Drawing.Point(24, 20);
            this.groupBoxPanelInfo.Name = "groupBoxPanelInfo";
            this.groupBoxPanelInfo.Size = new System.Drawing.Size(500, 115);
            this.groupBoxPanelInfo.TabIndex = 1;
            this.groupBoxPanelInfo.TabStop = false;
            this.groupBoxPanelInfo.Text = "Alegeti informatia dorita";
            // 
            // radioButtonNumarMaterii
            // 
            this.radioButtonNumarMaterii.AutoSize = true;
            this.radioButtonNumarMaterii.Location = new System.Drawing.Point(17, 92);
            this.radioButtonNumarMaterii.Name = "radioButtonNumarMaterii";
            this.radioButtonNumarMaterii.Size = new System.Drawing.Size(157, 17);
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
            this.radioButtonNumarLiceeExistente.Size = new System.Drawing.Size(149, 17);
            this.radioButtonNumarLiceeExistente.TabIndex = 1;
            this.radioButtonNumarLiceeExistente.TabStop = true;
            this.radioButtonNumarLiceeExistente.Text = "Numarul de licee existente";
            this.radioButtonNumarLiceeExistente.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumarProfesoriExistenti
            // 
            this.radioButtonNumarProfesoriExistenti.AutoSize = true;
            this.radioButtonNumarProfesoriExistenti.Location = new System.Drawing.Point(17, 29);
            this.radioButtonNumarProfesoriExistenti.Name = "radioButtonNumarProfesoriExistenti";
            this.radioButtonNumarProfesoriExistenti.Size = new System.Drawing.Size(157, 17);
            this.radioButtonNumarProfesoriExistenti.TabIndex = 0;
            this.radioButtonNumarProfesoriExistenti.TabStop = true;
            this.radioButtonNumarProfesoriExistenti.Text = "Numarul de profesori existeti";
            this.radioButtonNumarProfesoriExistenti.UseVisualStyleBackColor = true;
            // 
            // panelAdauga
            // 
            this.panelAdauga.Controls.Add(this.buttonRepartizare);
            this.panelAdauga.Controls.Add(this.buttonLiceu);
            this.panelAdauga.Controls.Add(this.buttonMaterie);
            this.panelAdauga.Controls.Add(this.buttonPersoana);
            this.panelAdauga.Location = new System.Drawing.Point(176, 39);
            this.panelAdauga.Name = "panelAdauga";
            this.panelAdauga.Size = new System.Drawing.Size(252, 220);
            this.panelAdauga.TabIndex = 3;
            // 
            // buttonRepartizare
            // 
            this.buttonRepartizare.Location = new System.Drawing.Point(89, 165);
            this.buttonRepartizare.Name = "buttonRepartizare";
            this.buttonRepartizare.Size = new System.Drawing.Size(75, 23);
            this.buttonRepartizare.TabIndex = 3;
            this.buttonRepartizare.Text = "Repartizare?";
            this.buttonRepartizare.UseVisualStyleBackColor = true;
            this.buttonRepartizare.Click += new System.EventHandler(this.buttonRepartizare_Click);
            // 
            // buttonLiceu
            // 
            this.buttonLiceu.Location = new System.Drawing.Point(89, 121);
            this.buttonLiceu.Name = "buttonLiceu";
            this.buttonLiceu.Size = new System.Drawing.Size(75, 23);
            this.buttonLiceu.TabIndex = 2;
            this.buttonLiceu.Text = "Liceu?";
            this.buttonLiceu.UseVisualStyleBackColor = true;
            this.buttonLiceu.Click += new System.EventHandler(this.buttonLiceu_Click);
            // 
            // buttonMaterie
            // 
            this.buttonMaterie.Location = new System.Drawing.Point(89, 76);
            this.buttonMaterie.Name = "buttonMaterie";
            this.buttonMaterie.Size = new System.Drawing.Size(75, 23);
            this.buttonMaterie.TabIndex = 1;
            this.buttonMaterie.Text = "Materie?";
            this.buttonMaterie.UseVisualStyleBackColor = true;
            this.buttonMaterie.Click += new System.EventHandler(this.buttonMaterie_Click);
            // 
            // buttonPersoana
            // 
            this.buttonPersoana.Location = new System.Drawing.Point(89, 34);
            this.buttonPersoana.Name = "buttonPersoana";
            this.buttonPersoana.Size = new System.Drawing.Size(75, 23);
            this.buttonPersoana.TabIndex = 0;
            this.buttonPersoana.Text = "Profesor?";
            this.buttonPersoana.UseVisualStyleBackColor = true;
            this.buttonPersoana.Click += new System.EventHandler(this.buttonPersoana_Click);
            // 
            // labelInformatii
            // 
            this.labelInformatii.AutoSize = true;
            this.labelInformatii.Location = new System.Drawing.Point(264, 324);
            this.labelInformatii.Name = "labelInformatii";
            this.labelInformatii.Size = new System.Drawing.Size(0, 13);
            this.labelInformatii.TabIndex = 23;
            // 
            // MeniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelPrincipalCenter);
            this.Controls.Add(this.PanelPrincipalLeft);
            this.Controls.Add(this.PanelPrincipalUp);
            this.Name = "MeniuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu Principal";
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
    }
}

