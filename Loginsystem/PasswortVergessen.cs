﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginsystem
{
    public partial class PasswortVergessen : Form
    {
        public PasswortVergessen()
        {
            InitializeComponent();
            AddPlaceholder();
        }

        private void zurueck_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void beenden_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AddPlaceholder()
        {
            // Placeholder Zuordnung
            benutzername_textBox.AddPlaceholder("Benutzername");
            neuesPasswort_textBox.AddPlaceholder("Neues Passwort");
        }

        private void anmelden_button_Click(object sender, EventArgs e)
        {

        }
    }
}
