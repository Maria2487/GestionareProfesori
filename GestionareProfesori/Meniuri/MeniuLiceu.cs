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

        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));

        public MeniuLiceu(bool esteAdauga, int idLiceuSelectat = -1)
        {
            InitializeComponent();
            this.esteAdauga = esteAdauga;
            this.idLiceuSelectat = idLiceuSelectat;
            IncarcaOrase();
        }

        #region METODE 
        private void IncarcaOrase()
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
            if (resultPrograme == true)
            {
                var result = stocareLicee.DeleteLiceu(liceu.IdLiceu);

                if (result == true)
                {
                    MessageBox.Show($"Liceul: {liceu.nume} a fost stears cu succes");
                }
            }
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            if(esteAdauga)
            {
                try
                {
                    var rezultat = stocareLicee.AddLiceu(new Liceu(txtNume.Text, ((ComboItem)comboBoxOras.SelectedItem).Value));
                    if (rezultat == SUCCES)
                    {
                        MessageBox.Show("Liceu adaugat");
                    }
                    else
                    {
                        MessageBox.Show("Eroare la adaugarea liceului");
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
                    var liceu = new Liceu(
                        txtNume.Text,
                        ((ComboItem)comboBoxOras.SelectedItem).Value);

                    var rezultat = stocareLicee.UpdateLiceu(liceu);
                    if (rezultat == SUCCES)
                    {
                        MessageBox.Show("Liceu actualizat");
                    }
                    else
                    {
                        MessageBox.Show("Eroare la actualizarea liceului");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exceptie" + ex.Message);
                }
            }
        }
    }
}
