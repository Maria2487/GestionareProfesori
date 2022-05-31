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

        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));

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
                this.Hide();
                MeniuRepartizare meniuRepartizare = new MeniuRepartizare(true, null, getIdDataGrid());
                
            }
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            try
            {
                var profesori = stocareProfesori.GetProfesori();
                if (profesori != null && profesori.Any())
                {
                    if (txtNume.Text != String.Empty && txtPrenume.Text != String.Empty)
                    {
                        dataGridView1.DataSource = profesori.Where(p => p.nume.ToUpper() == txtNume.Text.ToUpper() && p.prenume.ToUpper() == txtPrenume.Text.ToUpper())
                                                        .Select(p => new { p.idProfesor, p.nume, p.prenume, p.idMaterie }).ToList();

                        dataGridView1.Columns["idProfesor"].Visible = false;
                        dataGridView1.Columns["nume"].HeaderText = "Nume";
                        dataGridView1.Columns["prenume"].HeaderText = "Prenume";
                        dataGridView1.Columns["idMaterie"].HeaderText = "Materie";
                    }

                    if (txtNume.Text != String.Empty)
                    {
                        dataGridView1.DataSource = profesori.Where(p => p.nume.ToUpper() == txtNume.Text.ToUpper())
                                                        .Select(p => new { p.idProfesor, p.nume, p.prenume, p.idMaterie }).ToList();

                        dataGridView1.Columns["idProfesor"].Visible = false;
                        dataGridView1.Columns["nume"].HeaderText = "Nume";
                        dataGridView1.Columns["prenume"].HeaderText = "Prenume";
                        dataGridView1.Columns["idMaterie"].HeaderText = "Materie";
                    }

                    if (txtPrenume.Text != String.Empty)
                    {
                        dataGridView1.DataSource = profesori.Where(p => p.prenume.ToUpper() == txtPrenume.Text.ToUpper())
                                                        .Select(p => new { p.idProfesor, p.nume, p.prenume, p.idMaterie }).ToList();

                        dataGridView1.Columns["idProfesor"].Visible = false;
                        dataGridView1.Columns["nume"].HeaderText = "Nume";
                        dataGridView1.Columns["prenume"].HeaderText = "Prenume";
                        dataGridView1.Columns["idMaterie"].HeaderText = "Materie";
                    }

                    if(txtNume.Text == String.Empty && txtPrenume.Text == String.Empty)
                    {
                        MessageBox.Show("Introduceti numele/prenumele profesorului cautat");
                    }

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
    }
}
