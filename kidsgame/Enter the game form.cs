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
    public partial class Enter_the_game_form : Form
    {
        bool check_exit = true;
        public Enter_the_game_form()
        {
            InitializeComponent();
        }

        private void btn_learing_Click(object sender, EventArgs e)
        {
            this.Hide();
            learn_Levels learn_Levels = new learn_Levels();
            learn_Levels.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            check_exit = false;
            Application.OpenForms[1].Show();
            this.Close();
        }

        private void btn_quizzes_Click(object sender, EventArgs e)
        {
            this.Hide();
            quiz_levels levels_Levels = new quiz_levels();
            levels_Levels.ShowDialog();
        }

        private void Enter_the_game_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check_exit == true)
            { Application.Exit(); }
        }
    }
}
