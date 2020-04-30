using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremieBerekenenTijnAltena
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void ComboBox2_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    textBox1.Text = "25";
                    break;
                case 1:
                    textBox1.Text = "10";
                    break;
                case 2:
                    textBox1.Text = "15";
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                if (radioButton1.Checked == true)
                {
                    listBox1.Items.Add(100 + (Convert.ToInt32(textBox2.Text) * 0.03)).ToString();
                    listBox1.Items.Add((100 + (Convert.ToInt32(textBox2.Text) * 0.03)) * 0.75).ToString();
                }
                else if (radioButton2.Checked == true)
                {
                    listBox1.Items.Add(150 + (Convert.ToInt32(textBox2.Text) * 0.01)).ToString();
                    listBox1.Items.Add((150 + (Convert.ToInt32(textBox2.Text) * 0.01)) * 0.75).ToString();
                }
                else
                {
                    listBox1.Items.Add(100 + (Convert.ToInt32(textBox2.Text) * 0.001)).ToString();
                    listBox1.Items.Add((100 + (Convert.ToInt32(textBox2.Text) * 0.001)) * 0.75).ToString();
                }

            }
            if (comboBox2.SelectedIndex == 1)
            {
                if (radioButton1.Checked == true)
                {
                    listBox1.Items.Add(100 + (Convert.ToInt32(textBox2.Text) * 0.03)).ToString();
                    listBox1.Items.Add((100 + (Convert.ToInt32(textBox2.Text) * 0.03)) * 0.90).ToString();
                }
                else if (radioButton2.Checked == true)
                {
                    listBox1.Items.Add(150 + (Convert.ToInt32(textBox2.Text) * 0.01)).ToString();
                    listBox1.Items.Add((150 + (Convert.ToInt32(textBox2.Text) * 0.01)) * 0.90).ToString();
                }
                else
                {
                    listBox1.Items.Add(100 + (Convert.ToInt32(textBox2.Text) * 0.001)).ToString();
                    listBox1.Items.Add((100 + (Convert.ToInt32(textBox2.Text) * 0.001)) * 0.90).ToString();
                }

            }
            if (comboBox2.SelectedIndex == 2)
            {
                if (radioButton1.Checked == true)
                {
                    listBox1.Items.Add(100 + (Convert.ToInt32(textBox2.Text) * 0.03)).ToString();
                    listBox1.Items.Add((100 + (Convert.ToInt32(textBox2.Text) * 0.03)) * 0.85).ToString();
                }
                else if (radioButton2.Checked == true)
                {
                    listBox1.Items.Add(150 + (Convert.ToInt32(textBox2.Text) * 0.01)).ToString();
                    listBox1.Items.Add((150 + (Convert.ToInt32(textBox2.Text) * 0.01)) * 0.85).ToString();
                }
                else
                {
                    listBox1.Items.Add(100 + (Convert.ToInt32(textBox2.Text) * 0.001)).ToString();
                    listBox1.Items.Add((100 + (Convert.ToInt32(textBox2.Text) * 0.001)) * 0.85).ToString();
                }

            }
        }
    }
}
            
