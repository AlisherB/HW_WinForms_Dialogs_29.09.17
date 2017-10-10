using System;
using System.Windows.Forms;
using System.IO;

namespace Meeting5_Task3
{
    public partial class EditingForm : Form
    {
        MainForm mainForm;
        public EditingForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            saveFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            File.WriteAllText(filename, textBoxEdit.Text);
            mainForm.textBox.Text = textBoxEdit.Text;
            this.Hide();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
    }
}
