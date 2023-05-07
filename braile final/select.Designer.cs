namespace braile_final
{
    partial class select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(select));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.BrailleLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.countButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dotCountLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.countButton);
            this.panel1.Controls.Add(this.inputTextBox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 875);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(87, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 608);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dotCountLabel);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.BrailleLabel);
            this.panel3.Location = new System.Drawing.Point(118, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 428);
            this.panel3.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(404, 176);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(3);
            this.label18.Size = new System.Drawing.Size(191, 34);
            this.label18.TabIndex = 22;
            this.label18.Text = "Showing in Braile";
            // 
            // BrailleLabel
            // 
            this.BrailleLabel.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrailleLabel.Location = new System.Drawing.Point(168, 230);
            this.BrailleLabel.Multiline = true;
            this.BrailleLabel.Name = "BrailleLabel";
            this.BrailleLabel.Size = new System.Drawing.Size(665, 84);
            this.BrailleLabel.TabIndex = 19;
            this.BrailleLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(696, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "OR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(351, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 56);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select a Shape ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(233, 456);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(468, 53);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter a Letter or Word ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 32;
            this.comboBox1.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Squre",
            "Rectangle"});
            this.comboBox1.Location = new System.Drawing.Point(798, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 40);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Select a Shape";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(798, 465);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(393, 35);
            this.inputTextBox.TabIndex = 10;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // countButton
            // 
            this.countButton.BackColor = System.Drawing.Color.MediumPurple;
            this.countButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.countButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countButton.Location = new System.Drawing.Point(631, 660);
            this.countButton.Name = "countButton";
            this.countButton.Padding = new System.Windows.Forms.Padding(3);
            this.countButton.Size = new System.Drawing.Size(171, 60);
            this.countButton.TabIndex = 7;
            this.countButton.Text = "Enter";
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.countButton_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 360);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 32;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dotCountLabel
            // 
            this.dotCountLabel.AutoSize = true;
            this.dotCountLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotCountLabel.Location = new System.Drawing.Point(278, 63);
            this.dotCountLabel.MaximumSize = new System.Drawing.Size(700, 200);
            this.dotCountLabel.Name = "dotCountLabel";
            this.dotCountLabel.Size = new System.Drawing.Size(62, 23);
            this.dotCountLabel.TabIndex = 33;
            this.dotCountLabel.Text = "label4";
            // 
            // select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1431, 828);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "select";
            this.Text = "select";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox BrailleLabel;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dotCountLabel;
    }
}