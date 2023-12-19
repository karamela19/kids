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
    public partial class quiz_levels : Form
    {
        bool check_exit = true;
        public quiz_levels()
        {
            InitializeComponent();
        }

        private void quiz_levelscs_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            check_exit=false;
            Application.OpenForms[2].Show();
            this.Close();
        }

        private void quiz_levels_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check_exit == true)
            { Application.Exit(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            quiz_form quiz_Form = new quiz_form();
            quiz_Form.ShowDialog();
        }
    }
}
