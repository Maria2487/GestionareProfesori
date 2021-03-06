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
        private bool addApasat = false;
        private bool modificatApasat = false;
        private const bool SUCCES = true;

        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        
        public MeniuPrincipal()
        {
            InitializeComponent();
            labelInformatiiPrincipal.Visible = true;
            panelAdauga.Visible = false;
            panelInformatii.Visible = false;
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            addApasat = true;
            panelAdauga.Visible = true;
            panelInformatii.Visible = false;
            modificatApasat = false;
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            modificatApasat = true;
            panelAdauga.Visible=true;
            panelInformatii.Visible = false;
            addApasat =false;
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

        private void buttonRepartizare_Click(object sender, EventArgs e)
        {
            if (addApasat)
            {
                this.Hide();
                MeniuRepartizare meniuRepartizare = new MeniuRepartizare(addApasat);
                meniuRepartizare.ShowDialog();
                panelAdauga.Visible = false;
                this.Show();

            }
            if (modificatApasat)
            {
                this.Hide();
                CautaRepartizare cautaRepartizare = new CautaRepartizare();
                cautaRepartizare.ShowDialog();
                panelAdauga.Visible = false;
                this.Show();
            }
        }

        private void buttonInformatii_Click(object sender, EventArgs e)
        {
            panelAdauga.Visible = false;
            panelInformatii.Visible = true;
        }


        private void ResetarePagina()
        {
            dataGridView1.DataSource = null;
            radioButtonNumarLiceeExistente.Checked = false;
            radioButtonNumarProfesoriExistenti.Checked = false;
            radioButtonNumarMaterii.Checked = false;
        }

        private void buttonResetare_Click(object sender, EventArgs e)
        {
            ResetarePagina();
        }

        private void buttonRaspuns_Click(object sender, EventArgs e)
        {
            if(radioButtonNumarLiceeExistente.Checked == true)
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

            else if (radioButtonNumarProfesoriExistenti.Checked == true)
            {
                try
                {
                    var profesori = stocareProfesori.GetDetaliiProfesori();
                    if (profesori != null)
                    {

                        dataGridView1.DataSource = profesori.Tables[0];

                        dataGridView1.Columns["idProfesor"].Visible = false;
                        dataGridView1.Columns["numeProfesor"].HeaderText = "Nume";
                        dataGridView1.Columns["prenume"].HeaderText = "Prenume";
                        dataGridView1.Columns["idMaterie"].Visible = false;
                        dataGridView1.Columns["numeMaterie"].HeaderText = "Materie";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

            else if (radioButtonNumarMaterii.Checked == true)
            {
                try
                {
                    var materie = stocareMaterii.GetMaterii();
                    if (materie != null && materie.Any())
                    {
                        dataGridView1.DataSource = materie.Select(m => new { m.idMaterie, m.nume }).ToList();

                        dataGridView1.Columns["idMaterie"].Visible = false;
                        dataGridView1.Columns["nume"].HeaderText = "Materie";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Selectati una dintre optiuni");
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            labelInformatiiPrincipal.Text = $"Inregistrari: {dataGridView1.RowCount}";
        }

    }
}
