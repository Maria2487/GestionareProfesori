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
    public partial class MeniuProfesor : Form
    {
        private const bool SUCCES = true;
        private bool esteAdauga;
        private int idProfesorSelectat;
        public bool itemAdaugat = false;

        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));

        public MeniuProfesor(bool esteAdauga, int idProfesorSelectat = -1)
        {
            InitializeComponent();
            if (esteAdauga)
            {
                buttonSterge.Visible = false;
                buttonResetare.Visible = false;
            }
            else
            {
                buttonSterge.Visible = true;
                buttonResetare.Visible = true;
            }

            if (stocareProfesori == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
            this.esteAdauga = esteAdauga;
            this.idProfesorSelectat = idProfesorSelectat;

            IncarcaMeniuProfesori();
        }

        #region METODE 
        

        private void IncarcaMeniuProfesori()
        {
            if(esteAdauga)
            {
                try
                {
                    //se elimina itemii deja adaugati
                    comboBoxMaterie.Items.Clear();

                    var materii = stocareMaterii.GetMaterii();
                    if (materii != null && materii.Any())
                    {
                        foreach (var item in materii)
                        {
                            comboBoxMaterie.Items.Add(new ComboItem(item.nume, (Int32)item.idMaterie));
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
                    Profesor p = stocareProfesori.GetProfesor(idProfesorSelectat);
                    txtNume.Text = p.nume;
                    txtPrenume.Text = p.prenume;

                    //se elimina itemii deja adaugati
                    comboBoxMaterie.Items.Clear();

                    var materii = stocareMaterii.GetMaterii();
                    if (materii != null && materii.Any())
                    {
                        foreach (var item in materii)
                        {
                            comboBoxMaterie.Items.Add(new ComboItem(item.nume, (Int32)item.idMaterie));
                        }

                        Materie materie = null;
                        const int PRIMUL_TABEL = 0;
                        const int PRIMA_LINIE = 0;
                        var m = SqlDBHelper.ExecuteDataSet("select M.idMaterie, M.nume from Profesori_CotofrecM31 P, Materie_CotofrecM31 M WHERE P.idMaterie = M.idMaterie AND P.idProfesor = :idProfesorSelectat", CommandType.Text,
                                new OracleParameter(":idProfesorSelectat", OracleDbType.Int32, idProfesorSelectat, ParameterDirection.Input));
                        if (m.Tables[PRIMUL_TABEL].Rows.Count > 0)
                        {
                            DataRow linieDB = m.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                            materie = new Materie(linieDB);
                        }

                        
                        comboBoxMaterie.SelectedIndex = comboBoxMaterie.FindString(materie.nume);
                    
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
            Profesor profesor = stocareProfesori.GetProfesor(idProfesorSelectat);
            if (profesor == null) return;

            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa elimini PROFESORUL?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;

            var resultPrograme = stocareRepartizari.DeleteRepartizarePentruProfesor(profesor.idProfesor);
            if (resultPrograme == true)
            {
                MessageBox.Show($"Profesorul: {profesor.nume} {profesor.prenume} a fost stears cu succes");
                itemAdaugat = true;
            }

            var result = stocareProfesori.DeleteProfesor(profesor.idProfesor);
            if (result == true)
            {
                MessageBox.Show($"Profesorul: {profesor.nume} {profesor.prenume} a fost stears cu succes");
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
                    if (Validari.ValidareDenumire(txtNume.Text) == "SUCCES")
                    {
                        if(Validari.ValidareDenumire(txtPrenume.Text) == "SUCCES")
                        {
                            if(comboBoxMaterie.SelectedItem != null)
                            {
                                var rezultat = stocareProfesori.AddProfesor(new Profesor(txtNume.Text, txtPrenume.Text, ((ComboItem)comboBoxMaterie.SelectedItem).Value));
                                if (rezultat == SUCCES)
                                {
                                    MessageBox.Show("Profesor adaugat");
                                }
                                else
                                {
                                    MessageBox.Show("Eroare la adaugarea profesorului");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Selectati materia pe care o preda profesorul");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show(Validari.ValidareDenumire(txtPrenume.Text));
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
                        if (Validari.ValidareDenumire(txtPrenume.Text) == "SUCCES")
                        {
                            if (comboBoxMaterie.SelectedItem != null)
                            {
                                var profesor = new Profesor(
                                                            txtNume.Text, txtPrenume.Text,
                                                            ((ComboItem)comboBoxMaterie.SelectedItem).Value, idProfesorSelectat);

                                var rezultat = stocareProfesori.UpdateProfesor(profesor);
                                if (rezultat == SUCCES)
                                {
                                    MessageBox.Show("Profesor actualizat");
                                    itemAdaugat = true;
                                }
                                else
                                {
                                    MessageBox.Show("Eroare la actualizarea profesorului");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Selectati materia pe care o preda profesorul");
                            }

                        }
                        else
                        {
                            MessageBox.Show(Validari.ValidareDenumire(txtPrenume.Text));
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

        private void MeniuProfesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (itemAdaugat)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonResetare_Click(object sender, EventArgs e)
        {
            IncarcaMeniuProfesori();
        }

        private void FormAnterior()
        {
            this.Close();
        }
    }
}

