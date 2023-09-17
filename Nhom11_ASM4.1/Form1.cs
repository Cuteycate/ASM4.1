﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_ASM4._1
{
    public partial class Form1 : Form
    {
        public Image Image { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void scaleToFitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

        private void OpenToolStrip_Click(object sender, EventArgs e)
        {
      

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(ofd.FileName);
                pictureBox1.Image = bit;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void ExitToolStrip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(e.Control && e.KeyCode == Keys.O)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bit = new Bitmap(ofd.FileName);
                    pictureBox1.Image = bit;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                }
            }
        }
    }
}

