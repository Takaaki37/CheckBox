using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //起動して最初に読み込まれる
            //最初にを非表示にしておく
            FreeLabel.Enabled = false;

        }

        private void FreeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //チェックをいれたときに起動する
            Set();
        }

        private void Set()
        {
            if (FreeCheckBox.Checked)
            {
                FreeLabel.Enabled = true;
            }
            else
            {
                FreeLabel.Enabled = false;
            }
        }
    }
}
