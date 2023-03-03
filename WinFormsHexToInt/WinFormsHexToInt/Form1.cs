using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsHexToInt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtDezZahl_KeyPress(object sender, KeyPressEventArgs e)
        {
            int zahl;
            String eingabe;
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    eingabe = txtDezZahl.Text;
                    zahl = Convert.ToInt32(eingabe);
                    txtHexZahl.Text = String.Format("{0:X}", zahl);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("NEIN");
            }

        }

        private void txtHexZahl_KeyPress(object sender, KeyPressEventArgs e)
        {
            int zahl;
            String eingabe;
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    eingabe = txtHexZahl.Text;
                    zahl = Konvertiere.hexToInt32(eingabe);
                    txtDezZahl.Text = String.Format("{0}", zahl);

                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}

