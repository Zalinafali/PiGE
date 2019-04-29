using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSudoku
{
    public partial class Form1 : Form
    {
        static private Button currentButton;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openCtrlOToolStripMenuItem.ShortcutKeys = (Keys)Shortcut.CtrlO;
            saveCtrlSToolStripMenuItem.ShortcutKeys = (Keys)Shortcut.CtrlS;
            resetCtrlRToolStripMenuItem.ShortcutKeys = (Keys)Shortcut.CtrlR;

            settingsLabel.Font = new Font(settingsLabel.Font.FontFamily, 14);
            fontLabel.Font = new Font(fontLabel.Font.FontFamily, 10);
            for(int i = 0; i < 4; i++)
                for(int j = 0; j < 4; j++)
                {
                    buttonLayoutPanel.GetControlFromPosition(i, j).Font = new Font(buttonLayoutPanel.GetControlFromPosition(i, j).Font.FontFamily, 14);
                    buttonLayoutPanel.GetControlFromPosition(i, j).BackColor = Color.White;
                    buttonLayoutPanel.GetControlFromPosition(i, j).Text = "";
                }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "")
                ((Button)sender).Text = "1";
            else if (((Button)sender).Text == "1")
                ((Button)sender).Text = "2";
            else if (((Button)sender).Text == "2")
                ((Button)sender).Text = "3";
            else if (((Button)sender).Text == "3")
                ((Button)sender).Text = "4";
            else if (((Button)sender).Text == "4")
                ((Button)sender).Text = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    buttonLayoutPanel.GetControlFromPosition(i, j).Font = new Font(buttonLayoutPanel.GetControlFromPosition(i, j).Font.FontFamily, (int)numericUpDown1.Value);
                }
        }

        private void resetCtrlRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    buttonLayoutPanel.GetControlFromPosition(i, j).Font = new Font(buttonLayoutPanel.GetControlFromPosition(i, j).Font.FontFamily, 14);
                    buttonLayoutPanel.GetControlFromPosition(i, j).BackColor = Color.White;
                    buttonLayoutPanel.GetControlFromPosition(i, j).Text = "";
                }
            numericUpDown1.Value = 14;
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            if(MouseButtons.Right == e.Button)
            {
                currentButton = (Button)sender;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void openCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog theDialog = new OpenFileDialog();
            //theDialog.Title = "Open Text File";
            //theDialog.Filter = "TXT files|*.txt";
            //string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..//..//");
            //theDialog.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);

            //List<string> data = new List<string>();

            //if (theDialog.ShowDialog() == DialogResult.OK)
            //{
            //    File.ReadAllLines(theDialog.FileName.ToString())
            //    foreach (string line in File.ReadAllLines(theDialog.FileName.ToString()))
            //    {
            //        string[] row = line.Split(',');
            //        if (row.Length != 4)
            //        {
            //            MessageBox.Show("Wrong file!");
            //            return;
            //        }
            //        for (int i = 0; i < 4; i++)
            //            if (row[i] == "" || (Convert.ToInt32(row[i]) <= 4 && Convert.ToInt32(row[i]) >= 1))
            //                data.Add(row[i]);

            //    }

            }

            private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            currentButton.Text = "1";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            currentButton.Text = "2";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            currentButton.Text = "3";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            currentButton.Text = "4";
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            currentButton.Text = "";
        }

        private void saveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            string[] data = new string[16];
            for (int j = 0; j < 4; j++)
                for (int i = 0; i < 4; i++)
                    data[count++] = buttonLayoutPanel.GetControlFromPosition(i, j).Text;

            string[] board = new string[4];
            board[0] = data[0] + "," + data[1] + "," + data[2] + "," + data[3];
            board[1] = data[4] + "," + data[5] + "," + data[6] + "," + data[7];
            board[2] = data[8] + "," + data[9] + "," + data[10] + "," + data[11];
            board[3] = data[12] + "," + data[13] + "," + data[14] + "," + data[15];


            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..//..//");
            theDialog.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);

            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(theDialog.FileName.ToString(), String.Empty);
                for (int i = 0; i < 4; i++)
                {
                        File.AppendAllText(theDialog.FileName.ToString(), board[i] + Environment.NewLine);
                }
            }
        }
    }
}
