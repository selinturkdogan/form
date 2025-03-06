using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
        }

        private void btnUpperCase_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void btnLowerCase_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
        }

        private void btnClear_Clic(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnIsNumber_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out _))
                MessageBox.Show("The input is a number.");
            else
                MessageBox.Show("The input is NOT a number.");
        }

        private void btnIsEmail_Click(object sender, EventArgs e)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (Regex.IsMatch(textBox1.Text, pattern))
                MessageBox.Show("The input is a valid email.");
            else
                MessageBox.Show("The input is NOT a valid email.");
        }

        private void btnCharCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Number of characters: {textBox1.Text.Length}");
        }

        private void btnWordCount_Click(object sender, EventArgs e)
        {
            string[] words = textBox1.Text.Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show($"Number of words: {words.Length}");
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
            }
        }

        private void btnAddToListBox1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddToListBox1.Text))
            {
                listBox1.Items.Add(txtAddToListBox1.Text);
                txtAddToListBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter text to add.");
            }
        }

        private void btnRemoveFromListBox1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRemoveFromListBox1.Text))
            {
                if (listBox1.Items.Contains(txtRemoveFromListBox1.Text))
                {
                    listBox1.Items.Remove(txtRemoveFromListBox1.Text);
                    txtRemoveFromListBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Item not found in ListBox1.");
                }
            }
            else
            {
                MessageBox.Show("Please enter text to remove.");
            }
        }

        private void btnRemoveSelectedFromListBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void btnCopyToListBox2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }
        }

        private void btnAddToListBox2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddToListBox2.Text))
            {
                listBox2.Items.Add(txtAddToListBox2.Text);
                txtAddToListBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please enter text to add.");
            }
        }

        private void btnRemoveFromListBox2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRemoveFromListBox2.Text))
            {
                if (listBox2.Items.Contains(txtRemoveFromListBox2.Text))
                {
                    listBox2.Items.Remove(txtRemoveFromListBox2.Text);
                    txtRemoveFromListBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Item not found in ListBox2.");
                }
            }
            else
            {
                MessageBox.Show("Please enter text to remove.");
            }
        }

        private void btnRemoveSelectedFromListBox2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void btnCopyToListBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
