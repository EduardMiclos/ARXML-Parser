using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ARXML_Parser
{
    public partial class RegexMenu : Form
    {
        public RegexMenu()
        {
            InitializeComponent();
        }

        private void RegexMenu_Load(object sender, EventArgs e)
        {
            txtCurrentRegex.Text = XmlParser.ARXMLParser.currentRegexPattern;
        }

        private static bool isValidRegex(string pattern)
        {
            if (string.IsNullOrWhiteSpace(pattern))
            {
                return false;
            }

            try
            {
                Regex.Match("", pattern);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewRegex.Text != "")
            {
                if (isValidRegex(txtNewRegex.Text) == false)
                {
                    MessageBox.Show("FAILED: The regex is not valid.");
                }
                else
                {
                    XmlParser.ARXMLParser.currentRegexPattern = txtNewRegex.Text;
                    txtCurrentRegex.Text = txtNewRegex.Text;
                    txtNewRegex.Text = "";
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrentRegex.Text = XmlParser.ARXMLParser.initialRegexPattern;
            XmlParser.ARXMLParser.currentRegexPattern = XmlParser.ARXMLParser.initialRegexPattern;
            txtNewRegex.Text = "";
        }
    }
}
