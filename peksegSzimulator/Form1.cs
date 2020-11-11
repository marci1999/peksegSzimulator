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
            }
            catch (Exception)
            {
            }
        }

        private void bPeksegetHozzaad_Click(object sender, EventArgs e)
        {
            
        }

        private void hozzaAd_Click(object sender, EventArgs e)
        {
            if (lBTermekek.SelectedIndex > -1 && lBPeksegLista.SelectedIndex > -1)
            {
                MessageBox.Show("nincs kitültve anév vagy az ár mező");
            }
            //si2?

            //si2.add ter
            string termek;

            Pekaru aruk = (Pekaru)lBTermekek.SelectedItem;
        }
    }
}
