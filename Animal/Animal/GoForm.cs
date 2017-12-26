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
    public partial class GoForm : Form
    {
        private ArrayList kb;
        private HashSet<string> set;
        private ArrayList list = new ArrayList();

        public GoForm()
        {
            InitializeComponent();
        }

        public GoForm(ArrayList kb)
        {
            InitializeComponent();
            this.kb = kb;
            set = new HashSet<string>();
        }

        private void GoForm_Load(object sender, EventArgs e)
        {
            rtb_shape.ReadOnly = true;
            rtb_res.ReadOnly = true;
        }

        private void bt_input_Click(object sender, EventArgs e)
        {
         
            string shape = tb_shape.Text.Trim();
            rtb_shape.Text +=  shape + '\n';
            list.Add(shape);
            set.Add(shape);
            if (list.ToArray().Length != set.Count())
            {
                MessageBox.Show("输入了重复的特征！");
            }
            tb_shape.Text = "";
        }

        private void bt_go_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("res.log", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            bool mark = false;
            string shape = "";
            Dictionary<int, int> record = new Dictionary<int, int>();
            Queue q = new Queue();
            ArrayList tmp = new ArrayList();
            foreach (var item in set)
            {
                tmp.Add(item);
                q.Enqueue(item);
            }
            int count = 0;
            ArrayList front = new ArrayList();
            ArrayList after = new ArrayList();
            ArrayList final = new ArrayList();
            foreach (var k in kb)
            {
                if (count++ % 2 == 0)
                    after.Add((string)k);
                else
                    front.Add((string[])k);
            }

            int front_len = front.ToArray().Length;
            int after_len = after.ToArray().Length;

            bool used = false;

            for (int i = 0; i<after_len; i++ )
            {
                used = false;
                for(int j=0; j<after_len; j++)
                {
                    if(j==i)
                        continue;
                    string[] each = (string[])front[j];
                    for (int k = 0; k < each.Length-1; k++)
                    {
                        if (each[k].Equals((string)after[i]))
                        {
                            used = true;
                        }
                    }
                }
                if (!used)
                    final.Add((string)after[i]);
            }

            while (true)
            {
                if (q.ToArray().Length == 0)
                    break;
                count = 0;
                shape = (string)q.Dequeue();
                foreach (string str in final)
                {
                    if (str.Equals(shape)) 
                    {
                        rtb_res.Text = str;
                        mark = true;
                    }
                }
                if (mark)
                    break;
                else
                {
                    for(int i=0; i<front_len; i++)
                    {
                        string[] each = ((string[])front[i]);
                        for(int j=0; j<each.Length-1; j++)
                            if (each[j].Equals(shape))
                            {
                                if (record.ContainsKey(i))
                                {
                                    if (record[i] - 1 == 0) 
                                    {
                                        q.Enqueue(after[i]);
                                        rtb_res.Text = after[i] + "\n";
                                        record[i] = -1;
                                        sw.Write("因为" + String.Join(",", each) + "所以是" + after[i] + '\n');
                                    }
                                    record[i]--;
                                }
                                else 
                                {
                                    record.Add(i, each.Length - 2);
                                    if (record[i] == 0)
                                    {
                                        tmp.Add(after[i]);
                                        q.Enqueue(after[i]);
                                        rtb_res.Text = after[i] + "\n";
                                        record[i] = -1;                           
                                        sw.Write("因为" + String.Join(",", each) + "所以是" + after[i] + '\n');
                                    }
                                }
                            }
                    }
                }
            }
            bool flag = true;
            for (int i = 0; i < final.ToArray().Length; i++)
                if (final[i].Equals(shape))
                {
                    flag = false;
                    break;
                }
            if (flag)
                MessageBox.Show("请输入更多特征");
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Clear();
            set.Clear();
            rtb_shape.Text = "";
            rtb_res.Text = "";
        }
    }
}
