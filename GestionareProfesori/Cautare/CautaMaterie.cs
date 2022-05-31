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
    public partial class CautaMaterie : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        private const bool adOrModif = false;

        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));

        public CautaMaterie()
        {
            InitializeComponent();
            AfisareMaterii();
        }


        #region FUNCTII
        private void AfisareMaterii()
        {
            try
            {
                var materie = stocareMaterii.GetMaterii();
                if (materie != null && materie.Any())
                {
                    dataGridView1.DataSource = materie.Select(m => new { m.idMaterie, m.nume }).ToList();

                    dataGridView1.Columns["idMaterie"].Visible = false;
                    dataGridView1.Columns["nume"].HeaderText = "Materie";

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
                    MessageBox.Show("Selectati un profesor din tabel");
                    return 0;
                }

                int idMaterie = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);
                return idMaterie;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            MeniuMaterie meniuMaterie = new MeniuMaterie(adOrModif,getIdDataGrid());
            if (meniuMaterie.ShowDialog() == DialogResult.OK)
                AfisareMaterii();
            this.Show();
        }

       

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            try
            {
                var materie = stocareMaterii.GetMaterii();
                if (materie != null && materie.Any())
                {
                    dataGridView1.DataSource = materie.Where(d => d.nume.ToUpper() == txtNume.Text.ToUpper())
                                                      .Select(m => new { m.idMaterie, m.nume }).ToList();

                    dataGridView1.Columns["idMaterie"].Visible = false;
                    dataGridView1.Columns["nume"].HeaderText = "Materie";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void buttonResetare_Click(object sender, EventArgs e)
        {
            AfisareMaterii();
            txtNume.Text = String.Empty;
        }
    }
}
