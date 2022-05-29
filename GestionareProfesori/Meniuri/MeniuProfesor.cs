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
        IStocareLicee stocareLicee = (IStocareLicee)new StocareFactory().GetTipStocare(typeof(Liceu));
        IStocareMaterie stocareMaterii = (IStocareMaterie)new StocareFactory().GetTipStocare(typeof(Materie));
        IStocareOrase stocareOrase = (IStocareOrase)new StocareFactory().GetTipStocare(typeof(Oras));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFactory().GetTipStocare(typeof(Profesor));
        IStocareRepartizari stocareRepartizari = (IStocareRepartizari)new StocareFactory().GetTipStocare(typeof(Repartizare));

        public MeniuProfesor(bool esteAdauga, int idProfesorSelectat = -1)
        {
            InitializeComponent();
            IncarcaMaterii(esteAdauga, idProfesorSelectat);
        }

        #region METODE 
        

        private void IncarcaMaterii(bool esteAdauga, int itemSelectat)
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
                        var m = SqlDBHelper.ExecuteDataSet("select M.idMaterie, M.nume from Profesori_CotofrecM31 P, Materie_CotofrecM31 M WHERE P.idMaterie = M.idMaterie AND P.idProfesor = :itemSelectat", CommandType.Text,
                                new OracleParameter(":itemSelectat", OracleDbType.Int32, itemSelectat, ParameterDirection.Input));
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

        }
    }
}

