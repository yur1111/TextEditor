
namespace TextEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericFont = new System.Windows.Forms.NumericUpDown();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelSymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericFont)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите файл";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(111, 6);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(539, 23);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFile.Location = new System.Drawing.Point(656, 4);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(65, 25);
            this.buttonSelectFile.TabIndex = 2;
            this.buttonSelectFile.Text = "Выбрать";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile.Location = new System.Drawing.Point(727, 4);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(65, 25);
            this.buttonOpenFile.TabIndex = 3;
            this.buttonOpenFile.Text = "Открыть";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шрифт";
            // 
            // numericFont
            // 
            this.numericFont.Location = new System.Drawing.Point(111, 38);
            this.numericFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numericFont.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericFont.Name = "numericFont";
            this.numericFont.Size = new System.Drawing.Size(85, 23);
            this.numericFont.TabIndex = 5;
            this.numericFont.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBoxContent
            // 
            this.textBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContent.Location = new System.Drawing.Point(13, 73);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContent.Size = new System.Drawing.Size(779, 332);
            this.textBoxContent.TabIndex = 6;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFile.Location = new System.Drawing.Point(717, 411);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(75, 25);
            this.buttonSaveFile.TabIndex = 7;
            this.buttonSaveFile.Text = "Сохранить";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LabelSymbolCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabel1.Text = "Количество символов:";
            // 
            // LabelSymbolCount
            // 
            this.LabelSymbolCount.Name = "LabelSymbolCount";
            this.LabelSymbolCount.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.numericFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericFont)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericFont;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LabelSymbolCount;
    }
}

