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
    public partial class Welcome_formcs : Form
    {
        public Welcome_formcs()
        {
            InitializeComponent();
        }

        private void Welcome_formcs_Load(object sender, EventArgs e)
        {

        }

        private void btn_sign_in_form_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_in_form sign_In_Form = new sign_in_form(); 
            sign_In_Form.Show();
            

        }

        private void btn_loads_form_click(object sender, EventArgs e)
        {
            this.Hide();
            log_in_form log_In_Form = new log_in_form();
            log_In_Form.ShowDialog();
        }
    }
}
