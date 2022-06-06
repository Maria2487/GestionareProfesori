using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace GestionareProfesori
{
    public partial class CautaProfesor : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        private const bool adOrModif = false;
        private  bool dinRepartizare = false;
        public Profesor ProfesorGasit{ get; set; }

        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        
        public CautaProfesor(bool mRepartizare = false)
        {
            InitializeComponent();
            AfisareProfesori();
            this.dinRepartizare = mRepartizare;
        }


        #region FUNCTII

        private void AfisareProfesori()
        {
            try
            {
                var profesori = stocareProfesori.GetDetaliiProfesori();
                if (profesori != null)
                {

                    dataGridView1.DataSource = profesori.Tables[0];

                    dataGridView1.Columns["idProfesor"].Visible = false;
                    dataGridView1.Columns["numeProfesor"].HeaderText = "Nume";
                    dataGridView1.Columns["prenume"].HeaderText = "Prenume";
                    dataGridView1.Columns["idMaterie"].Visible = false;
                    dataGridView1.Columns["numeMaterie"].HeaderText = "Materie";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private int getIdDataGrid()
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati un liceu din tabel");
                    return 0;
                }

                int idProfesor = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);
                return idProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dinRepartizare == false)
            {
                this.Hide();
                MeniuProfesor meniuPersoana = new MeniuProfesor(adOrModif, getIdDataGrid());
                if (meniuPersoana.ShowDialog() == DialogResult.OK)
                    AfisareProfesori();
                this.Show();
            }

            if (dinRepartizare == true)
            {
                ProfesorGasit = stocareProfesori.GetProfesor(getIdDataGrid());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            try
            {
                var profesori = stocareProfesori.GetDetaliiProfesori(txtNume.Text,txtPrenume.Text);
                if (profesori != null)
                {

                    dataGridView1.DataSource = profesori.Tables[0];

                    dataGridView1.Columns["idProfesor"].Visible = false;
                    dataGridView1.Columns["numeProfesor"].HeaderText = "Nume";
                    dataGridView1.Columns["prenume"].HeaderText = "Prenume";
                    dataGridView1.Columns["idMaterie"].Visible = false;
                    dataGridView1.Columns["numeMaterie"].HeaderText = "Materie";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonResetare_Click(object sender, EventArgs e)
        {
            AfisareProfesori();
            txtNume.Text = String.Empty;
            txtPrenume.Text = String.Empty;
        }

        private void buttonInapoiLaMeniu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
