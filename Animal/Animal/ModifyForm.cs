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
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Animal.kb", Encoding.UTF8);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    rtb_data.Text += line + "\n";
                }
                sr.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void bt_change_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("Animal.kb", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                string[] output = rtb_data.Text.Trim().Split('\n');
                for (int i = 0; i < output.Length; i++)
                    sw.Write(output[i] + "\n");
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
