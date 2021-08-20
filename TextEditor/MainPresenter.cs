using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace TextEditor
{
    class MainPresenter
    {
        private readonly IMainForm mainForm;
        private readonly IFileManager fileManager;
        private readonly IMessageService messageService;
        private string currentFilePath;

        public MainPresenter(IMainForm _mainForm, IFileManager _fileManager, IMessageService _massageService)
        {
            mainForm = _mainForm;
            fileManager = _fileManager;
            messageService = _massageService;

            mainForm.SetSymbolCount(0);

            mainForm.ContentChanged += mainForm_ContentChanged;
            mainForm.FileOpenClick += mainForm_FileOpenClick;
            mainForm.FileSaveClick += mainForm_FileSaveClick;
        }

        private void mainForm_ContentChanged(object sender, EventArgs e)
        {
            string content = mainForm.Content;
            int count = fileManager.GetSymbolCount(content);
            mainForm.SetSymbolCount(count);
        }

        private void mainForm_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = mainForm.FilePath;
                bool isExist = fileManager.IsExist(filePath);
                if(!isExist)
                {
                    messageService.ShowExclamation("Выбранный файл не существует.");
                    return;
                }

                currentFilePath = filePath;
                string content = fileManager.GetContent(filePath);
                int count = fileManager.GetSymbolCount(content);
                mainForm.Content = content;
                mainForm.SetSymbolCount(count);
            }
            catch (Exception ex)
            {
                messageService.ShowError(ex.Message);
            }
        }

        private void mainForm_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                string content = mainForm.Content;
                if (currentFilePath != null)
                {
                    fileManager.SaveContent(content, currentFilePath);
                }
                else
                {
                    currentFilePath = mainForm.FileSave();
                    fileManager.SaveContent(content, currentFilePath);
                }
                messageService.ShowMessage("Файл успешно сохранён.");
            }
            catch (Exception ex)
            {
                messageService.ShowError(ex.Message);
            }
        }
    }
}
