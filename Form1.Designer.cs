namespace Assignment7
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nameTextBox = new TextBox();
            jerseyTextBox = new TextBox();
            goalTextBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            displayBox = new ListBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            goalRadioButton = new RadioButton();
            jerseyRadioButton = new RadioButton();
            nameRadioButton = new RadioButton();
            reverseCheckBox = new CheckBox();
            sortButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(253, 24);
            label1.Name = "label1";
            label1.Size = new Size(249, 25);
            label1.TabIndex = 0;
            label1.Text = "PLAYER GOAL REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(31, 77);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Player Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(20, 106);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Jersey Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(30, 138);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Goals Scored";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(123, 77);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(203, 23);
            nameTextBox.TabIndex = 4;
            // 
            // jerseyTextBox
            // 
            jerseyTextBox.Location = new Point(123, 106);
            jerseyTextBox.Name = "jerseyTextBox";
            jerseyTextBox.Size = new Size(100, 23);
            jerseyTextBox.TabIndex = 5;
            // 
            // goalTextBox
            // 
            goalTextBox.Location = new Point(123, 135);
            goalTextBox.Name = "goalTextBox";
            goalTextBox.Size = new Size(100, 23);
            goalTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Lime;
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addButton.Location = new Point(123, 179);
            addButton.Name = "addButton";
            addButton.Size = new Size(64, 23);
            addButton.TabIndex = 7;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(128, 255, 255);
            updateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            updateButton.Location = new Point(219, 179);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 8;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // displayBox
            // 
            displayBox.FormattingEnabled = true;
            displayBox.ItemHeight = 15;
            displayBox.Location = new Point(383, 95);
            displayBox.Name = "displayBox";
            displayBox.Size = new Size(343, 259);
            displayBox.TabIndex = 9;
            displayBox.DoubleClick += displayBox_DoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 128, 128);
            label5.Location = new Point(384, 74);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 10;
            label5.Text = "Player";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(255, 128, 128);
            label6.Location = new Point(536, 74);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 11;
            label6.Text = "Jersey Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(255, 128, 128);
            label7.Location = new Point(674, 74);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 12;
            label7.Text = "Goals";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(goalRadioButton);
            groupBox1.Controls.Add(jerseyRadioButton);
            groupBox1.Controls.Add(nameRadioButton);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(20, 238);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 76);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order To Display Players";
            // 
            // goalRadioButton
            // 
            goalRadioButton.AutoSize = true;
            goalRadioButton.ForeColor = Color.FromArgb(255, 128, 0);
            goalRadioButton.Location = new Point(218, 34);
            goalRadioButton.Name = "goalRadioButton";
            goalRadioButton.Size = new Size(54, 19);
            goalRadioButton.TabIndex = 2;
            goalRadioButton.TabStop = true;
            goalRadioButton.Text = "Goals";
            goalRadioButton.UseVisualStyleBackColor = true;
            goalRadioButton.CheckedChanged += goalRadioButton_CheckedChanged;
            // 
            // jerseyRadioButton
            // 
            jerseyRadioButton.AutoSize = true;
            jerseyRadioButton.ForeColor = Color.FromArgb(255, 128, 0);
            jerseyRadioButton.Location = new Point(98, 32);
            jerseyRadioButton.Name = "jerseyRadioButton";
            jerseyRadioButton.Size = new Size(103, 19);
            jerseyRadioButton.TabIndex = 1;
            jerseyRadioButton.TabStop = true;
            jerseyRadioButton.Text = "Jersey Number";
            jerseyRadioButton.UseVisualStyleBackColor = true;
            jerseyRadioButton.CheckedChanged += jerseyRadioButton_CheckedChanged;
            // 
            // nameRadioButton
            // 
            nameRadioButton.AutoSize = true;
            nameRadioButton.ForeColor = Color.FromArgb(255, 128, 0);
            nameRadioButton.Location = new Point(13, 32);
            nameRadioButton.Name = "nameRadioButton";
            nameRadioButton.Size = new Size(57, 19);
            nameRadioButton.TabIndex = 0;
            nameRadioButton.TabStop = true;
            nameRadioButton.Text = "Name";
            nameRadioButton.UseVisualStyleBackColor = true;
            nameRadioButton.CheckedChanged += nameRadioButton_CheckedChanged;
            // 
            // reverseCheckBox
            // 
            reverseCheckBox.AutoSize = true;
            reverseCheckBox.Location = new Point(44, 327);
            reverseCheckBox.Name = "reverseCheckBox";
            reverseCheckBox.Size = new Size(97, 19);
            reverseCheckBox.TabIndex = 14;
            reverseCheckBox.Text = "Reverse order";
            reverseCheckBox.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            sortButton.BackColor = Color.FromArgb(255, 128, 128);
            sortButton.Location = new Point(156, 324);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(75, 23);
            sortButton.TabIndex = 15;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = false;
            sortButton.Click += sortButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(38, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(sortButton);
            Controls.Add(reverseCheckBox);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(displayBox);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(goalTextBox);
            Controls.Add(jerseyTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameTextBox;
        private TextBox jerseyTextBox;
        private TextBox goalTextBox;
        private Button addButton;
        private Button updateButton;
        private ListBox displayBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private RadioButton goalRadioButton;
        private RadioButton jerseyRadioButton;
        private RadioButton nameRadioButton;
        private CheckBox reverseCheckBox;
        private Button sortButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}
