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
    
    public partial class MeniuPrincipal : Form
    {
        private const bool SUCCES = true;

        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));


        bool addApasat = false;
        bool modificatApasat = false;

        public MeniuPrincipal()
        {
            InitializeComponent();
            panelAdauga.Visible = false;
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            addApasat = true;
            panelAdauga.Visible = true;
            modificatApasat = false;
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            modificatApasat = true;
            panelAdauga.Visible=true;
            addApasat=false;
        }

        private void buttonPersoana_Click(object sender, EventArgs e)
        {
            if(addApasat)
            {
                this.Hide();
                MeniuProfesor meniuPersoana = new MeniuProfesor(addApasat);
                meniuPersoana.ShowDialog();
                panelAdauga.Visible=false;
                this.Show();

            }
            if(modificatApasat)
            {
                this.Hide();
                CautaProfesor cautaPersoana = new CautaProfesor();
                cautaPersoana.ShowDialog();
                panelAdauga.Visible = false;
                this.Show();
            }
        }

        private void buttonMaterie_Click(object sender, EventArgs e)
        {
            if (addApasat)
            {
                this.Hide();
                MeniuMaterie meniuMaterie = new MeniuMaterie(addApasat);
                meniuMaterie.ShowDialog();
                panelAdauga.Visible = false;
                this.Show();

            }
            if (modificatApasat)
            {
                this.Hide();
                CautaMaterie cautaMaterie = new CautaMaterie();
                cautaMaterie.ShowDialog();
                panelAdauga.Visible = false;
                this.Show();
            }
        }

        private void buttonLiceu_Click(object sender, EventArgs e)
        {
            if (addApasat)
            {
                this.Hide();
                MeniuLiceu meniuLiceu = new MeniuLiceu(addApasat);
                meniuLiceu.ShowDialog();
                panelAdauga.Visible = false;
                this.Show();

            }
            if (modificatApasat)
            {
                this.Hide();
                CautaLiceu cautaLiceu = new CautaLiceu();
                cautaLiceu.ShowDialog();
                panelAdauga.Visible = false;
                this.Show();
            }
        }
    }
}
