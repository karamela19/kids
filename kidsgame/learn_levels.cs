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
    public partial class learn_Levels : Form
    {
        bool check_exit = true;
        public learn_Levels()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            learn_form learn_Form = new learn_form();
            learn_Form.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            check_exit = false;
            Application.OpenForms[2].Show();
            this.Close();
        }

        private void learn_Levels_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check_exit == true)
            { Application.Exit(); }
        }
    }
}
