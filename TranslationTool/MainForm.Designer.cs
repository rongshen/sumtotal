namespace TranslationTool
{
    partial class MainForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gitLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.gitTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.traceBackTextBox = new System.Windows.Forms.TextBox();
            this.traceBackLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.helpButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12378F));
            this.tableLayoutPanel2.Controls.Add(this.gitLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.outputLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.daysLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.gitTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.outputTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(477, 156);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // gitLabel
            // 
            this.gitLabel.AutoSize = true;
            this.gitLabel.Location = new System.Drawing.Point(3, 0);
            this.gitLabel.Name = "gitLabel";
            this.gitLabel.Size = new System.Drawing.Size(67, 13);
            this.gitLabel.TabIndex = 0;
            this.gitLabel.Text = "Git Location:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(3, 56);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(86, 13);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Output Location:";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(3, 106);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(82, 13);
            this.daysLabel.TabIndex = 2;
            this.daysLabel.Text = "Trace Back To:";
            // 
            // gitTextBox
            // 
            this.gitTextBox.Location = new System.Drawing.Point(95, 3);
            this.gitTextBox.Name = "gitTextBox";
            this.gitTextBox.Size = new System.Drawing.Size(320, 20);
            this.gitTextBox.TabIndex = 3;
            this.gitTextBox.Text = "C:\\Program Files (x86)\\Git\\bin\\git.exe";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(95, 59);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(320, 20);
            this.outputTextBox.TabIndex = 4;
            this.outputTextBox.Text = "C:\\ticketNumbers.txt";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.6875F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.3125F));
            this.tableLayoutPanel3.Controls.Add(this.traceBackTextBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.traceBackLabel, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(95, 109);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(320, 44);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // traceBackTextBox
            // 
            this.traceBackTextBox.Location = new System.Drawing.Point(3, 3);
            this.traceBackTextBox.Name = "traceBackTextBox";
            this.traceBackTextBox.Size = new System.Drawing.Size(103, 20);
            this.traceBackTextBox.TabIndex = 0;
            this.traceBackTextBox.Text = "40";
            // 
            // traceBackLabel
            // 
            this.traceBackLabel.AutoSize = true;
            this.traceBackLabel.Location = new System.Drawing.Point(114, 0);
            this.traceBackLabel.Name = "traceBackLabel";
            this.traceBackLabel.Size = new System.Drawing.Size(31, 13);
            this.traceBackLabel.TabIndex = 1;
            this.traceBackLabel.Text = "Days";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(3, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(246, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.7027F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.2973F));
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.helpButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(89, 196);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.57506F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(121, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 2;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 269);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "TranslationTools";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label gitLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.TextBox gitTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox traceBackTextBox;
        private System.Windows.Forms.Label traceBackLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button helpButton;

    }
}

