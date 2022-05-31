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
        private const int ADOUA_COLOANA = 6;
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
            AfisareRepartizari();
            IncarcaLiceu();
        }

        #region METODE

        private void IncarcaLiceu()
        {
            try
            {
                //se elimina itemii deja adaugati
                comboBoxLiceu.Items.Clear();

                var licee = stocareLicee.GetLicee();
                if (licee != null && licee.Any())
                {
                    foreach (var item in licee)
                    {
                        comboBoxLiceu.Items.Add(new ComboItem(item.nume, (Int32)item.IdLiceu));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void AfisareRepartizari()
        {
            try
            {
                var repartizari = stocareRepartizari.GetDetaliiRepartizari();
                if (repartizari != null)
                {
                    dataGridView1.DataSource = repartizari.Tables[0];

                    dataGridView1.Columns["idProfesor"].Visible = false;
                    dataGridView1.Columns["numeProfesor"].HeaderText = "Nume";
                    dataGridView1.Columns["prenume"].HeaderText = "Prenume";
                    dataGridView1.Columns["numeLiceu"].HeaderText = "Liceu";
                    dataGridView1.Columns["idMaterie"].Visible = false;
                    dataGridView1.Columns["numeMaterie"].HeaderText = "Materie";
                    dataGridView1.Columns["idLiceu"].Visible = false;
                    dataGridView1.Columns["idOras"].Visible = false;
                    dataGridView1.Columns["numeOras"].HeaderText = "Oras";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private Repartizare getRepartizareDataGrid()
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
            MeniuRepartizare meniuRepartizare = new MeniuRepartizare(adOrModif,getRepartizareDataGrid());
            if (meniuRepartizare.ShowDialog() == DialogResult.OK)
                AfisareRepartizari();
            this.Show();
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNume.Text != String.Empty && txtPrenume.Text == String.Empty)
                {
                    var repartizari = stocareRepartizari.GetDetaliiCautaRepartizariNumeSauPrenume("nume", txtNume.Text);
                    if (repartizari != null)
                    {
                        dataGridView1.DataSource = repartizari.Tables[0];

                        dataGridView1.Columns["idProfesor"].Visible = false;
                        dataGridView1.Columns["numeProfesor"].HeaderText = "Nume";
                        dataGridView1.Columns["prenume"].HeaderText = "Prenume";
                        dataGridView1.Columns["idLiceu"].Visible = false;
                        dataGridView1.Columns["numeLiceu"].HeaderText = "Liceu";
                       

                    }
                }
                if (txtNume.Text == String.Empty && txtPrenume.Text != String.Empty)
                {
                    var repartizari = stocareRepartizari.GetDetaliiCautaRepartizariNumeSauPrenume("prenume", txtPrenume.Text);
                    if (repartizari != null)
                    {
                        dataGridView1.DataSource = repartizari.Tables[0];

                        dataGridView1.Columns["idProfesor"].Visible = false;
                        dataGridView1.Columns["numeProfesor"].HeaderText = "Nume";
                        dataGridView1.Columns["prenume"].HeaderText = "Prenume";
                        dataGridView1.Columns["idLiceu"].Visible = false;
                        dataGridView1.Columns["numeLiceu"].HeaderText = "Liceu";
                    }
                }
                if (txtNume.Text != String.Empty && txtPrenume.Text != String.Empty)
                {
                    var repartizari = stocareRepartizari.GetDetaliiCautaRepartizareNumeSiPrenume(txtNume.Text, txtPrenume.Text);
                    if (repartizari != null)
                    {
                        dataGridView1.DataSource = repartizari.Tables[0];

                        dataGridView1.Columns["idProfesor"].Visible = false;
                        dataGridView1.Columns["numeProfesor"].HeaderText = "Nume";
                        dataGridView1.Columns["prenume"].HeaderText = "Prenume";
                        dataGridView1.Columns["idLiceu"].Visible = false;
                        dataGridView1.Columns["numeLiceu"].HeaderText = "Liceu";
                    }
                }
                if (txtNume.Text == String.Empty && txtPrenume.Text == String.Empty && comboBoxLiceu.SelectedItem != null)
                {
                    var repartizari = stocareRepartizari.GetDetaliiCautaRepartizariLiceu(((ComboItem)comboBoxLiceu.SelectedItem).Value);
                    if (repartizari != null)
                    {
                        dataGridView1.DataSource = repartizari.Tables[0];

                        dataGridView1.Columns["idProfesor"].Visible = false;
                        dataGridView1.Columns["numeProfesor"].HeaderText = "Nume";
                        dataGridView1.Columns["prenume"].HeaderText = "Prenume";
                        dataGridView1.Columns["idLiceu"].Visible = false;
                        dataGridView1.Columns["numeLiceu"].HeaderText = "Liceu";
                    }
                }
                if(txtNume.Text == String.Empty && txtPrenume.Text == String.Empty && comboBoxLiceu.SelectedItem == null)
                {
                    MessageBox.Show("Selectati un liceu sau completati cu numele si prenumele persoanei cautate");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonResetare_Click(object sender, EventArgs e)
        {
            comboBoxLiceu.ResetText();
            AfisareRepartizari();
            IncarcaLiceu();
        }
    }
}
