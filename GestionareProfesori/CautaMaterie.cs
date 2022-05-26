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
    public partial class CautaMaterie : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));

        public CautaMaterie()
        {
            InitializeComponent();
            AfisareMaterii();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var materie = stocareMaterii.GetMaterii();
                if (materie != null && materie.Any())
                {
                    dataGridView1.DataSource = materie.Select(m => new { m.idMaterie, m.nume}).ToList();

                    dataGridView1.Columns["idMaterie"].Visible = false;
                    dataGridView1.Columns["nume"].HeaderText = "Materie";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #region FUNCTII
        private void AfisareMaterii()
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
        #endregion
    }
}
