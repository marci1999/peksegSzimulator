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
                MessageBox.Show("nincs kitültve anév vagy az ár mező");
            }
        }

        private void bMentes_Click(object sender, EventArgs e)
        {
            try
            {
                lBTermekek.Items.Remove(lBTermekek.SelectedItem);
                lBTermekek.Items.Add(new Pekaru(tBNev.Text, Convert.ToInt32(tBAr.Text), cBLaktozmentes.Checked));
            }
            catch (Exception)
            {
                MessageBox.Show("nincs kitültve anév vagy az ár mező");
            }
            lBTermekek.SelectedIndex = -1;

            bTermeketHozzaad.Visible = true;
            bDelete.Visible = false;
            bMentes.Visible = false;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < peksegSzam; i++)
            {
                lBPeksegLista.SelectedIndex = i;
                Pekaru aru = (Pekaru)lBTermekek.SelectedItem;
                Pekseg pekseg = (Pekseg)lBPeksegLista.SelectedItem;
                pekseg.lisaElemTorlese(aru);
            }
            lBTermekek.Items.Remove(lBTermekek.SelectedItem);
        }
        private void lBTermekek_SelectedIndexChanged(object sender, EventArgs e)
        {
            bTermeketHozzaad.Visible = false;
            bDelete.Visible = true;
            bMentes.Visible = true;
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

            lBPeksegLista.Items.Add(new Pekseg(nev, DateTime.Now));
            peksegSzam++;
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
            lBTermekLista.Items.Clear();
            Pekseg pekseg = (Pekseg)lBPeksegLista.SelectedItem;
            for (int i = 0; i < pekseg.szamol(); i++)
            {
                lBTermekLista.Items.Add(pekseg.listaKiIras(i));
            }
        }
    }
}
