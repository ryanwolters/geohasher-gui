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
using System.Collections;

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
            // add exception handling & input protection
            string s = uxYear.Text + "-" + uxMonth.Text + "-" + uxDay.Text + "-" + uxDowOpening.Text;
            byte[] encoding = Encoding.ASCII.GetBytes(s);
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(encoding);
            int[] intHash = GetIntHash_Bitwise(hash);
            double latitude = 0;
            double longitude = 0;
            for (int i = 0; i < 16; i++)
            {
                latitude += intHash[i] * Math.Pow(16, -(i + 1));
                longitude += intHash[i + 16] * Math.Pow(16, -(i + 1));
            }
            latitude += Math.Abs(Convert.ToDouble(uxLatitude.Text));
            longitude += Math.Abs(Convert.ToDouble(uxLongitude.Text));
            if (Math.Sign(Convert.ToDouble(uxLatitude.Text)) < 0) latitude *= -1;
            if (Math.Sign(Convert.ToDouble(uxLongitude.Text)) < 0) longitude *= -1;
            latitude = Math.Round(latitude, 6);
            longitude = Math.Round(longitude, 6);
            uxOutputLatitude.Text = latitude.ToString();
            uxOutputLongitude.Text = longitude.ToString();
        }

        private void InitializeUI()
        {
            /*
            uxYear.Text = DateTime.Now.Year.ToString();
            uxMonth.Text = DateTime.Now.Month.ToString();
            uxDay.Text = DateTime.Now.Day.ToString();
            */

            // defaults to test case
            uxYear.Text = "2005";
            uxMonth.Text = "05";
            uxDay.Text = "26";
            uxDowOpening.Text = "10458.68";

        }

        private int[] GetIntHash_Bitwise(byte[] byteHash)
        {
            int[] intHash = new int[32];
            int hashIndex = 0;
            for (int i = 0; i < 16; i++)
            {
                if (((byteHash[i] & (1 << 4)) != 0)) intHash[hashIndex] += 1;
                if (((byteHash[i] & (1 << 5)) != 0)) intHash[hashIndex] += 2;
                if (((byteHash[i] & (1 << 6)) != 0)) intHash[hashIndex] += 4;
                if (((byteHash[i] & (1 << 7)) != 0)) intHash[hashIndex] += 8;
                hashIndex++;
                if (((byteHash[i] & (1 << 0)) != 0)) intHash[hashIndex] += 1;
                if (((byteHash[i] & (1 << 1)) != 0)) intHash[hashIndex] += 2;
                if (((byteHash[i] & (1 << 2)) != 0)) intHash[hashIndex] += 4;
                if (((byteHash[i] & (1 << 3)) != 0)) intHash[hashIndex] += 8;
                hashIndex++;
            }
            return intHash;
        }

        private int[] GetIntHash_BitArrayLibrary(byte[] byteHash)
        {
            int[] intHash = new int[32];
            BitArray ba = new BitArray(byteHash);
            int hashIndex = 0;
            for (int i = 0; i < 16; i++)
            {
                if (ba.Get(i * 8 + 4)) intHash[hashIndex] += 1;
                if (ba.Get(i * 8 + 5)) intHash[hashIndex] += 2;
                if (ba.Get(i * 8 + 6)) intHash[hashIndex] += 4;
                if (ba.Get(i * 8 + 7)) intHash[hashIndex] += 8;
                hashIndex++;
                if (ba.Get(i * 8)) intHash[hashIndex] += 1;
                if (ba.Get(i * 8 + 1)) intHash[hashIndex] += 2;
                if (ba.Get(i * 8 + 2)) intHash[hashIndex] += 4;
                if (ba.Get(i * 8 + 3)) intHash[hashIndex] += 8;
                hashIndex++;
            }
            return intHash;
        }

    }
}
