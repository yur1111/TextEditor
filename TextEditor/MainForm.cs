using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        string FileSave();
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            buttonOpenFile.Click += buttonOpenFile_Click;
            buttonSaveFile.Click += buttonSaveFile_Click;
            textBoxContent.TextChanged += textBoxContent_TextChanged;
            buttonSelectFile.Click += buttonSelectFile_Click;
            numericFont.ValueChanged += numericFont_ValueChanged;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null)
                FileOpenClick(this, EventArgs.Empty);
        }
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null)
                FileSaveClick(this, EventArgs.Empty);
        }
        private void textBoxContent_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null)
                ContentChanged(this, EventArgs.Empty);
        }

        public string FilePath
        {
            get
            {
                return textBoxFilePath.Text;
            }
        }
        public string Content
        {
            get
            {
                return textBoxContent.Text;
            }
            set
            {
                textBoxContent.Text = value;
            }
        }
        public void SetSymbolCount(int count)
        {
            LabelSymbolCount.Text = count.ToString();
        }
        public string FileSave()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = saveFileDialog.FileName;

            }
            return textBoxFilePath.Text;
        }
        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog.FileName;
                if (FileOpenClick != null)
                    FileOpenClick(this, EventArgs.Empty);
            }
        }
        private void numericFont_ValueChanged(object sender, EventArgs e)
        {
            textBoxContent.Font = new Font("Calibri", (int)numericFont.Value);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dlgRes =  MessageBox.Show("Выполнить сохранение?", "Сохранение", MessageBoxButtons.YesNoCancel);
            if (dlgRes == DialogResult.Yes)
                FileSaveClick(this, EventArgs.Empty);
            else if (dlgRes == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
