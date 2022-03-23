using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace XmlParser
{
    public partial class ARXMLParser : Form
    {
        /* This program only takes into consideration Modern Excel spreadsheet files. */
        private const string ExcelfileExtension = "*.xlsx";

        /* Prefix for the recently created parsed files. */
        private const string ParsedSufix = "_parsed";

        /* All of the program states that are shown in the console. It helps
         * keeping track of the process. */
        private enum PROGRAM_STATE {
            FileSelection, 
            FileSelectionStopped, 
            FileNotSpecified,
            FileDoesntExist,
            FileSelectionCompleted, 
            ExcelTableNotFound, 
            FoundExcelTable, 
            FilesParseSuccess, 
            WorkingOnFile, 
            ModifiedInsideFile, 
            FinishedWorkingOnFile };

        private PROGRAM_STATE programState;

        /* Information regarding Excel manipulation. */        
        private string excelFilePath;
        private Excel excel;

        public const string initialRegexPattern = "word(?![A-Za-z0-9])(?!_)";
        public static string currentRegexPattern = ARXMLParser.initialRegexPattern;

        Dictionary<string, List<Tuple<string, string>>> changesDictionary = new Dictionary<string, List<Tuple<string, string>>>();

        public ARXMLParser()
        {
            InitializeComponent();
        }

        private void XMLParser_Load(object sender, EventArgs e)
        {
            this.excelFilePath = "";
        }

        private void AppendText(RichTextBox richTextBox, string str, Color color)
        {
            richTextBox.SelectionStart = richTextBox.TextLength;
            richTextBox.SelectionLength = 0;
            richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);

            richTextBox.SelectionColor = color;
            richTextBox.AppendText(str);

            txtProcessStatus.SelectionColor = richTextBox.ForeColor;
        }

        private void AppendText(RichTextBox richTextBox, string str)
        {
            richTextBox.AppendText(str);
        }

        private void updateTxtProcessStatus(PROGRAM_STATE programState)
        {
            this.programState = programState;
            switch (programState)
            {
                case PROGRAM_STATE.FileSelection:
                    this.AppendText(txtProcessStatus, "Selecting a file...\n");
                    break;
                case PROGRAM_STATE.FileSelectionStopped:
                    this.AppendText(txtProcessStatus, "File selection stopped!\n");
                    break;
                case PROGRAM_STATE.FileNotSpecified:                    
                        this.AppendText(txtProcessStatus, "FAILED: Excel file not specified...\n", Color.DarkRed);
                        break;
                case PROGRAM_STATE.FileDoesntExist:
                    this.AppendText(txtProcessStatus, "FAILED: The following file doesn't exist: ", Color.DarkRed);
                    break;
                case PROGRAM_STATE.FileSelectionCompleted:
                    this.AppendText(txtProcessStatus, "SUCCESS: The file was selected: " + this.excelFilePath.Substring(this.excelFilePath.LastIndexOf('\\') + 1) + '\n', Color.DarkGreen);
                    break;
                case PROGRAM_STATE.ExcelTableNotFound:
                    this.AppendText(txtProcessStatus, "FAILED: Couldn't find the table inside Excel. Make sure you respect the Excel structure.\n", Color.DarkRed);
                    break;
                case PROGRAM_STATE.FoundExcelTable:
                    this.AppendText(txtProcessStatus, "SUCCESS: Found the Excel table.\n", Color.DarkGreen);
                    break;
                case PROGRAM_STATE.FilesParseSuccess:
                    this.AppendText(txtProcessStatus, "SUCCESS: The files were successfully parsed!\n", Color.DarkGreen);
                    break;
                case PROGRAM_STATE.WorkingOnFile:
                    this.AppendText(txtProcessStatus, "Working on file: ", txtProcessStatus.ForeColor);
                    break;
                case PROGRAM_STATE.ModifiedInsideFile:
                    this.AppendText(txtProcessStatus, "Updated ");
                    break;
                case PROGRAM_STATE.FinishedWorkingOnFile:
                    this.AppendText(txtProcessStatus, "Finished working on file: ", txtProcessStatus.ForeColor);
                    break;
                default:
                    break;
            }
        }

        private void updateTxtProcessStatus(PROGRAM_STATE programState, string fileName, Color color)
        {
            this.updateTxtProcessStatus(programState);
            this.AppendText(txtProcessStatus, fileName + '\n', color);
        }

        private void updateTxtProcessStatus(PROGRAM_STATE programState, string from, string to)
        {
            this.updateTxtProcessStatus(programState);
            this.AppendText(txtProcessStatus, from + " to " + to + " on all occurrences.\n");
        }

        /* Overloaded method. It takes 3 more parameters:
           1. The index of the line that was changed.
           2. The string that was replaced.
           3. The string that was used to replace the old string. */
        private void updateTxtProcessStatus(PROGRAM_STATE programState, int lineIndex, string from, string to)
        {
            this.updateTxtProcessStatus(programState);
            this.AppendText(txtProcessStatus, "line " + lineIndex + ": " + from + " to " + to + '\n');
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            this.resetProgressBar();
            this.updateTxtProcessStatus(PROGRAM_STATE.FileSelection);
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.RestoreDirectory = true;
            ofd.Filter = "Excel Workboox | " + ARXMLParser.ExcelfileExtension;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                this.excelFilePath = ofd.FileName;
                this.updateTxtProcessStatus(PROGRAM_STATE.FileSelectionCompleted);
            }
            else
            {
                this.updateTxtProcessStatus(PROGRAM_STATE.FileSelectionStopped);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfoExcel info = new InfoExcel();
            this.Enabled = false;
            info.ShowDialog(); 

            this.Enabled = true;
        }

        private void resetProgressBar()
        {
            progressBar.Maximum = 0;
            progressBar.Value = 0;
        }

        private void increaseProgressBar()
        {
            progressBar.Maximum++;
            progressBar.Value++;
        }

        private void parseXMLs()
        {
            string fileName;
            string fileWithoutExt;
            string fileExt;

            foreach (string filePath in this.changesDictionary.Keys)
            {
                if (File.Exists(filePath) == false){
                    this.updateTxtProcessStatus(PROGRAM_STATE.FileDoesntExist, filePath, Color.DarkRed);
                    return;
                }
                
                fileName = Path.GetFileName(filePath);
                fileWithoutExt = Path.GetFileNameWithoutExtension(filePath);
                fileExt = Path.GetExtension(filePath);

                this.resetProgressBar();
                this.updateTxtProcessStatus(PROGRAM_STATE.WorkingOnFile, fileName, txtProcessStatus.ForeColor);

                StreamWriter writer = new StreamWriter(filePath.Replace(fileName, fileWithoutExt + ARXMLParser.ParsedSufix + fileExt));

                string fromStr, toStr;

                if (radioBtnFaster.Checked == true)
                {
                    string allText = File.ReadAllText(filePath);
                    foreach (var tuple in this.changesDictionary[filePath])
                    {
                        this.increaseProgressBar();
                        fromStr = tuple.Item1;
                        toStr = tuple.Item2;

                        if (Regex.IsMatch(allText, ARXMLParser.currentRegexPattern.Replace("word", fromStr))) {
                            this.updateTxtProcessStatus(PROGRAM_STATE.ModifiedInsideFile, fromStr, toStr);
                            allText = Regex.Replace(allText, ARXMLParser.currentRegexPattern.Replace("word", fromStr), toStr);
                        }

                    }
                    writer.WriteLine(allText);
                    writer.Close();
                }
                else
                {
                    string line;
                    StreamReader reader = new StreamReader(filePath);

                    int lineIndex = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        lineIndex++;
                        foreach (var tuple in this.changesDictionary[filePath])
                        {
                            this.increaseProgressBar();
                            fromStr = tuple.Item1;
                            toStr = tuple.Item2;

                            if (Regex.IsMatch(line, ARXMLParser.currentRegexPattern.Replace("word", fromStr)))
                            {
                                this.updateTxtProcessStatus(PROGRAM_STATE.ModifiedInsideFile, lineIndex, fromStr, toStr);
                                line = line.Replace(fromStr, toStr);
                            }
                        }
                        writer.WriteLine(line);
                    }
                    reader.Close();
                    writer.Close();
                }
                this.updateTxtProcessStatus(PROGRAM_STATE.FinishedWorkingOnFile, fileName, txtProcessStatus.ForeColor);
            }

            this.updateTxtProcessStatus(PROGRAM_STATE.FilesParseSuccess);
        }

        private void checkForDestroy()
        {
            if (radioBtnDestructive.Checked == true)
            {
                string fileName;
                string fileWithoutExt;
                string fileExt;

                foreach (string filePath in this.changesDictionary.Keys)
                {
                    fileName = Path.GetFileName(filePath);
                    fileWithoutExt = Path.GetFileNameWithoutExtension(filePath);
                    fileExt = Path.GetExtension(filePath);

                    System.IO.File.Delete(filePath);
                    System.IO.File.Move(filePath.Replace(fileName, fileWithoutExt + ARXMLParser.ParsedSufix + fileExt), filePath);
                }
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            if(this.excelFilePath == "")
            {
                this.updateTxtProcessStatus(PROGRAM_STATE.FileNotSpecified);
            }
            else
            {
                this.excel = new Excel(this.excelFilePath);
                this.changesDictionary.Clear();

                if(this.excel.findTable() == true)
                {
                    this.updateTxtProcessStatus(PROGRAM_STATE.FoundExcelTable);

                    while(this.excel.extractNextRow() != Excel.EmptyRow)
                    {
                        if(this.changesDictionary.ContainsKey(Excel.currentFile) == false)
                        {
                            this.changesDictionary.Add(Excel.currentFile, new List<Tuple<String, String>>());
                        }

                        this.changesDictionary[Excel.currentFile].Add(Tuple.Create(Excel.currentFrom, Excel.currentTo));
                    }
                    
                    this.parseXMLs();
                    this.checkForDestroy();
                }
                else
                {
                    this.updateTxtProcessStatus(PROGRAM_STATE.ExcelTableNotFound);
                }
            }
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            txtProcessStatus.Text = "";
        }

        private void btnChangeRegex_Click(object sender, EventArgs e)
        {
            ARXML_Parser.RegexMenu regexMenu = new ARXML_Parser.RegexMenu();
            this.Enabled = false;
            regexMenu.ShowDialog();
            
            this.Enabled = true;
        }
    }
}
