using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Rename_Files
{
    public partial class Form1 : Form
    {
        private string path;
        private List<string> history;
        public Form1()
        {
            InitializeComponent();

            // initialize path
            path = "";
            history = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            delCharsTB.Text = "Characters/phrases to be removed, seperated by commas, enter to confirm";
            addCharsTB.Text = "Characters/phrases to be added, seperated by commas, enter to confirm";
        }

        private List<string> GetCharsList(string chars)
        {
            // create a string list
            List<string> charsList = new List<string>();

            // split characters string based on ,
            string[] tokens = chars.Split(',');

            // remove extra spaces from each char and add to list
            foreach(string token in tokens)
            {
                string c = token.TrimStart();
                c = c.TrimEnd();

                charsList.Add(c);
            }

            // return list
            return charsList;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            // create object of FolderBrowserDialog
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            // show folder browser dialogue to select directory
            DialogResult result = fbd.ShowDialog();

            if(result == DialogResult.OK)
            {
                // get selected path
                path = fbd.SelectedPath;

                // display current path
                textBox1.Text = path;
            }
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please select directory!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // if remove characters check box is checked
            if (delCharsCB.Checked)
            {
                // get characters list to be removed
                List<string> charList = GetCharsList(delCharsTB.Text);

                // get files names
                string[] fileNames = Directory.GetFiles(path + "\\");

                // total files
                int totalFiles = fileNames.Length;
                // number of renamed files
                int numFilesRenamed = 0;
                // number of processed files
                int numFilesProcessed = 0;

                // set progress bar data
                progressBar1.Minimum = 0;
                progressBar1.Maximum = totalFiles;
                progressText.Text = "Progress (" + numFilesProcessed + "/" + totalFiles + " files renamed)";
                
                // traverse each file
                for (int i=0;i<fileNames.Length;i++)
                {
                    // get name
                    string name = fileNames[i];

                    // get file info
                    FileInfo info = new FileInfo(name);

                    // get Absolute name of files
                    string name_absolute = info.Name;

                    // set status of currently processing file
                    resultTB1.Text = name_absolute;

                    // set progress value
                    progressBar1.Value = numFilesProcessed;

                    // renamed name
                    string new_name = name_absolute;

                    // check file name for each character
                    // if character exists in name then remove it
                    foreach(string ch in charList)
                    {
                        // if file name contains character ch
                        if(name_absolute.Contains(ch))
                        {
                            // remove character
                            new_name = name_absolute.Replace(ch, "");
                            // rename file
                            info.MoveTo(info.Directory.FullName + "\\" + new_name);

                            // update absolute name
                            name_absolute = new_name;

                            numFilesRenamed++;
                        }
                    }

                    // add to history
                    history.Add(new FileInfo(name).Name + " --> " + new_name);

                    // increase renamed file number by 1
                    numFilesProcessed++;

                    progressText.Text = "Progress (" + numFilesProcessed + "/" + totalFiles + " files renamed)";
                }

                progressBar1.Value = progressBar1.Value + 1;

                // clear list box items
                listBox1.Items.Clear();
                // add history to list box
                foreach(string s in history)
                {
                    listBox1.Items.Add(s);
                }
            }

            // if add characters check box is selected
            if (addCharsCB.Checked)
            {
                if(!(startRB.Checked || endRB.Checked))
                {
                    MessageBox.Show("Please select any of mode to add character (Start/End)!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // get characters list to be added
                List<string> charList = GetCharsList(addCharsTB.Text);

                // get files names
                string[] fileNames = Directory.GetFiles(path + "\\");

                // total files
                int totalFiles = fileNames.Length;
                // number of renamed files
                int numFilesRenamed = 0;
                // number of processed files
                int numFilesProcessed = 0;

                // set progress bar data
                progressBar1.Minimum = 0;
                progressBar1.Maximum = totalFiles;
                progressText.Text = "Progress (" + numFilesProcessed + "/" + totalFiles + " files renamed)";

                // traverse each file
                foreach (string name in fileNames)
                {
                    // get file info
                    FileInfo info = new FileInfo(name);

                    // get Absolute name of files
                    string name_absolute = info.Name;

                    // set status of currently processing file
                    resultTB2.Text = name_absolute;

                    // set progress value
                    progressBar1.Value = numFilesProcessed;

                    // renamed name
                    string new_name = name_absolute;

                    // combine characters
                    string chars = "";
                    foreach (string c in charList)
                    {
                        chars += c;
                    }

                    // if start is elected
                    if (startRB.Checked)
                    {
                        // add chars at start
                        new_name = chars + name_absolute;
                        // rename file
                        info.MoveTo(info.Directory.FullName + "\\" + new_name);

                        // add to history
                        history.Add(name_absolute + " --> " + new_name);

                        numFilesRenamed++;
                    }
                    else if (endRB.Checked)
                    {
                        // get last index of . to preserve file extension
                        int index = -1;
                        for (int i = 0; i < new_name.Length; i++)
                        {
                            if (new_name[i] == '.')
                            {
                                index = i;
                            }
                        }

                        // extension length including .
                        int ext_len = name_absolute.Length - index + 1;

                        // get name without extension
                        new_name = name_absolute.Substring(0, name_absolute.Length - ext_len);
                        // get extension
                        string ext = name_absolute.Substring(index, ext_len-1);

                        // append chars at end
                        new_name = new_name + chars;
                        // append file extension
                        new_name += ext;

                        // rename file
                        info.MoveTo(info.Directory.FullName + "\\" + new_name);

                        // add to history
                        history.Add(name_absolute + " --> " + new_name);

                        numFilesRenamed++;
                    }


                    // increase renamed file number by 1
                    numFilesProcessed++;

                    progressText.Text = "Progress (" + numFilesProcessed + "/" + totalFiles + " files renamed)";
                }

                progressBar1.Value = progressBar1.Value + 1;

                // clear list box items
                listBox1.Items.Clear();
                // add history to list box
                foreach (string s in history)
                {
                    listBox1.Items.Add(s);
                }
            }

            // show error message if no check box is selected
            if (!(delCharsCB.Checked || addCharsCB.Checked))
            {
                MessageBox.Show("Please select any of the modes to rename files!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void delCharsCB_CheckedChanged(object sender, EventArgs e)
        {
            delCharsTB.Text = "Characters/phrases to be removed, seperated by commas, enter to confirm";
            progressBar1.Value = 0;
            progressText.Text = "Progress (0/0 files renamed)";
            resultTB1.Text = "";
        }

        private void addCharsCB_CheckedChanged(object sender, EventArgs e)
        {
            addCharsTB.Text = "Characters/phrases to be added, seperated by commas, enter to confirm";
            resultTB2.Text = "";
            progressBar1.Value = 0;
            progressText.Text = "Progress (0/0 files renamed)";
            startRB.Checked = false;
            endRB.Checked = false;
        }

        private void delCharsTB_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.Show("Characters/phrases to be removed, seperated by commas, enter to confirm", delCharsTB, 10, -20, 3000);

            if (delCharsTB.Text.Equals("Characters/phrases to be removed, seperated by commas, enter to confirm"))
            {
                delCharsTB.Text = "";
            }
        }

        private void addCharsTB_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.Show("Characters/phrases to be add, seperated by commas, enter to confirm", addCharsTB, 10, -20, 3000);

            if (addCharsTB.Text.Equals("Characters/phrases to be added, seperated by commas, enter to confirm"))
            {
                addCharsTB.Text = "";
            }
        }
    }
}
