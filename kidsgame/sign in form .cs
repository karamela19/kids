﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kidsgame
{
    public partial class sign_in_form : Form
    {
        bool check_exit = true;
        public sign_in_form()
        {
            InitializeComponent();
        }
        

        private void sign_in_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            check_exit = false;
            Application.OpenForms[0].Show();
            this.Close();
        
        }

   
        private void btn_sign_in_game_Click(object sender, EventArgs e)
        {
            this.Hide();
            Enter_the_game_form enter_The_Game_Form2 = new Enter_the_game_form();
            enter_The_Game_Form2.Show();
        }

        private void sign_in_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check_exit == true)
            { Application.Exit(); }

        }

        
    }
}
