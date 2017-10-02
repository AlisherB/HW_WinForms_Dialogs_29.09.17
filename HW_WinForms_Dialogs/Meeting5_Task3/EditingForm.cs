using System;
using System.Windows.Forms;
using System.IO;

namespace Meeting5_Task3
{
    public partial class EditingForm : Form
    {
        public EditingForm()
        {
            InitializeComponent();
            saveFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            File.WriteAllText(filename, textBoxEdit.Text);

            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
