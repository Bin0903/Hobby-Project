using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal
{
    public partial class ResForm : Form
    {
        public ResForm()
        {
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            try
            {
                rtb_res.ReadOnly = true;
                StreamReader sr = new StreamReader("res.log", Encoding.UTF8);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    rtb_res.Text += line + "\n";
                }
                sr.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
