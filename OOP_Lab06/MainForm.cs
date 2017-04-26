using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab06 {
    public partial class MainForm : Form {
        public MainForm( ) {
            InitializeComponent( );
            Input1.TextChanged += StartCheck;
            Input2.TextChanged += StartCheck;
            StartCheck(null, null);
        }

        private Color GetColor(bool check) {
            if (check) {
                return Color.Green;
            }
            return Color.Red;
        }

        public static int CMP(string s1, string s2) {
            int iTo = Math.Min(s1.Length, s2.Length);
            for (int i = 0; i < iTo; i++) {
                if (s1[i] < s2[i]) {
                    return -1;
                } else if (s1[i] > s2[i]) {
                    return 1;
                }
            }
            if (s1.Length == s2.Length) {
                return 0;
            }
            if (s1.Length > s2.Length) {
                return 1;
            }
            return -1;
        }

        private void StartCheck(Object sender, EventArgs e) {
            int cmp = CMP(Input1.Text, Input2.Text);
            MoreCheck.BackColor = GetColor(cmp == 1);
            LessCheck.BackColor = GetColor(cmp == -1);
            EquallyCheck.BackColor = GetColor(cmp == 0);
            NotEqualCheck.BackColor = GetColor(cmp != 0);
        }

        private string LeftShift(string s) {
            string result = "";
            for (int i = 0; i < s.Length; i++) {
                result += s[(i + 1) % s.Length];
            }
            return result;
        }

        private string RightShift(string s) {
            string result = "";
            for (int i = 0; i < s.Length; i++) {
                result += s[(i + s.Length - 1) % s.Length];
            }
            return result;
        }

        private void LeftButton1_Click(Object sender, EventArgs e) {
            Input1.Text = LeftShift(Input1.Text);
        }

        private void LeftButton2_Click(Object sender, EventArgs e) {
            Input2.Text = LeftShift(Input2.Text);
        }

        private void RightButton1_Click(Object sender, EventArgs e) {
            Input1.Text = RightShift(Input1.Text);
        }

        private void RightButton2_Click(Object sender, EventArgs e) {
            Input2.Text = RightShift(Input2.Text);
        }
    }
}
