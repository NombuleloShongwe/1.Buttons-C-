using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Buttons_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newWord = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(newWord))
            {
                listBox1.Items.Add(newWord);
                textBox1.Clear();
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            string oldWord = textBox1.Text.Trim();
            string newWord = textBox1.Text.Trim(); // Use the same TextBox for old and new words

            if (!string.IsNullOrEmpty(oldWord) && listBox1.Items.Contains(oldWord))
            {
                int index = listBox1.Items.IndexOf(oldWord);
                listBox1.Items[index] = newWord;
                textBox1.Clear();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string wordToRemove = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(wordToRemove))
            {
                int index = listBox1.FindString(wordToRemove);
                if (index != ListBox.NoMatches)
                {
                    listBox1.Items.RemoveAt(index);
                    textBox1.Clear();

                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            
        }
    }
}
