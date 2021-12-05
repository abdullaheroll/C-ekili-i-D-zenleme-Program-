using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cekilis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (bunifuTextbox1.text == "")
            {
                MessageBox.Show("Boş Geçilemez !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Add(bunifuTextbox1.text);
                bunifuTextbox1.ResetText();
                bunifuTextbox1.Focus();
            }

            int KisiSayisi = listBox1.Items.Count;
            label5.Text = KisiSayisi.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            int kisi;
            Random random = new Random();
            kisi = random.Next(0, listBox1.Items.Count);
            label3.Text = listBox1.Items[kisi].ToString();
            listBox1.Items.Remove(label1.Text);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Text = "KİŞİLER";
        }
    }
}
