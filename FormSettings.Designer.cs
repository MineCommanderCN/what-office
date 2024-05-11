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
            checkBox_notify = new CheckBox();
            label_counter = new Label();
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
            dataGridView_path.Location = new Point(15, 34);
            dataGridView_path.Margin = new Padding(4);
            dataGridView_path.Name = "dataGridView_path";
            dataGridView_path.RowHeadersWidth = 51;
            dataGridView_path.RowTemplate.Height = 25;
            dataGridView_path.Size = new Size(998, 329);
            dataGridView_path.TabIndex = 0;
            // 
            // _ProductName
            // 
            _ProductName.HeaderText = "软件名称";
            _ProductName.MinimumWidth = 6;
            _ProductName.Name = "_ProductName";
            _ProductName.Width = 125;
            // 
            // WordProcessing
            // 
            WordProcessing.HeaderText = "文档处理(Word)";
            WordProcessing.MinimumWidth = 6;
            WordProcessing.Name = "WordProcessing";
            WordProcessing.Width = 125;
            // 
            // Spreadsheet
            // 
            Spreadsheet.HeaderText = "电子表格(Excel)";
            Spreadsheet.MinimumWidth = 6;
            Spreadsheet.Name = "Spreadsheet";
            Spreadsheet.Width = 125;
            // 
            // Presentation
            // 
            Presentation.HeaderText = "幻灯片(PPT)";
            Presentation.MinimumWidth = 6;
            Presentation.Name = "Presentation";
            Presentation.Width = 125;
            // 
            // label_path
            // 
            label_path.AutoSize = true;
            label_path.Location = new Point(15, 11);
            label_path.Margin = new Padding(4, 0, 4, 0);
            label_path.Name = "label_path";
            label_path.Size = new Size(99, 20);
            label_path.TabIndex = 1;
            label_path.Text = "编辑软件路径";
            // 
            // label_default
            // 
            label_default.AutoSize = true;
            label_default.Location = new Point(15, 385);
            label_default.Margin = new Padding(4, 0, 4, 0);
            label_default.Name = "label_default";
            label_default.Size = new Size(99, 20);
            label_default.TabIndex = 2;
            label_default.Text = "默认打开方式";
            // 
            // comboBox_default
            // 
            comboBox_default.FormattingEnabled = true;
            comboBox_default.Items.AddRange(new object[] { "微软Office", "WPS Office", "LibreOffice" });
            comboBox_default.Location = new Point(126, 381);
            comboBox_default.Margin = new Padding(4);
            comboBox_default.Name = "comboBox_default";
            comboBox_default.Size = new Size(154, 28);
            comboBox_default.TabIndex = 3;
            // 
            // checkBox_charmoji
            // 
            checkBox_charmoji.AutoSize = true;
            checkBox_charmoji.Location = new Point(172, 424);
            checkBox_charmoji.Margin = new Padding(4);
            checkBox_charmoji.Name = "checkBox_charmoji";
            checkBox_charmoji.Size = new Size(106, 24);
            checkBox_charmoji.TabIndex = 4;
            checkBox_charmoji.Text = "启用颜文字";
            checkBox_charmoji.UseVisualStyleBackColor = true;
            // 
            // checkBox_notify
            // 
            checkBox_notify.AutoSize = true;
            checkBox_notify.Location = new Point(15, 424);
            checkBox_notify.Margin = new Padding(4);
            checkBox_notify.Name = "checkBox_notify";
            checkBox_notify.Size = new Size(136, 24);
            checkBox_notify.TabIndex = 5;
            checkBox_notify.Text = "启用任务栏通知";
            checkBox_notify.UseVisualStyleBackColor = true;
            // 
            // label_counter
            // 
            label_counter.AutoSize = true;
            label_counter.Location = new Point(682, 491);
            label_counter.Name = "label_counter";
            label_counter.Size = new Size(331, 20);
            label_counter.TabIndex = 6;
            label_counter.Text = "WhatOffice 已经帮您打开了 {0} 次文档！\\(^o^)/";
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 529);
            Controls.Add(label_counter);
            Controls.Add(checkBox_notify);
            Controls.Add(checkBox_charmoji);
            Controls.Add(comboBox_default);
            Controls.Add(label_default);
            Controls.Add(label_path);
            Controls.Add(dataGridView_path);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
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
        private CheckBox checkBox_notify;
        private Label label_counter;
    }
}