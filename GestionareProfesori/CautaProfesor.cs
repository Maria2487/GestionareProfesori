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

        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));

        public CautaProfesor()
        {
            InitializeComponent();
            AfisareProfesori();
        }


        #region FUNCTII
        private void AfisareProfesori()
        {
            try
            {
                var profesori = stocareProfesori.GetProfesori();
                if (profesori != null && profesori.Any())
                {
                    dataGridView1.DataSource = profesori.Select(p => new { p.idProfesor, p.nume, p.prenume, p.idMaterie }).ToList();

                    dataGridView1.Columns["idProfesor"].Visible = false;
                    dataGridView1.Columns["nume"].HeaderText = "Nume";
                    dataGridView1.Columns["prenume"].HeaderText = "Prenume";
                    dataGridView1.Columns["idMaterie"].HeaderText = "Materie";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            MeniuProfesor meniuPersoana = new MeniuProfesor(adOrModif);
            meniuPersoana.ShowDialog();
            this.Show();
        }

        private int getIdDataGrid()
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati un profesor din tabel");
                    return 0;
                }

                int idStudent = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);
                return idStudent;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
