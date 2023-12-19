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
    public partial class learn_form : Form
    {
        bool check_exit = true;
        public learn_form()
        {
            InitializeComponent();
        }

        private void learn_form_Load(object sender, EventArgs e)
        {

        }

        private void learn_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check_exit == true)
            { Application.Exit(); }
        }
    }
}
