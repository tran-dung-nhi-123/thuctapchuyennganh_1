using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MnuKhachhang_Click(object sender, EventArgs e)
        {
            Forms.Khachhang a = new Forms.Khachhang();
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
        }
    }
}
