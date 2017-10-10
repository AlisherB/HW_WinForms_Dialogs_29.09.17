using System;
using System.Windows.Forms;
using System.IO;

namespace Meeting5_Task3
{
    public partial class MainForm : Form
    {
        EditingForm editingForm;
        public MainForm()
        {
            editingForm = new EditingForm(this);
            InitializeComponent();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы(*.*)|*.*";
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            string fileText = File.ReadAllText(filename);
            textBox.Text = fileText;

            buttonEdit.Enabled = true;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            editingForm.textBoxEdit.Text = textBox.Text;
            editingForm.Show();
        }
        
    }
}
