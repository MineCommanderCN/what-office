namespace WhatOffice
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            dataGridView_path = new DataGridView();
            _ProductName = new DataGridViewTextBoxColumn();
            WordProcessing = new DataGridViewTextBoxColumn();
            Spreadsheet = new DataGridViewTextBoxColumn();
            Presentation = new DataGridViewTextBoxColumn();
            label_path = new Label();
            label_default = new Label();
            comboBox_default = new ComboBox();
            checkBox_charmoji = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_path).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_path
            // 
            dataGridView_path.AllowUserToAddRows = false;
            dataGridView_path.AllowUserToDeleteRows = false;
            dataGridView_path.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_path.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_path.Columns.AddRange(new DataGridViewColumn[] { _ProductName, WordProcessing, Spreadsheet, Presentation });
            dataGridView_path.Location = new Point(12, 29);
            dataGridView_path.Name = "dataGridView_path";
            dataGridView_path.RowTemplate.Height = 25;
            dataGridView_path.Size = new Size(776, 280);
            dataGridView_path.TabIndex = 0;
            // 
            // _ProductName
            // 
            _ProductName.HeaderText = "软件名称";
            _ProductName.Name = "_ProductName";
            // 
            // WordProcessing
            // 
            WordProcessing.HeaderText = "文档处理(Word)";
            WordProcessing.Name = "WordProcessing";
            // 
            // Spreadsheet
            // 
            Spreadsheet.HeaderText = "电子表格(Excel)";
            Spreadsheet.Name = "Spreadsheet";
            // 
            // Presentation
            // 
            Presentation.HeaderText = "幻灯片(PPT)";
            Presentation.Name = "Presentation";
            // 
            // label_path
            // 
            label_path.AutoSize = true;
            label_path.Location = new Point(12, 9);
            label_path.Name = "label_path";
            label_path.Size = new Size(80, 17);
            label_path.TabIndex = 1;
            label_path.Text = "编辑软件路径";
            // 
            // label_default
            // 
            label_default.AutoSize = true;
            label_default.Location = new Point(12, 327);
            label_default.Name = "label_default";
            label_default.Size = new Size(80, 17);
            label_default.TabIndex = 2;
            label_default.Text = "默认打开方式";
            // 
            // comboBox_default
            // 
            comboBox_default.FormattingEnabled = true;
            comboBox_default.Items.AddRange(new object[] { "微软Office", "WPS Office", "LibreOffice" });
            comboBox_default.Location = new Point(98, 324);
            comboBox_default.Name = "comboBox_default";
            comboBox_default.Size = new Size(121, 25);
            comboBox_default.TabIndex = 3;
            // 
            // checkBox_charmoji
            // 
            checkBox_charmoji.AutoSize = true;
            checkBox_charmoji.Location = new Point(259, 326);
            checkBox_charmoji.Name = "checkBox_charmoji";
            checkBox_charmoji.Size = new Size(87, 21);
            checkBox_charmoji.TabIndex = 4;
            checkBox_charmoji.Text = "启用颜文字";
            checkBox_charmoji.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox_charmoji);
            Controls.Add(comboBox_default);
            Controls.Add(label_default);
            Controls.Add(label_path);
            Controls.Add(dataGridView_path);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSettings";
            Text = "WhatOffice 设置";
            FormClosing += FormSettings_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView_path).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_path;
        private Label label_path;
        private Label label_default;
        private ComboBox comboBox_default;
        private CheckBox checkBox_charmoji;
        private DataGridViewTextBoxColumn _ProductName;
        private DataGridViewTextBoxColumn WordProcessing;
        private DataGridViewTextBoxColumn Spreadsheet;
        private DataGridViewTextBoxColumn Presentation;
    }
}