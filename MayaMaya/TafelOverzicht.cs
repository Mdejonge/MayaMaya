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
    public partial class TafelOverzicht : Form
    {
        public TafelOverzicht()
        {
            InitializeComponent();
            Tafel1.BackColor = Color.Yellow;
            Tafel2.BackColor = Color.Yellow;
            Tafel3.BackColor = Color.Yellow;
            Tafel4.BackColor = Color.Yellow;
            Tafel5.BackColor = Color.Yellow;
            Tafel6.BackColor = Color.Yellow;
            Tafel7.BackColor = Color.Yellow;
            Tafel8.BackColor = Color.Yellow;
            TafelLabel1.BackColor = Color.Yellow;
            TafelLabel2.BackColor = Color.Yellow;
            TafelLabel3.BackColor = Color.Yellow;
            TafelLabel4.BackColor = Color.Yellow;
            TafelLabel5.BackColor = Color.Yellow;
            TafelLabel6.BackColor = Color.Yellow;
            TafelLabel7.BackColor = Color.Yellow;
            TafelLabel8.BackColor = Color.Yellow;
            TafelLabel9.BackColor = Color.Yellow;





        }

        private void TafelLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Tafel1_Click(object sender, EventArgs e)
        {
            Tafel_Geselecteerd_Form TafelGeselecteerd = new Tafel_Geselecteerd_Form();

            TafelGeselecteerd.Show();

            this.Hide();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            string message = "Geel: Lege tafel \nRood: Order in verwerking \nBlauw: Tafel bezet \nGroen: Bestelling gereed voor serveering";

            string caption = "Hulp";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
        }

        private void ReserveerButton_Click(object sender, EventArgs e)
        {
            Tafelreserveren reserveerform = new Tafelreserveren();
            reserveerform.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginScherm loginform = new LoginScherm();
            loginform.Show();
            this.Close();
        }
    }
}
