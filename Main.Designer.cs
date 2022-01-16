namespace SomeBinaryStuff
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.BinaryStuffLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.checkLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.incorrectLabel = new System.Windows.Forms.Label();
            this.lastBinaryLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(132, 206);
            this.startButton.MaximumSize = new System.Drawing.Size(164, 23);
            this.startButton.MinimumSize = new System.Drawing.Size(164, 23);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(164, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(132, 207);
            this.inputTextBox.MaximumSize = new System.Drawing.Size(164, 20);
            this.inputTextBox.MinimumSize = new System.Drawing.Size(164, 20);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(164, 20);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Visible = false;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // BinaryStuffLabel
            // 
            this.BinaryStuffLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BinaryStuffLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BinaryStuffLabel.Location = new System.Drawing.Point(62, 61);
            this.BinaryStuffLabel.Margin = new System.Windows.Forms.Padding(53, 0, 3, 0);
            this.BinaryStuffLabel.MaximumSize = new System.Drawing.Size(302, 72);
            this.BinaryStuffLabel.MinimumSize = new System.Drawing.Size(302, 72);
            this.BinaryStuffLabel.Name = "BinaryStuffLabel";
            this.BinaryStuffLabel.Size = new System.Drawing.Size(302, 72);
            this.BinaryStuffLabel.TabIndex = 2;
            this.BinaryStuffLabel.Text = "BinaryStuff";
            this.BinaryStuffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.Location = new System.Drawing.Point(332, 280);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(76, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // checkLabel
            // 
            this.checkLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkLabel.Location = new System.Drawing.Point(101, 160);
            this.checkLabel.Margin = new System.Windows.Forms.Padding(53, 0, 3, 0);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(225, 43);
            this.checkLabel.TabIndex = 4;
            this.checkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctLabel
            // 
            this.correctLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.correctLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.correctLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.correctLabel.Location = new System.Drawing.Point(173, 263);
            this.correctLabel.Margin = new System.Windows.Forms.Padding(53, 0, 3, 0);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(153, 21);
            this.correctLabel.TabIndex = 5;
            this.correctLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.incorrectLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.incorrectLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.incorrectLabel.Location = new System.Drawing.Point(173, 284);
            this.incorrectLabel.Margin = new System.Windows.Forms.Padding(53, 0, 3, 0);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(153, 17);
            this.incorrectLabel.TabIndex = 6;
            this.incorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastBinaryLabel
            // 
            this.lastBinaryLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lastBinaryLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lastBinaryLabel.Location = new System.Drawing.Point(133, 133);
            this.lastBinaryLabel.Margin = new System.Windows.Forms.Padding(53, 0, 3, 0);
            this.lastBinaryLabel.MaximumSize = new System.Drawing.Size(164, 27);
            this.lastBinaryLabel.MinimumSize = new System.Drawing.Size(164, 27);
            this.lastBinaryLabel.Name = "lastBinaryLabel";
            this.lastBinaryLabel.Size = new System.Drawing.Size(164, 27);
            this.lastBinaryLabel.TabIndex = 7;
            this.lastBinaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromLabel.Location = new System.Drawing.Point(267, 8);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(35, 16);
            this.fromLabel.TabIndex = 11;
            this.fromLabel.Text = "from";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toLabel.Location = new System.Drawing.Point(348, 8);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(19, 16);
            this.toLabel.TabIndex = 12;
            this.toLabel.Text = "to";
            // 
            // fromComboBox
            // 
            this.fromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fromComboBox.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.fromComboBox.Location = new System.Drawing.Point(306, 8);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(38, 21);
            this.fromComboBox.TabIndex = 9;
            // 
            // toComboBox
            // 
            this.toComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.toComboBox.Location = new System.Drawing.Point(372, 8);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(38, 21);
            this.toComboBox.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 318);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.lastBinaryLabel);
            this.Controls.Add(this.incorrectLabel);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.checkLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.BinaryStuffLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.startButton);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(434, 353);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(434, 353);
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SomeBinaryStuff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label BinaryStuffLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label checkLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label incorrectLabel;
        private System.Windows.Forms.Label lastBinaryLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.ComboBox toComboBox;
    }
}

