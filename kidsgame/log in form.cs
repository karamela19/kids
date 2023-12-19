using System;
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
    public partial class log_in_form : Form
    {
        bool check_exit=true;
        public log_in_form()
        {
            InitializeComponent();
        }

        private void log_in_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            check_exit = false;
            Application.OpenForms[0].Show();
            this.Close();
        }

        

        private void btn_login_game_Click(object sender, EventArgs e)
        {
            this.Hide();
            Enter_the_game_form enter_The_Game_Form = new Enter_the_game_form();
            enter_The_Game_Form.ShowDialog();
        }
        private void log_in_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check_exit == true)
            { Application.Exit(); }
        }

        private void loads_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
