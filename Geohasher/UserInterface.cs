using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Geohasher
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void uxGeohash_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(uxMonth.Text) < 10)
            {
                uxMonth.Text = "0" + uxMonth.Text;
            }
            string s = uxYear.Text + "-" + uxMonth.Text + "-" + uxDay.Text + "-" + uxDowOpening.Text;
            MessageBox.Show(s);
            byte[] encoding = Encoding.ASCII.GetBytes(s);
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(encoding);
            int[] latHash = new int[hash.Length];
            int[] longHash = new int[hash.Length];
            for (int i = 0; i < 16; i++)
            {
                latHash[i] += Convert.ToInt32((hash[i] & (1 << 0)) == 1);
                latHash[i] += Convert.ToInt32((hash[i] & (1 << 1)) == 1);
                latHash[i] += Convert.ToInt32((hash[i] & (1 << 2)) == 1);
                latHash[i] += Convert.ToInt32((hash[i] & (1 << 3)) == 1);

                longHash[i] += Convert.ToInt32((hash[i] & (1 << 4)) == 1);
                longHash[i] += Convert.ToInt32((hash[i] & (1 << 5)) == 1);
                longHash[i] += Convert.ToInt32((hash[i] & (1 << 6)) == 1);
                longHash[i] += Convert.ToInt32((hash[i] & (1 << 7)) == 1);
            }
            double latTail = 0;
            double longTail = 0;
            for (int i = 0; i < 16; i++)
            {
                latTail += latHash[i] * Math.Pow(16, -(i + 1));
                longTail += longHash[i] * Math.Pow(16, -(i + 1));
            }
            uxOutputLatitude.Text = uxLatitude.Text + latTail.ToString();
            uxOutputLongitude.Text = uxLongitude.Text + longTail.ToString();
        }

        private void InitializeUI()
        {
            uxYear.Text = DateTime.Now.Year.ToString();
            uxMonth.Text = DateTime.Now.Month.ToString();
            uxDay.Text = DateTime.Now.Day.ToString();
        }

    }
}
