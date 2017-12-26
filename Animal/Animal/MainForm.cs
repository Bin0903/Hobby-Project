using System;
using System.Collections;
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

    public partial class MainForm : Form
    {
        private ArrayList kb;
        private GoForm goForm;
        private ResForm resForm;
        private ModifyForm modForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void gp_play_Enter(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            ReadKB();
        }
            
        public void ReadKB()
        {
            try
            {
                kb = new ArrayList();

                StreamReader sr = new StreamReader("Animal.kb", Encoding.UTF8);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] block = line.Split(':', ',');
                    string[] rule = new string[block.Length];
                    for (int i = 1; i < block.Length; i++)
                        rule[i-1] = block[i];
                    kb.Add(block[0]);
                    kb.Add(rule);
                }
                sr.Close();
                MessageBox.Show("知识库成功的建立了！");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void bt_input_Click(object sender, EventArgs e)
        {
            goForm = new GoForm(kb);
            goForm.Show();
        }

        private void bt_explain_Click(object sender, EventArgs e)
        {
            resForm = new ResForm();
            resForm.Show();
        }

        private void bt_modify_Click(object sender, EventArgs e)
        {
            modForm = new ModifyForm();
            modForm.Show();
        }
    }
}
