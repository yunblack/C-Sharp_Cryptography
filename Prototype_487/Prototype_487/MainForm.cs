
/*
 * Stony Brook University
 * Computer Science Undergraduate Research Project CSE 487
 * Juyoung Daniel Yun
 * Juyoung.yun@stonybrook.edu
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Prototype_487
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainPanel01.BringToFront();

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            mainPanel01.SendToBack();
            mainPanel01.Visible = false;
        }
    }
}
