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

        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));

        public MeniuMaterie(bool adOrModif)
        {
            InitializeComponent();
            if (stocareMaterii == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {

        }
    }
}
