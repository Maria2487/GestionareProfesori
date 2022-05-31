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
            IncarcaOrase();
            AfisareLicee();
        }


        #region FUNCTII

        private void IncarcaOrase()
        {
            try
            {
                //se elimina itemii deja adaugati
                comboBoxOras.Items.Clear();

                var orase = stocareOrase.GetOrase();
                if (orase != null && orase.Any())
                {
                    foreach (var item in orase)
                    {
                        comboBoxOras.Items.Add(new ComboItem(item.nume, (Int32)item.idOras));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void AfisareLicee()
        {
            try
            {
                var licee = stocareLicee.GetDetaliiLicee();
                if (licee != null)
                {
                    
                    dataGridView1.DataSource = licee.Tables[0];
                    
                    dataGridView1.Columns["idLiceu"].Visible = false;
                    dataGridView1.Columns["numeLiceu"].HeaderText = "Liceu";
                    dataGridView1.Columns["idOras"].Visible = false;
                    dataGridView1.Columns["numeOras"].HeaderText = "Oras";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AfisareLiceeDupaCauta(DataGridView dataGridView, List<Liceu> licee, int idOras = -1)
        {
            try
            {
                if (licee != null && licee.Any() && idOras != -1)
                {
                    dataGridView.DataSource = licee.Where(o => o.IdOras == idOras)
                                                      .Select(l => new { l.IdLiceu, l.nume, l.IdOras })
                                                      .ToList();

                    dataGridView1.Columns["idLiceu"].Visible = false;
                    dataGridView1.Columns["nume"].HeaderText = "Liceu";
                }
                if (licee != null && licee.Any() && idOras == -1)
                {
                    dataGridView.DataSource = licee.Select(l => new { l.IdLiceu, l.nume, l.IdOras })
                                                   .ToList();

                    dataGridView1.Columns["idLiceu"].Visible = false;
                    dataGridView1.Columns["nume"].HeaderText = "Liceu";
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
            if (meniuLiceu.ShowDialog() == DialogResult.OK)
                AfisareLicee();
            this.Show();
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            try
            {
                List<CautaElement> searchElements = new List<CautaElement>();

                // Aici se gaseste si denumiera facultatii dar si specializarea programului de studiu
                if (txtNume.Text != String.Empty)
                    searchElements.Add(new CautaElement("nume", txtNume.Text));

                List<Liceu> licee;
                if (comboBoxOras.SelectedItem != null)
                    searchElements.Add(new CautaElement("idOras", ((ComboItem)comboBoxOras.SelectedItem).Value.ToString()));


                if (searchElements.Count > 1)
                {
                    licee = stocareLicee.GetProgrameStudii(searchElements);
                }
                else
                    licee = stocareLicee.GetLicee();

                if (licee.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Niciun rezultat gasit");
                }
                else
                    AfisareLiceeDupaCauta(dataGridView1, licee, ((ComboItem)comboBoxOras.SelectedItem).Value);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void buttonResetare_Click(object sender, EventArgs e)
        {
            comboBoxOras.ResetText();
            IncarcaOrase();
            AfisareLicee(); 
            
        }
    }
}
