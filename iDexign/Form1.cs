using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iDexign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(40, 44, 70);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(pictureBox1, true);
            ControlExtension.Draggable(label6, true);
            ControlExtension.Draggable(label7, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(width.Text);
            int h = Convert.ToInt32(height.Text);
            using (var bmp = new Bitmap(w, h))
            {
                panel2.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(textBox1.Text + ".bmp");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            label6.Text = textBox1.Text;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            label7.Text = textBox2.Text;
        }
    }
}
