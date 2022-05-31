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
    public partial class MeniuLiceu : Form
    {
        private const bool SUCCES = true;
        private bool esteAdauga;
        private int idLiceuSelectat;
        public bool itemAdaugat = false;

        

        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));

        public MeniuLiceu(bool esteAdauga, int idLiceuSelectat = -1)
        {
            InitializeComponent();
            if (esteAdauga)
            {
                radioButtonColegiu.Checked = false;
                radioButtonLiceu.Checked = false;
                buttonSterge.Visible = false;
                buttonResetare.Visible = false;
            }
            else
            {
                radioButtonColegiu.Checked = false;
                radioButtonLiceu.Checked = false;   
                buttonSterge.Visible = true;
                buttonResetare.Visible = true;
            }

            if (stocareLicee == null )
            {
                MessageBox.Show("Eroare la initializare");
            }


            this.esteAdauga = esteAdauga;
            this.idLiceuSelectat = idLiceuSelectat;

            IncarcaMeniuLiceu();
        }

        #region METODE 
        private void FormAnterior()
        {
            this.Close();
        }
        private void IncarcaMeniuLiceu()
        {
            if (esteAdauga)
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
            else
            {
                try
                {
                    Liceu l = stocareLicee.GetLiceu(idLiceuSelectat);
                    txtNume.Text = l.nume;
                    //se elimina itemii deja adaugati
                    comboBoxOras.Items.Clear();

                    var orase = stocareOrase.GetOrase();
                    if (orase != null && orase.Any())
                    {
                        foreach (var item in orase)
                        {
                            comboBoxOras.Items.Add(new ComboItem(item.nume, (Int32)item.idOras));
                        }

                        Oras oras = null;
                        const int PRIMUL_TABEL = 0;
                        const int PRIMA_LINIE = 0;
                        var o = SqlDBHelper.ExecuteDataSet("select O.idOras, O.nume from Liceu_CotofrecM31 L, Orase_CotofrecM31 O WHERE O.idOras = L.idOras AND L.idLiceu = :idLiceuSelectat", CommandType.Text,
                                new OracleParameter(":idLiceuSelectat", OracleDbType.Int32, idLiceuSelectat, ParameterDirection.Input));
                        if (o.Tables[PRIMUL_TABEL].Rows.Count > 0)
                        {
                            DataRow linieDB = o.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                            oras = new Oras(linieDB);
                        }

                        comboBoxOras.SelectedIndex = comboBoxOras.FindString(oras.nume);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }


        }

        #endregion

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            Liceu liceu = stocareLicee.GetLiceu(idLiceuSelectat);
            if (liceu == null) return;

            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa elimini LICEUL?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;

            var resultPrograme = stocareRepartizari.DeleteRepartizarePentruLiceu(liceu.IdLiceu);

            var result = stocareLicee.DeleteLiceu(liceu.IdLiceu);
            if (result == true)
            {
                MessageBox.Show($"Liceul: {liceu.nume} a fost stears cu succes");
                itemAdaugat = true;
            }
            FormAnterior();
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            if(esteAdauga)
            {
                try
                {
                    if(Validari.ValidareDenumire(txtNume.Text) == "SUCCES")
                    {
                        if (comboBoxOras.SelectedItem != null)
                        {
                            string nume = "";
                            if (radioButtonLiceu.Checked)
                            {
                                nume = "Liceul `" + txtNume.Text +"`";
                            }

                            if (radioButtonColegiu.Checked)
                            {
                                nume = "Colegiul `" + txtNume.Text + "`";
                            }
                            if (radioButtonColegiu.Checked == false && radioButtonLiceu.Checked == false)
                            {
                                nume = "Liceul `" + txtNume.Text + "`";
                            }
                            var rezultat = stocareLicee.AddLiceu(new Liceu(nume, ((ComboItem)comboBoxOras.SelectedItem).Value));
                            if (rezultat == SUCCES)
                            {
                                MessageBox.Show("Liceu adaugat");
                            }
                            else
                            {
                                MessageBox.Show("Eroare la adaugarea liceului");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selectati orasul in care se infiinteaza liceul");
                        }
                    }
                    else
                    {
                        MessageBox.Show(Validari.ValidareDenumire(txtNume.Text));
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
                    if (Validari.ValidareDenumire(txtNume.Text) == "SUCCES")
                    {
                        var liceu = new Liceu(txtNume.Text, ((ComboItem)comboBoxOras.SelectedItem).Value, idLiceuSelectat);

                        var rezultat = stocareLicee.UpdateLiceu(liceu);
                        if (rezultat == SUCCES)
                        {
                            MessageBox.Show("Liceu actualizat");
                            itemAdaugat = true;
                        }
                        else
                        {
                            MessageBox.Show("Eroare la actualizarea liceului");
                        }
                    }
                    else
                    {
                        MessageBox.Show(Validari.ValidareDenumire(txtNume.Text));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exceptie" + ex.Message);
                }
            }
            FormAnterior();
        }

        private void MeniuLiceu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(itemAdaugat)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonResetare_Click(object sender, EventArgs e)
        {
            IncarcaMeniuLiceu();
        }
    }
}
