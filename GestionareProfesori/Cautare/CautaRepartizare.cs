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
    public partial class CautaRepartizare : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const int ADOUA_COLOANA = 1;
        private const bool SUCCES = true;
        private const bool adOrModif = false;

        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));

        public CautaRepartizare()
        {
            InitializeComponent();
        }

        #region METODE
        private void AfisareRepartizari()
        {
            try
            {
                var repartizari = stocareRepartizari.GetRepartizari();
                if (repartizari != null && repartizari.Any())
                {
                    dataGridView1.DataSource = repartizari.Select(r => new { r.idProfesor, r.idLiceu }).ToList();

                    dataGridView1.Columns["idProfesor"].Visible = false;
                    dataGridView1.Columns["idLiceu"].HeaderText = "Liceu";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private Repartizare getIdDataGrid()
        {
            try
            {
                var currentCell = dataGridView1.CurrentCell;
                if (currentCell == null)
                {
                    MessageBox.Show("Selectati  din tabel");
                    return null;
                }

                Repartizare repartizare = new Repartizare(Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value), Convert.ToInt32(dataGridView1[ADOUA_COLOANA, currentCell.RowIndex].Value));
                return repartizare;
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
            
            //MeniuRepartizare meniuRepartizare = new MeniuRepartizare(adOrModif,getIdDataGrid());
            //meniuRepartizare.ShowDialog();
            this.Show();
        }

        
    }
}
