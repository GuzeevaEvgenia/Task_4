using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace _3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        FileWork file = new FileWork();

        private void OpnBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IntQueue queue = file.Read(openFileDialog.FileName);
                    textBox.Text = queue.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IntQueue queue = file.StrToQueue(textBox.Text);
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file.Write(saveFileDialog.FileName, queue);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
