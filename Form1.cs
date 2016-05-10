using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPG_v1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int len = rnd.Next(8, 27);
            String str1 = "";
            String str2 = "";
            const String chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_.,;:+-*/!$%&()^=¡{}][@#";
            str1 = new string(Enumerable.Repeat(chars, len).Select(s => s[rnd.Next(s.Length)]).ToArray());
            str2 = new string(Enumerable.Repeat(str1, len).Select(s => s[rnd.Next(s.Length)]).ToArray());
            label1.Text = str2;
        }

    }
}
