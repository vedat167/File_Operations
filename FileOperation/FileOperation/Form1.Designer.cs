namespace FileOperation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFileCreate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnFileControl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.btnFileList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLastAccesstTime = new System.Windows.Forms.Button();
            this.btnChangeFileName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFileCreate
            // 
            this.btnFileCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFileCreate.Location = new System.Drawing.Point(3, 2);
            this.btnFileCreate.Name = "btnFileCreate";
            this.btnFileCreate.Size = new System.Drawing.Size(121, 30);
            this.btnFileCreate.TabIndex = 0;
            this.btnFileCreate.Text = "Create File";
            this.btnFileCreate.UseVisualStyleBackColor = true;
            this.btnFileCreate.Click += new System.EventHandler(this.btnFileCreate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(301, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 29);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(204, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name :";
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteFile.Location = new System.Drawing.Point(3, 39);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(121, 30);
            this.btnDeleteFile.TabIndex = 3;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnFileControl
            // 
            this.btnFileControl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFileControl.Location = new System.Drawing.Point(3, 77);
            this.btnFileControl.Name = "btnFileControl";
            this.btnFileControl.Size = new System.Drawing.Size(121, 30);
            this.btnFileControl.TabIndex = 4;
            this.btnFileControl.Text = "Is There File?";
            this.btnFileControl.UseVisualStyleBackColor = true;
            this.btnFileControl.Click += new System.EventHandler(this.btnFileControl_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(3, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Created Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFilePath
            // 
            this.btnFilePath.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilePath.Location = new System.Drawing.Point(3, 154);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(121, 30);
            this.btnFilePath.TabIndex = 6;
            this.btnFilePath.Text = "File Path";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // btnFileList
            // 
            this.btnFileList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFileList.Location = new System.Drawing.Point(3, 192);
            this.btnFileList.Name = "btnFileList";
            this.btnFileList.Size = new System.Drawing.Size(121, 30);
            this.btnFileList.TabIndex = 7;
            this.btnFileList.Text = "File List";
            this.btnFileList.UseVisualStyleBackColor = true;
            this.btnFileList.Click += new System.EventHandler(this.btnFileList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(208, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 251);
            this.listBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(204, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "File List";
            // 
            // btnLastAccesstTime
            // 
            this.btnLastAccesstTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLastAccesstTime.Location = new System.Drawing.Point(3, 228);
            this.btnLastAccesstTime.Name = "btnLastAccesstTime";
            this.btnLastAccesstTime.Size = new System.Drawing.Size(121, 30);
            this.btnLastAccesstTime.TabIndex = 10;
            this.btnLastAccesstTime.Text = "Last Access";
            this.btnLastAccesstTime.UseVisualStyleBackColor = true;
            this.btnLastAccesstTime.Click += new System.EventHandler(this.btnLastAccesstTime_Click);
            // 
            // btnChangeFileName
            // 
            this.btnChangeFileName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangeFileName.Location = new System.Drawing.Point(3, 264);
            this.btnChangeFileName.Name = "btnChangeFileName";
            this.btnChangeFileName.Size = new System.Drawing.Size(121, 30);
            this.btnChangeFileName.TabIndex = 11;
            this.btnChangeFileName.Text = "Change File Name";
            this.btnChangeFileName.UseVisualStyleBackColor = true;
            this.btnChangeFileName.Click += new System.EventHandler(this.btnChangeFileName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(478, 385);
            this.Controls.Add(this.btnChangeFileName);
            this.Controls.Add(this.btnLastAccesstTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnFileList);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFileControl);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFileCreate);
            this.Name = "Form1";
            this.Text = "File Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileCreate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnFileControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Button btnFileList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLastAccesstTime;
        private System.Windows.Forms.Button btnChangeFileName;
    }
}

