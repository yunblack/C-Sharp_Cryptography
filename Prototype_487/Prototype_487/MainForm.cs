
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

        public static int numberofAdmin = 0;
        public static string adminEmail01 = "";
        public static string adminEmail02 = "";
        public static string adminEmail03 = "";
        public static string adminEmail04 = "";
        public static string adminEmail05 = "";
        public static string adminEmail06 = "";
        public static string adminEmail07 = "";
        public static string adminEmail08 = "";
        public static string adminEmail09 = "";
        public static string adminEmail10 = "";
        public static string secretKey = "";

        private void MainForm_Load(object sender, EventArgs e)
        {
            cryptionSelect.BringToFront();
            mainPanel01.BringToFront();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            mainPanel01.SendToBack();
            mainPanel01.Visible = false;
        }

        private void encryptionBtn_Click(object sender, EventArgs e)
        {
            encryptionPanel.BringToFront();
        }

        private void decryptionBtn_Click(object sender, EventArgs e)
        {
            decryptionPanel.BringToFront();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void encryptionSetBtn_Click(object sender, EventArgs e)
        {
            if (cryptionText01.Text == "1")
            {
                EmailTextClean();
                CryptionEmail01.Visible = true; textLabel01.Visible = true;
                nextBtn.Visible = true;
                numberofAdmin = 1;
            }
            else if (cryptionText01.Text == "2")
            {
                EmailTextClean();
                CryptionEmail01.Visible = true; textLabel01.Visible = true;
                CryptionEmail02.Visible = true; textLabel02.Visible = true;
                nextBtn.Visible = true;
                numberofAdmin = 2;
            }
            else if (cryptionText01.Text == "3")
            {
                EmailTextClean();
                CryptionEmail01.Visible = true; textLabel01.Visible = true;
                CryptionEmail02.Visible = true; textLabel02.Visible = true;
                CryptionEmail03.Visible = true; textLabel03.Visible = true;
                nextBtn.Visible = true;
                numberofAdmin = 3;
            }
            else if (cryptionText01.Text == "4")
            {
                EmailTextClean();
                CryptionEmail01.Visible = true; textLabel01.Visible = true;
                CryptionEmail02.Visible = true; textLabel02.Visible = true;
                CryptionEmail03.Visible = true; textLabel03.Visible = true;
                CryptionEmail04.Visible = true; textLabel04.Visible = true;
                nextBtn.Visible = true;
                numberofAdmin = 4;
            }
            else if (cryptionText01.Text == "5")
            {
                EmailTextClean();
                CryptionEmail01.Visible = true; textLabel01.Visible = true;
                CryptionEmail02.Visible = true; textLabel02.Visible = true;
                CryptionEmail03.Visible = true; textLabel03.Visible = true;
                CryptionEmail04.Visible = true; textLabel04.Visible = true;
                CryptionEmail05.Visible = true; textLabel05.Visible = true;
                nextBtn.Visible = true;
                numberofAdmin = 5;
            }
            else if (cryptionText01.Text == "6")
            {
                EmailTextClean();
                CryptionEmail01.Visible = true; textLabel01.Visible = true;
                CryptionEmail02.Visible = true; textLabel02.Visible = true;
                CryptionEmail03.Visible = true; textLabel03.Visible = true;
                CryptionEmail04.Visible = true; textLabel04.Visible = true;
                CryptionEmail05.Visible = true; textLabel05.Visible = true;
                CryptionEmail06.Visible = true; textLabel06.Visible = true;
                nextBtn.Visible = true;
                numberofAdmin = 6;
            }
            else if (cryptionText01.Text == "7")
            {
                EmailTextClean();
                CryptionEmail01.Visible = true; textLabel01.Visible = true;
                CryptionEmail02.Visible = true; textLabel02.Visible = true;
                CryptionEmail03.Visible = true; textLabel03.Visible = true;
                CryptionEmail04.Visible = true; textLabel04.Visible = true;
                CryptionEmail05.Visible = true; textLabel05.Visible = true;
                CryptionEmail06.Visible = true; textLabel06.Visible = true;
                CryptionEmail07.Visible = true; textLabel07.Visible = true;
                nextBtn.Visible = true;
                numberofAdmin = 7;
            }
            else if (cryptionText01.Text == "8")
            {
                EmailTextClean();
                CryptionEmail01.Visible = true; textLabel01.Visible = true;
                CryptionEmail02.Visible = true; textLabel02.Visible = true;
                CryptionEmail03.Visible = true; textLabel03.Visible = true;
                CryptionEmail04.Visible = true; textLabel04.Visible = true;
                CryptionEmail05.Visible = true; textLabel05.Visible = true;
                CryptionEmail06.Visible = true; textLabel06.Visible = true;
                CryptionEmail07.Visible = true; textLabel07.Visible = true;
                CryptionEmail08.Visible = true; textLabel08.Visible = true;
                nextBtn.Visible = true;
                numberofAdmin = 8;
            }
            else if (cryptionText01.Text == "9")
            {
                EmailTextClean();
                CryptionEmail01.Visible = true; textLabel01.Visible = true;
                CryptionEmail02.Visible = true; textLabel02.Visible = true;
                CryptionEmail03.Visible = true; textLabel03.Visible = true;
                CryptionEmail04.Visible = true; textLabel04.Visible = true;
                CryptionEmail05.Visible = true; textLabel05.Visible = true;
                CryptionEmail06.Visible = true; textLabel06.Visible = true;
                CryptionEmail07.Visible = true; textLabel07.Visible = true;
                CryptionEmail08.Visible = true; textLabel08.Visible = true;
                CryptionEmail09.Visible = true; textLabel09.Visible = true;
                nextBtn.Visible = true;
                numberofAdmin = 9;
            }
            else if (cryptionText01.Text == "10")
            {
                EmailTextClean();
                CryptionEmail01.Visible = true; textLabel01.Visible = true;
                CryptionEmail02.Visible = true; textLabel02.Visible = true;
                CryptionEmail03.Visible = true; textLabel03.Visible = true;
                CryptionEmail04.Visible = true; textLabel04.Visible = true;
                CryptionEmail05.Visible = true; textLabel05.Visible = true;
                CryptionEmail06.Visible = true; textLabel06.Visible = true;
                CryptionEmail07.Visible = true; textLabel07.Visible = true;
                CryptionEmail08.Visible = true; textLabel08.Visible = true;
                CryptionEmail09.Visible = true; textLabel09.Visible = true;
                CryptionEmail10.Visible = true; textLabel10.Visible = true;
                nextBtn.Visible = true;
                numberofAdmin = 10;
            }
            else
            {
                EmailTextClean();
                MessageBox.Show("Invalid Value","Error");
                numberofAdmin = 0;
            }
        }

        public void EmailTextClean()
        {
            CryptionEmail01.Visible = false; textLabel01.Visible = false;
            CryptionEmail02.Visible = false; textLabel02.Visible = false;
            CryptionEmail03.Visible = false; textLabel03.Visible = false;
            CryptionEmail04.Visible = false; textLabel04.Visible = false;
            CryptionEmail05.Visible = false; textLabel05.Visible = false;
            CryptionEmail06.Visible = false; textLabel06.Visible = false;
            CryptionEmail07.Visible = false; textLabel07.Visible = false;
            CryptionEmail08.Visible = false; textLabel08.Visible = false;
            CryptionEmail09.Visible = false; textLabel09.Visible = false;
            CryptionEmail10.Visible = false; textLabel10.Visible = false;
            nextBtn.Visible = false;
        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (numberofAdmin==1)
            {
                adminEmail01 = textLabel01.Text;
            }
            else if (numberofAdmin == 2)
            {
                adminEmail01 = textLabel01.Text;
                adminEmail02 = textLabel02.Text;
            }
            else if (numberofAdmin == 3)
            {
                adminEmail01 = textLabel01.Text;
                adminEmail02 = textLabel02.Text;
                adminEmail03 = textLabel03.Text;
            }
            else if (numberofAdmin == 4)
            {
                adminEmail01 = textLabel01.Text;
                adminEmail02 = textLabel02.Text;
                adminEmail03 = textLabel03.Text;
                adminEmail04 = textLabel04.Text;
            }
            else if (numberofAdmin == 5)
            {
                adminEmail01 = textLabel01.Text;
                adminEmail02 = textLabel02.Text;
                adminEmail03 = textLabel03.Text;
                adminEmail04 = textLabel04.Text;
                adminEmail05 = textLabel05.Text;
            }
            else if (numberofAdmin == 6)
            {
                adminEmail01 = textLabel01.Text;
                adminEmail02 = textLabel02.Text;
                adminEmail03 = textLabel03.Text;
                adminEmail04 = textLabel04.Text;
                adminEmail05 = textLabel05.Text;
                adminEmail06 = textLabel06.Text;
            }
            else if (numberofAdmin == 7)
            {
                adminEmail01 = textLabel01.Text;
                adminEmail02 = textLabel02.Text;
                adminEmail03 = textLabel03.Text;
                adminEmail04 = textLabel04.Text;
                adminEmail05 = textLabel05.Text;
                adminEmail06 = textLabel06.Text;
                adminEmail07 = textLabel07.Text;
            }
            else if (numberofAdmin == 8)
            {
                adminEmail01 = textLabel01.Text;
                adminEmail02 = textLabel02.Text;
                adminEmail03 = textLabel03.Text;
                adminEmail04 = textLabel04.Text;
                adminEmail05 = textLabel05.Text;
                adminEmail06 = textLabel06.Text;
                adminEmail07 = textLabel07.Text;
                adminEmail08 = textLabel08.Text;
            }
            else if (numberofAdmin == 9)
            {
                adminEmail01 = textLabel01.Text;
                adminEmail02 = textLabel02.Text;
                adminEmail03 = textLabel03.Text;
                adminEmail04 = textLabel04.Text;
                adminEmail05 = textLabel05.Text;
                adminEmail06 = textLabel06.Text;
                adminEmail07 = textLabel07.Text;
                adminEmail08 = textLabel08.Text;
                adminEmail09 = textLabel09.Text;
            }
            else if (numberofAdmin == 10)
            {
                adminEmail01 = textLabel01.Text;
                adminEmail02 = textLabel02.Text;
                adminEmail03 = textLabel03.Text;
                adminEmail04 = textLabel04.Text;
                adminEmail05 = textLabel05.Text;
                adminEmail06 = textLabel06.Text;
                adminEmail07 = textLabel07.Text;
                adminEmail08 = textLabel08.Text;
                adminEmail09 = textLabel09.Text;
                adminEmail10 = textLabel10.Text;
            }
            encryptionInnerPanel.Visible = true;
            //Key
            secretKey = "HelloWorld";
        }
    }
}
