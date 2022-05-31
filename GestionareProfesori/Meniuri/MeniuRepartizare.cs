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
using Oracle.DataAccess.Client;

namespace GestionareProfesori
{
    public partial class MeniuRepartizare : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const int ADOUA_COLOANA = 1;
        private const bool SUCCES = true;
        private bool esteAdauga;
        private bool esteProfesorCautat = false;
        public bool itemAdaugat = false;
        public Repartizare repartizareSelectata;
        public int profesorDorit;


        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));

        public MeniuRepartizare(bool esteAdauga, Repartizare repartizare = null, int IdProfesorSelectat = -1)
        {
            InitializeComponent();
            if (esteAdauga)
            {
                buttonSterge.Visible = false;
                buttonResetare.Visible = false;
                buttonCautaProfesor.Visible = true;
            }
            else
            {
                buttonSterge.Visible = true;
                buttonResetare.Visible = true;
                buttonCautaProfesor.Visible = false;
            }

            if (stocareRepartizari == null)
            {
                MessageBox.Show("Eroare la initializare");
            }

            this.esteAdauga = esteAdauga;
            this.repartizareSelectata = repartizare;
            this.profesorDorit = IdProfesorSelectat;

            IncarcaMeniuRepartizare();
        }

        #region METODE
        private void FormAnterior()
        {
            this.Close();
        }
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

        private void IncarcaMeniuRepartizare()
        {
            if (esteAdauga)
            {
                try
                {
                    //se elimina itemii deja adaugati
                    comboBoxLiceu.Items.Clear();

                    var liceu = stocareLicee.GetLicee();
                    if (liceu != null && liceu.Any())
                    {
                        foreach (var item in liceu)
                        {
                            comboBoxLiceu.Items.Add(new ComboItem(item.nume, (Int32)item.IdLiceu));
                        }
                    }

                    AfisareProfesori();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                try
                {
                    Profesor p = stocareProfesori.GetProfesor(repartizareSelectata.idProfesor);
                    txtNume.Text = p.nume;
                    txtPrenume.Text = p.prenume;
                    Materie m = stocareMaterii.GetMaterie(p.idMaterie);
                    txtMaterie.Text = m.nume;
                    //se elimina itemii deja adaugati
                    comboBoxLiceu.Items.Clear();

                    var licee = stocareLicee.GetLicee();
                    if (licee != null && licee.Any())
                    {
                        foreach (var item in licee)
                        {
                            comboBoxLiceu.Items.Add(new ComboItem(item.nume, (Int32)item.IdLiceu));
                        }

                        Liceu liceu = null;
                        const int PRIMUL_TABEL = 0;
                        const int PRIMA_LINIE = 0;
                        var l = SqlDBHelper.ExecuteDataSet("select L.idLiceu, L.nume, L.IdOras from Repartizari_CotofrecM31 R, Liceu_CotofrecM31 L WHERE R.idLiceu = L.idLiceu AND R.idLiceu = :repartizareSelectata", CommandType.Text,
                                new OracleParameter(":repartizareSelectata", OracleDbType.Int32, repartizareSelectata.idLiceu, ParameterDirection.Input));
                        if (l.Tables[PRIMUL_TABEL].Rows.Count > 0)
                        {
                            DataRow linieDB = l.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                            liceu = new Liceu(linieDB);
                        }

                        comboBoxLiceu.SelectedIndex = comboBoxLiceu.FindString(liceu.nume);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
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

                int idProfesor = Convert.ToInt32(dataGridView1[PRIMA_COLOANA, currentCell.RowIndex].Value);
                return idProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion


        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if (repartizareSelectata == null) return;

            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa elimini REPARTIZAREA?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;

            var resultPrograme = stocareRepartizari.DeleteRepartizare(repartizareSelectata);

            if (resultPrograme == true)
            {
                MessageBox.Show($"Repartizarea a fost stearsa cu succes");
                itemAdaugat = true;
            }
            FormAnterior();
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            if (esteAdauga)
            {
                try
                {
                    bool rezultat = false;
                    if (esteProfesorCautat == false)
                    {
                        rezultat = stocareRepartizari.AddRepartizare(new Repartizare(profesorDorit, ((ComboItem)comboBoxLiceu.SelectedItem).Value));
                    }
                    if(esteProfesorCautat == true)
                    {
                        rezultat = stocareRepartizari.AddRepartizare(new Repartizare(profesorDorit, ((ComboItem)comboBoxLiceu.SelectedItem).Value));
                    }
                    
                    if (rezultat == SUCCES)
                    {
                        MessageBox.Show("Repartizare adaugata");
                    }
                    else
                    {
                        MessageBox.Show("Eroare la adaugarea repartizarii");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exceptie" + ex.Message);
                }
            }
            else
            {
                try
                {
                    var repartizare = new Repartizare(repartizareSelectata.idProfesor,
                                                     ((ComboItem)comboBoxLiceu.SelectedItem).Value);

                    var rezultat = stocareRepartizari.UpdateRepartizare(repartizare, repartizareSelectata.idLiceu);
                    if (rezultat == SUCCES)
                    {
                        MessageBox.Show("Repartizare actualizata");
                        itemAdaugat = true;
                    }
                    else
                    {
                        MessageBox.Show("Eroare la actualizarea repartizari");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exceptie" + ex.Message);
                }
            }
            FormAnterior();
        }

        private void MeniuRepartizare_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (itemAdaugat)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonCautaProfesor_Click(object sender, EventArgs e)
        {
            this.Hide();
            CautaProfesor cautaPersoana = new CautaProfesor(true);
            cautaPersoana.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Profesor p = stocareProfesori.GetProfesor(getIdDataGrid());
            txtNume.Text = p.nume;
            txtPrenume.Text = p.prenume;
            Materie m = stocareMaterii.GetMaterie(p.idMaterie);
            txtMaterie.Text = m.nume;
            profesorDorit = p.idProfesor;
        }

        private void buttonResetare_Click(object sender, EventArgs e)
        {
            IncarcaMeniuRepartizare();
        }
    }
}
