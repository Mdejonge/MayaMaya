﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayaMaya
{
    public partial class Tafel_Geselecteerd_Form : Form
    {
        public Tafel_Geselecteerd_Form()
        {
            InitializeComponent();
        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            Bestelling Bestelling = new Bestelling("Lunch");

            Bestelling.Show();

            this.Hide();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            TafelOverzicht settingsForm = new TafelOverzicht();
            settingsForm.Show();
            this.Hide();
        }

        private void btn_Diner_Click(object sender, EventArgs e)
        {
            Bestelling Bestelling = new Bestelling("Diner");
            Bestelling.Show();
            this.Hide();
        }

        private void btn_Dranken_Click(object sender, EventArgs e)
        {
            Bestelling Bestelling = new Bestelling("Dranken");
            Bestelling.Show();
            this.Hide();
        }
    }
}
