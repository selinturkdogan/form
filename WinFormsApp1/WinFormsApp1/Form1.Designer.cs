namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            btnSelectFont = new Button();
            btnSelectColor = new Button();
            btnBold = new Button();
            btnItalic = new Button();
            btnUpperCase = new Button();
            btnLowerCase = new Button();
            btnClear = new Button();
            btnIsEmail = new Button();
            btnIsNumber = new Button();
            btnWordCount = new Button();
            btnCharCount = new Button();
            btnOpenFile = new Button();
            btnSaveToFile = new Button();
            label1 = new Label();
            label2 = new Label();
            btnAddToListBox1 = new Button();
            txtAddToListBox1 = new TextBox();
            btnAddToListBox2 = new Button();
            txtAddToListBox2 = new TextBox();
            btnRemoveFromListBox1 = new Button();
            txtRemoveFromListBox1 = new TextBox();
            btnRemoveFromListBox2 = new Button();
            txtRemoveFromListBox2 = new TextBox();
            btnRemoveSelectedFromListBox1 = new Button();
            btnRemoveSelectedFromListBox2 = new Button();
            label3 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label4 = new Label();
            btnCopyToListBox2 = new Button();
            btnCopyToListBox1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 69);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 86);
            textBox1.TabIndex = 0;
            // 
            // btnSelectFont
            // 
            btnSelectFont.Location = new Point(12, 184);
            btnSelectFont.Name = "btnSelectFont";
            btnSelectFont.Size = new Size(298, 34);
            btnSelectFont.TabIndex = 1;
            btnSelectFont.Text = "Select Font by FontDialog";
            btnSelectFont.UseVisualStyleBackColor = true;
            btnSelectFont.Click += btnSelectFont_Click;
            // 
            // btnSelectColor
            // 
            btnSelectColor.Location = new Point(12, 236);
            btnSelectColor.Name = "btnSelectColor";
            btnSelectColor.Size = new Size(298, 34);
            btnSelectColor.TabIndex = 2;
            btnSelectColor.Text = "Select Color by ColorDialog";
            btnSelectColor.UseVisualStyleBackColor = true;
            btnSelectColor.Click += btnSelectColor_Click;
            // 
            // btnBold
            // 
            btnBold.Location = new Point(12, 291);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(298, 30);
            btnBold.TabIndex = 3;
            btnBold.Text = "make bold text of textbox";
            btnBold.UseVisualStyleBackColor = true;
            btnBold.Click += btnBold_Click;
            // 
            // btnItalic
            // 
            btnItalic.Location = new Point(11, 452);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(299, 36);
            btnItalic.TabIndex = 4;
            btnItalic.Text = "make italic text of textbox";
            btnItalic.UseVisualStyleBackColor = true;
            btnItalic.Click += btnItalic_Click;
            // 
            // btnUpperCase
            // 
            btnUpperCase.Location = new Point(12, 342);
            btnUpperCase.Name = "btnUpperCase";
            btnUpperCase.Size = new Size(298, 34);
            btnUpperCase.TabIndex = 5;
            btnUpperCase.Text = "make uppercase text of textbox";
            btnUpperCase.UseVisualStyleBackColor = true;
            btnUpperCase.Click += btnUpperCase_Click;
            // 
            // btnLowerCase
            // 
            btnLowerCase.Location = new Point(12, 398);
            btnLowerCase.Name = "btnLowerCase";
            btnLowerCase.Size = new Size(298, 34);
            btnLowerCase.TabIndex = 6;
            btnLowerCase.Text = "make lowercase text  of textbox";
            btnLowerCase.UseVisualStyleBackColor = true;
            btnLowerCase.Click += btnLowerCase_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(471, 43);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(161, 32);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear Textbox";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Clic;
            // 
            // btnIsEmail
            // 
            btnIsEmail.Location = new Point(471, 106);
            btnIsEmail.Name = "btnIsEmail";
            btnIsEmail.Size = new Size(162, 34);
            btnIsEmail.TabIndex = 8;
            btnIsEmail.Text = "Is this an email?";
            btnIsEmail.UseVisualStyleBackColor = true;
            btnIsEmail.Click += btnIsEmail_Click;
            // 
            // btnIsNumber
            // 
            btnIsNumber.Location = new Point(471, 170);
            btnIsNumber.Name = "btnIsNumber";
            btnIsNumber.Size = new Size(170, 34);
            btnIsNumber.TabIndex = 9;
            btnIsNumber.Text = "Is this a number?";
            btnIsNumber.UseVisualStyleBackColor = true;
            btnIsNumber.Click += btnIsNumber_Click;
            // 
            // btnWordCount
            // 
            btnWordCount.Location = new Point(469, 302);
            btnWordCount.Name = "btnWordCount";
            btnWordCount.Size = new Size(201, 33);
            btnWordCount.TabIndex = 10;
            btnWordCount.Text = "How many word";
            btnWordCount.UseVisualStyleBackColor = true;
            btnWordCount.Click += btnWordCount_Click;
            // 
            // btnCharCount
            // 
            btnCharCount.Location = new Point(471, 236);
            btnCharCount.Name = "btnCharCount";
            btnCharCount.Size = new Size(199, 34);
            btnCharCount.TabIndex = 11;
            btnCharCount.Text = "How many character";
            btnCharCount.UseVisualStyleBackColor = true;
            btnCharCount.Click += btnCharCount_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(765, 41);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(440, 34);
            btnOpenFile.TabIndex = 12;
            btnOpenFile.Text = "Open one txt file and set its text into textbox";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(765, 109);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(440, 31);
            btnSaveToFile.TabIndex = 13;
            btnSaveToFile.Text = "Save all text in textbox in one file";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 14;
            label1.Text = "Write your text here:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 549);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 15;
            label2.Text = "Play with listboxes:";
            // 
            // btnAddToListBox1
            // 
            btnAddToListBox1.Location = new Point(12, 590);
            btnAddToListBox1.Name = "btnAddToListBox1";
            btnAddToListBox1.Size = new Size(339, 33);
            btnAddToListBox1.TabIndex = 16;
            btnAddToListBox1.Text = "Add this item to listbox1:";
            btnAddToListBox1.UseVisualStyleBackColor = true;
            btnAddToListBox1.Click += btnAddToListBox1_Click;
            // 
            // txtAddToListBox1
            // 
            txtAddToListBox1.Location = new Point(357, 590);
            txtAddToListBox1.Name = "txtAddToListBox1";
            txtAddToListBox1.Size = new Size(204, 31);
            txtAddToListBox1.TabIndex = 17;
            // 
            // btnAddToListBox2
            // 
            btnAddToListBox2.Location = new Point(673, 590);
            btnAddToListBox2.Name = "btnAddToListBox2";
            btnAddToListBox2.Size = new Size(319, 34);
            btnAddToListBox2.TabIndex = 18;
            btnAddToListBox2.Text = "Add this item to listbox2:";
            btnAddToListBox2.UseVisualStyleBackColor = true;
            btnAddToListBox2.Click += btnAddToListBox2_Click;
            // 
            // txtAddToListBox2
            // 
            txtAddToListBox2.Location = new Point(1018, 590);
            txtAddToListBox2.Name = "txtAddToListBox2";
            txtAddToListBox2.Size = new Size(187, 31);
            txtAddToListBox2.TabIndex = 19;
            // 
            // btnRemoveFromListBox1
            // 
            btnRemoveFromListBox1.Location = new Point(12, 653);
            btnRemoveFromListBox1.Name = "btnRemoveFromListBox1";
            btnRemoveFromListBox1.Size = new Size(339, 34);
            btnRemoveFromListBox1.TabIndex = 20;
            btnRemoveFromListBox1.Text = "Remove this item from listbox1:";
            btnRemoveFromListBox1.UseVisualStyleBackColor = true;
            btnRemoveFromListBox1.Click += btnRemoveFromListBox1_Click;
            // 
            // txtRemoveFromListBox1
            // 
            txtRemoveFromListBox1.Location = new Point(357, 655);
            txtRemoveFromListBox1.Name = "txtRemoveFromListBox1";
            txtRemoveFromListBox1.Size = new Size(204, 31);
            txtRemoveFromListBox1.TabIndex = 21;
            // 
            // btnRemoveFromListBox2
            // 
            btnRemoveFromListBox2.Location = new Point(673, 651);
            btnRemoveFromListBox2.Name = "btnRemoveFromListBox2";
            btnRemoveFromListBox2.Size = new Size(319, 34);
            btnRemoveFromListBox2.TabIndex = 22;
            btnRemoveFromListBox2.Text = "Remove this item from listbox2:";
            btnRemoveFromListBox2.UseVisualStyleBackColor = true;
            btnRemoveFromListBox2.Click += btnRemoveFromListBox2_Click;
            // 
            // txtRemoveFromListBox2
            // 
            txtRemoveFromListBox2.Location = new Point(1018, 656);
            txtRemoveFromListBox2.Name = "txtRemoveFromListBox2";
            txtRemoveFromListBox2.Size = new Size(187, 31);
            txtRemoveFromListBox2.TabIndex = 23;
            // 
            // btnRemoveSelectedFromListBox1
            // 
            btnRemoveSelectedFromListBox1.Location = new Point(12, 713);
            btnRemoveSelectedFromListBox1.Name = "btnRemoveSelectedFromListBox1";
            btnRemoveSelectedFromListBox1.Size = new Size(339, 39);
            btnRemoveSelectedFromListBox1.TabIndex = 24;
            btnRemoveSelectedFromListBox1.Text = "Remove selected item from listbox1:";
            btnRemoveSelectedFromListBox1.UseVisualStyleBackColor = true;
            btnRemoveSelectedFromListBox1.Click += btnRemoveSelectedFromListBox1_Click;
            // 
            // btnRemoveSelectedFromListBox2
            // 
            btnRemoveSelectedFromListBox2.Location = new Point(673, 713);
            btnRemoveSelectedFromListBox2.Name = "btnRemoveSelectedFromListBox2";
            btnRemoveSelectedFromListBox2.Size = new Size(319, 34);
            btnRemoveSelectedFromListBox2.TabIndex = 25;
            btnRemoveSelectedFromListBox2.Text = "Remove selected item from listbox2:";
            btnRemoveSelectedFromListBox2.UseVisualStyleBackColor = true;
            btnRemoveSelectedFromListBox2.Click += btnRemoveSelectedFromListBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 787);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 26;
            label3.Text = "Listbox1 is here:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 839);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 27;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(522, 839);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 129);
            listBox2.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(519, 803);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 29;
            label4.Text = "Listbox2 is here:";
            // 
            // btnCopyToListBox2
            // 
            btnCopyToListBox2.BackgroundImage = (Image)resources.GetObject("btnCopyToListBox2.BackgroundImage");
            btnCopyToListBox2.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopyToListBox2.Location = new Point(258, 922);
            btnCopyToListBox2.Name = "btnCopyToListBox2";
            btnCopyToListBox2.Size = new Size(182, 34);
            btnCopyToListBox2.TabIndex = 30;
            btnCopyToListBox2.Text = "Add to listbox2";
            btnCopyToListBox2.UseVisualStyleBackColor = true;
            btnCopyToListBox2.Click += btnCopyToListBox2_Click;
            // 
            // btnCopyToListBox1
            // 
            btnCopyToListBox1.BackgroundImage = (Image)resources.GetObject("btnCopyToListBox1.BackgroundImage");
            btnCopyToListBox1.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopyToListBox1.Location = new Point(258, 855);
            btnCopyToListBox1.Name = "btnCopyToListBox1";
            btnCopyToListBox1.Size = new Size(182, 34);
            btnCopyToListBox1.TabIndex = 31;
            btnCopyToListBox1.Text = "Add to listbox1";
            btnCopyToListBox1.UseVisualStyleBackColor = true;
            btnCopyToListBox1.Click += btnCopyToListBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 255, 192);
            pictureBox1.Location = new Point(2, 525);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1241, 491);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1266, 1028);
            Controls.Add(btnCopyToListBox1);
            Controls.Add(btnCopyToListBox2);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(btnRemoveSelectedFromListBox2);
            Controls.Add(btnRemoveSelectedFromListBox1);
            Controls.Add(txtRemoveFromListBox2);
            Controls.Add(btnRemoveFromListBox2);
            Controls.Add(txtRemoveFromListBox1);
            Controls.Add(btnRemoveFromListBox1);
            Controls.Add(txtAddToListBox2);
            Controls.Add(btnAddToListBox2);
            Controls.Add(txtAddToListBox1);
            Controls.Add(btnAddToListBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSaveToFile);
            Controls.Add(btnOpenFile);
            Controls.Add(btnCharCount);
            Controls.Add(btnWordCount);
            Controls.Add(btnIsNumber);
            Controls.Add(btnIsEmail);
            Controls.Add(btnClear);
            Controls.Add(btnLowerCase);
            Controls.Add(btnUpperCase);
            Controls.Add(btnItalic);
            Controls.Add(btnBold);
            Controls.Add(btnSelectColor);
            Controls.Add(btnSelectFont);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnSelectFont;
        private Button btnSelectColor;
        private Button btnBold;
        private Button btnItalic;
        private Button btnUpperCase;
        private Button btnLowerCase;
        private Button btnClear;
        private Button btnIsEmail;
        private Button btnIsNumber;
        private Button btnWordCount;
        private Button btnCharCount;
        private Button btnOpenFile;
        private Button btnSaveToFile;
        private Label label1;
        private Label label2;
        private Button btnAddToListBox1;
        private TextBox txtAddToListBox1;
        private Button btnAddToListBox2;
        private TextBox txtAddToListBox2;
        private Button btnRemoveFromListBox1;
        private TextBox txtRemoveFromListBox1;
        private Button btnRemoveFromListBox2;
        private TextBox txtRemoveFromListBox2;
        private Button btnRemoveSelectedFromListBox1;
        private Button btnRemoveSelectedFromListBox2;
        private Label label3;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label4;
        private Button btnCopyToListBox2;
        private Button btnCopyToListBox1;
        private PictureBox pictureBox1;
    }
}
