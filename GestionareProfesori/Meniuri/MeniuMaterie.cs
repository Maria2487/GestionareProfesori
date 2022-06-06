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
    public partial class MeniuMaterie : Form
    {
        private const bool SUCCES = true;
        private bool esteAdauga;
        private int idMaterieSelectat;
        public bool itemAdaugat = false;

        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        
        public MeniuMaterie(bool esteAdauga, int idMaterieSelectat = -1)
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
                buttonResetare.Visible=true;
            }
            
            if (stocareMaterii == null)
            {
                MessageBox.Show("Eroare la initializare");
            }

            this.esteAdauga = esteAdauga;
            this.idMaterieSelectat = idMaterieSelectat;

            IncarcaMeniuMaterie();
        }

        #region METODE 

        private void IncarcaMeniuMaterie()
        {
            if (esteAdauga == false)
            {
                txtNume.Text = stocareMaterii.GetMaterie(idMaterieSelectat).nume;
            }
        }

        private void FormAnterior()
        {
            this.Close();
        }
        #endregion


        #region Events
        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            if(esteAdauga)
            {
                try
                {
                    if (Validari.ValidareDenumire(txtNume.Text) == "SUCCES")
                    {
                        var rezultat = stocareMaterii.AddMaterie(new Materie(txtNume.Text));
                        if (rezultat == SUCCES)
                        {
                            MessageBox.Show("Materiea a fost adaugata");
                        }
                        else
                        {
                            MessageBox.Show("Eroare la adaugarea materiei");
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
                        var materie = new Materie(txtNume.Text, idMaterieSelectat);

                        var rezultat = stocareMaterii.UpdateMaterie(materie);
                        if (rezultat == SUCCES)
                        {
                            MessageBox.Show("Materie actualizata");
                            itemAdaugat = true;
                        }
                        else
                        {
                            MessageBox.Show("Eroare la actualizarea materiei");
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

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            Materie materie = stocareMaterii.GetMaterie(idMaterieSelectat);
            if (materie == null) return;

            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa elimini MATERIA?", "Mesaj de confirmare", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;
            
            var resultPrograme = stocareProfesori.DeleteProfesorDupaMaterie(materie.idMaterie);
            if(resultPrograme == true)
            {
                MessageBox.Show($"Profesorii au fost stearsi cu succes");
            }

            var result = stocareMaterii.DeleteMaterie(materie);
            if (result == true)
            {
                MessageBox.Show($"Materia: {materie.nume} a fost stearsa cu succes");
                itemAdaugat = true;
            }
            FormAnterior();
        }

        
        private void MeniuMaterie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (itemAdaugat)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        #endregion

        private void buttonResetare_Click(object sender, EventArgs e)
        {
            IncarcaMeniuMaterie();
        }
    }
}
