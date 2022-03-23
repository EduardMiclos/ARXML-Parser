using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace XmlParser
{
    public partial class InfoExcel : Form
    {
        public InfoExcel()
        {
            InitializeComponent();
        }

        private void InfoExcel_Load(object sender, EventArgs e)
        {

            boxInfo.Text = @"The Excel should contain one table with 3 columns:

Column 1 ('FILE').
Column 2 ('FROM').
Column 3 ('TO').

Respecting the naming convention is mandatory.

Inside Column 1, we specify the full path to the file that needs to be changed. 
Pro tip: if multiple changes need to be applied to the same file, it is enough to only specify the path once and leave the rest of the Column 1 rows empty until you reach the next file (if it exists) or until the end.

Inside Column 2, we specify the string component that is being replaced.

Inside Column 3, we specify the string component used to replace all the occurrences of the first one.";

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
