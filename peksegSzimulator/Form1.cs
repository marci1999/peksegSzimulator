using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peksegSzimulator
{
    public partial class FPekseg : Form
    {
        int peksegSzam = 0;
        List<Pekseg> pekseg = new List<Pekseg>();
        public FPekseg()
        {
            InitializeComponent();
        }

        private void bTermeketHozzaad_Click(object sender, EventArgs e)
        {
            try
            {
                lBTermekek.Items.Add(new Pekaru(tBNev.Text, Convert.ToInt32(tBAr.Text), cBLaktozmentes.Checked));
            }
            catch (Exception)
            {
                MessageBox.Show("nincs kijelölve a név vagy az ár mező");
            }
        }

        private void bDeleteAru_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < peksegSzam; i++)
            {
                lBPeksegLista.SelectedIndex = i;
                Pekaru aru = (Pekaru)lBTermekek.SelectedItem;
                Pekseg pekseg = (Pekseg)lBPeksegLista.SelectedItem;
                pekseg.lisaElemTorlese(aru);
            }
            lBTermekek.Items.Remove(lBTermekek.SelectedItem);
            lBTermekek.SelectedIndex = -1;
            bTermeketHozzaad.Visible = true;
            bDeleteAru.Visible = false;
            bAtnevezAru.Visible = false;
        }

        private void bAtnevezAru_Click(object sender, EventArgs e)
        {
            try
            {
                lBTermekek.Items.Remove(lBTermekek.SelectedItem);
                lBTermekek.Items.Add(new Pekaru(tBNev.Text, Convert.ToInt32(tBAr.Text), cBLaktozmentes.Checked));
            }
            catch (Exception)
            {
                MessageBox.Show("nincs kijelölve a név vagy az ár mező");
            }
            lBTermekek.SelectedIndex = -1;

            bTermeketHozzaad.Visible = true;
            bDeleteAru.Visible = false;
            bAtnevezAru.Visible = false;
        }
        private void lBTermekek_SelectedIndexChanged(object sender, EventArgs e)
        {
            bTermeketHozzaad.Visible = false;
            bDeleteAru.Visible = true;
            bAtnevezAru.Visible = true;
            try
            {
                Pekaru aruk = (Pekaru)lBTermekek.SelectedItem;
                tBNev.Text = aruk.Nev;
                tBAr.Text = Convert.ToString(aruk.Ar);
                lBTermekLista.Items.Clear();
            }
            catch (Exception)
            {
            }
        }

        private void bPeksegetHozzaad_Click(object sender, EventArgs e)
        {
            string nev = tBUjPekseg.Text;
            var l = new Pekseg(nev, DateTime.Now);
            lBPeksegLista.Items.Add(l);

            peksegSzam++;

            pekseg.Add(l);
        }

        private void hozzaAd_Click(object sender, EventArgs e)
        {
            int pek = lBPeksegek.SelectedIndex;
            int termek = lBTermekek.SelectedIndex;
            //string pekseg = lBPeksegLista.Items(lBPeksegLista.SelectedItem);
            if (lBTermekek.SelectedIndex == -1 && lBPeksegLista.SelectedIndex == -1)
            {
                MessageBox.Show("nincs kijelölve elem");
            }
            else
            {
                Pekseg pekseg = (Pekseg)lBPeksegLista.SelectedItem;
                Pekaru aru = (Pekaru)lBTermekek.SelectedItem;

                pekseg.listahozAdd(aru);
                for (int i = 0; i < pekseg.szamol(); i++)
                {
                    lBTermekLista.Items.Add(pekseg.listaKiIras(i));
                }
            }
        }

        private void lBPeksegLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            bPeksegetHozzaad.Visible = false;
            bAtnevezPekseg.Visible = true;
            bTorol.Visible = true;
            lBTermekLista.Items.Clear();
            Pekseg pekseg = (Pekseg)lBPeksegLista.SelectedItem;
            for (int i = 0; i < pekseg.szamol(); i++)
            {
                lBTermekLista.Items.Add(pekseg.listaKiIras(i));
            }
        }

        private void bAtnavez_Click(object sender, EventArgs e)
        {
            try
            {
                lBPeksegLista.Items.Remove(lBPeksegLista.SelectedItem);
                lBPeksegLista.Items.Add(new Pekaru(tBNev.Text, Convert.ToInt32(tBAr.Text), cBLaktozmentes.Checked));
            }
            catch (Exception)
            {
                MessageBox.Show("nincs kijelölve a név vagy az ár mező");
            }
            lBTermekek.SelectedIndex = -1;

            bPeksegetHozzaad.Visible = true;
            bAtnevezPekseg.Visible = false;
            bTorol.Visible = false;
        }

        private void bTorol_Click(object sender, EventArgs e)
        {

            lBTermekek.Items.Remove(lBTermekek.SelectedItem);
            lBTermekek.SelectedIndex = -1;
            bPeksegetHozzaad.Visible = true;
            bAtnevezPekseg.Visible = false;
            bTorol.Visible = false;
        }

        private void tCPeksegKezelo_Selected(object sender, TabControlEventArgs e)
        {
            lBPeksegek.Items.Clear();

            for (int i = 0; i < pekseg.Count; i++)
            {
                lBPeksegek.Items.Add(peksegolvaso(i));
            }
        }

        private Pekseg peksegolvaso(int i)
        {
            return pekseg.ElementAt(i);
        }

        private void lBPeksegek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pekseg pekseg = (Pekseg)lBPeksegek.SelectedItem;
            tBNev.Text = pekseg.Nev;
            dTPAlapit.Value = pekseg.Alapitva;
            dUDDarabSam.Text = Convert.ToString(pekseg.szamol());
            int osz = 0;
            for (int i = 0; i < pekseg.szamol(); i++)
            {
                osz += pekseg.ar(i);
            }
            dUDAtlagar.Text = Convert.ToString(osz/pekseg.szamol());
            tBlegdragabb.Text = pekseg.Aruk.ElementAt(pekseg.kereso(1)) + "";
            tBlegolcsobb.Text = pekseg.Aruk.ElementAt(pekseg.kereso(0)) + "";
            dUDMenyiseg.Text = Convert.ToString(pekseg.oszegzo());
            MessageBox.Show(pekseg.szazalek(pekseg.oszegzo())+"");
            if (pekseg.vanLaktozmentesTermek())
            {
                dUDSzazalek.Text = Math.Round(pekseg.szazalek(pekseg.oszegzo()),1)+"%";
            }
        }
    }
}
