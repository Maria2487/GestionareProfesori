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
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
       
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
                if(comboBoxOras.SelectedItem != null)
                {

                    var licee = stocareLicee.GetDetaliiLiceeDupaDenumireSiOras(((ComboItem)comboBoxOras.SelectedItem).Value, txtNume.Text);
                    if (licee != null)
                    {

                        dataGridView1.DataSource = licee.Tables[0];

                        dataGridView1.Columns["idLiceu"].Visible = false;
                        dataGridView1.Columns["numeLiceu"].HeaderText = "Liceu";
                        dataGridView1.Columns["idOras"].Visible = false;
                        dataGridView1.Columns["numeOras"].HeaderText = "Oras";
                    }
                }
                if (comboBoxOras.SelectedItem == null && txtNume.Text != String.Empty)
                {

                    var licee = stocareLicee.GetDetaliiLiceeDupaDenumire(txtNume.Text);
                    if (licee != null)
                    {

                        dataGridView1.DataSource = licee.Tables[0];

                        dataGridView1.Columns["idLiceu"].Visible = false;
                        dataGridView1.Columns["numeLiceu"].HeaderText = "Liceu";
                        dataGridView1.Columns["idOras"].Visible = false;
                        dataGridView1.Columns["numeOras"].HeaderText = "Oras";
                    }
                }
                if(comboBoxOras.SelectedItem == null && txtNume.Text == String.Empty)
                {
                    MessageBox.Show("Alegeti un oras sau completati cu demunirea liceului");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonResetare_Click(object sender, EventArgs e)
        {
            comboBoxOras.ResetText();
            IncarcaOrase();
            AfisareLicee();
            txtNume.Text = string.Empty;
            
        }

        private void buttonInapoiLaMeniu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
