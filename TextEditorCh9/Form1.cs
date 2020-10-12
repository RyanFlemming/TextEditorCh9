using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditorCh9
{
    public partial class Form1 : Form
    {
        private string name;
        public Form1()
        {
            InitializeComponent();

        }

        private void open_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\rmf91\Desktop";
            openFileDialog1.Filter = "Text Files (*.txt) | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox.Clear();
                textBox.Text = File.ReadAllText(name);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save to file";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox.Text);
            }
        }
    }
}
