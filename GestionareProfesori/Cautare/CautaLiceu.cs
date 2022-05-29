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
    public partial class CautaLiceu : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        private const bool adOrModif = false;

        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));

        public CautaLiceu()
        {
            InitializeComponent();
            AfisareLicee();
        }


        #region FUNCTII
        private void AfisareLicee()
        {
            try
            {
                var licee = stocareLicee.GetLicee();
                if (licee != null && licee.Any())
                {
                    dataGridView1.DataSource = licee.Select(l => new { l.IdLiceu, l.nume, l.IdOras }).ToList();

                    dataGridView1.Columns["idLiceu"].Visible = false;
                    dataGridView1.Columns["nume"].HeaderText = "Liceu";
                    dataGridView1.Columns["idOras"].HeaderText = "Oras";

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

                int idLiceu = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);
                return idLiceu;
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
            MeniuLiceu meniuLiceu = new MeniuLiceu(adOrModif,getIdDataGrid());
            meniuLiceu.ShowDialog();
            this.Show();
        }
    }
}
