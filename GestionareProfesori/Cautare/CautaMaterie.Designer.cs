namespace GestionareProfesori
{
    partial class CautaMaterie
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.buttonResetare = new System.Windows.Forms.Button();
            this.buttonInapoiLaMeniu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(151, 97);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(321, 20);
            this.txtNume.TabIndex = 9;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(12, 88);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(118, 29);
            this.lblNume.TabIndex = 8;
            this.lblNume.Text = "Denumire";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 269);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonCauta
            // 
            this.buttonCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCauta.Location = new System.Drawing.Point(515, 91);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(140, 30);
            this.buttonCauta.TabIndex = 11;
            this.buttonCauta.Text = "Cauta";
            this.buttonCauta.UseVisualStyleBackColor = false;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // buttonResetare
            // 
            this.buttonResetare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonResetare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetare.Location = new System.Drawing.Point(515, 153);
            this.buttonResetare.Name = "buttonResetare";
            this.buttonResetare.Size = new System.Drawing.Size(140, 30);
            this.buttonResetare.TabIndex = 12;
            this.buttonResetare.Text = "Resetare";
            this.buttonResetare.UseVisualStyleBackColor = false;
            this.buttonResetare.Click += new System.EventHandler(this.buttonResetare_Click);
            // 
            // buttonInapoiLaMeniu
            // 
            this.buttonInapoiLaMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(142)))), ((int)(((byte)(136)))));
            this.buttonInapoiLaMeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInapoiLaMeniu.Location = new System.Drawing.Point(515, 12);
            this.buttonInapoiLaMeniu.Name = "buttonInapoiLaMeniu";
            this.buttonInapoiLaMeniu.Size = new System.Drawing.Size(140, 30);
            this.buttonInapoiLaMeniu.TabIndex = 13;
            this.buttonInapoiLaMeniu.Text = "Pagina Principala";
            this.buttonInapoiLaMeniu.UseVisualStyleBackColor = false;
            this.buttonInapoiLaMeniu.Click += new System.EventHandler(this.buttonInapoiLaMeniu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(14, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Apasati dublu click pe elementul dorit din lista pentu a continua spre meniul de " +
    "modificare";
            // 
            // CautaMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(667, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInapoiLaMeniu);
            this.Controls.Add(this.buttonResetare);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Name = "CautaMaterie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CautaMaterie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.Button buttonResetare;
        private System.Windows.Forms.Button buttonInapoiLaMeniu;
        private System.Windows.Forms.Label label1;
    }
}