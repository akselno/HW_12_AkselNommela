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

namespace EX_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string fileName = textBox_fileName.Text;
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("File name is mandatory!","Error!");
            }
            else
            {
                string fullPath = Path.Combine(filePath, fileName);
                SaveMaleFile(fullPath);
                SaveFemaleFile(fullPath);
                label_path.Text = "Saved!";
            }
        }
        public void SaveMaleFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName + "_male.txt"))
            {
                for (int r = 0; r < dataGridView1.RowCount - 1; r++)
                {
                    if ((string)dataGridView1.Rows[r].Cells[1].Value == "Male")
                    {
                        for (int c = 0; c < 1; c++)
                        {
                            if (dataGridView1.Rows[r].Cells[2].Value != null)
                            {
                                writer.Write(dataGridView1.Rows[r].Cells[0].Value + " - liked");
                            }
                            else
                            {
                                writer.Write(dataGridView1.Rows[r].Cells[0].Value + " - did not like");
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        public void SaveFemaleFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName + "_female.txt"))
            {
                for (int r = 0; r < dataGridView1.RowCount - 1; r++)
                {
                    if ((string)dataGridView1.Rows[r].Cells[1].Value == "Female")
                    {
                        for (int c = 0; c < 1; c++)
                        {
                            if (dataGridView1.Rows[r].Cells[2].Value != null)
                            {
                                writer.Write(dataGridView1.Rows[r].Cells[0].Value + " - liked");
                            }
                            else
                            {
                                writer.Write(dataGridView1.Rows[r].Cells[0].Value + " - did not like");
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private string filePath = "";
        private void button_choose_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                filePath = folderBrowserDialog1.SelectedPath;
                label_path.Visible = true;
                label_path.Text = filePath;
            }
        }
    }
}
