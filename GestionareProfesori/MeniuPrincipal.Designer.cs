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
            this.panelAdauga = new System.Windows.Forms.Panel();
            this.buttonLiceu = new System.Windows.Forms.Button();
            this.buttonMaterie = new System.Windows.Forms.Button();
            this.buttonPersoana = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelPrincipalLeft.SuspendLayout();
            this.PanelPrincipalCenter.SuspendLayout();
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
            this.PanelPrincipalCenter.Controls.Add(this.panelAdauga);
            this.PanelPrincipalCenter.Location = new System.Drawing.Point(211, 70);
            this.PanelPrincipalCenter.Name = "PanelPrincipalCenter";
            this.PanelPrincipalCenter.Size = new System.Drawing.Size(590, 380);
            this.PanelPrincipalCenter.TabIndex = 2;
            // 
            // panelAdauga
            // 
            this.panelAdauga.Controls.Add(this.buttonLiceu);
            this.panelAdauga.Controls.Add(this.buttonMaterie);
            this.panelAdauga.Controls.Add(this.buttonPersoana);
            this.panelAdauga.Location = new System.Drawing.Point(176, 39);
            this.panelAdauga.Name = "panelAdauga";
            this.panelAdauga.Size = new System.Drawing.Size(252, 175);
            this.panelAdauga.TabIndex = 3;
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
            // MeniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelPrincipalCenter);
            this.Controls.Add(this.PanelPrincipalLeft);
            this.Controls.Add(this.PanelPrincipalUp);
            this.Name = "MeniuPrincipal";
            this.Text = "Meniu Principal";
            this.PanelPrincipalLeft.ResumeLayout(false);
            this.PanelPrincipalCenter.ResumeLayout(false);
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
    }
}

