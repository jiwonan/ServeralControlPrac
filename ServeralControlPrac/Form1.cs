using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServeralControlPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckBox cb1 = new CheckBox();
            CheckBox cb2 = new CheckBox();
            CheckBox cb3 = new CheckBox();
            Button btn = new Button();

            cb1.Text = "감자";
            cb2.Text = "고구마";
            cb3.Text = "토마토";
            btn.Text = "클릭";

            cb1.Location = new Point(10, 10);
            cb2.Location = new Point(10, 40);
            cb3.Location = new Point(10, 70);
            btn.Location = new Point(10, 100);

            btn.Click += ButtonClick;
            Controls.Add(cb1);
            Controls.Add(cb2);
            Controls.Add(cb3);
            Controls.Add(btn);

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach(var item in Controls)
            {
                CheckBox cb = item as CheckBox;
                if (cb != null && cb.Checked)
                {
                    list.Add(cb.Text);
                }
                /*
                if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    if (cb.Checked)
                    {
                        list.Add(cb.Text);
                    }
                }*/
            }
            MessageBox.Show(string.Join(",", list));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // System.Diagnostics.Process.Start("https://google.co.kr/");
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}
