namespace braile_final
{
    partial class triUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(triUC));
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbPERI = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.BrailleLabel = new System.Windows.Forms.TextBox();
            this.rec = new System.Windows.Forms.Panel();
            this.tritext1 = new System.Windows.Forms.TextBox();
            this.tritext2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tributton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.tritext3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rec.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel11.BackgroundImage")));
            this.panel11.Controls.Add(this.Back);
            this.panel11.Controls.Add(this.panel3);
            this.panel11.Controls.Add(this.rec);
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1449, 875);
            this.panel11.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(14, 418);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1397, 404);
            this.panel3.TabIndex = 27;
            this.panel3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.gbPERI);
            this.panel2.Controls.Add(this.ans);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.BrailleLabel);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1368, 372);
            this.panel2.TabIndex = 22;
            // 
            // gbPERI
            // 
            this.gbPERI.AutoSize = true;
            this.gbPERI.BackColor = System.Drawing.Color.White;
            this.gbPERI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPERI.Location = new System.Drawing.Point(428, 58);
            this.gbPERI.Name = "gbPERI";
            this.gbPERI.Padding = new System.Windows.Forms.Padding(3);
            this.gbPERI.Size = new System.Drawing.Size(253, 29);
            this.gbPERI.TabIndex = 15;
            this.gbPERI.Text = "Perimeter of the Triangle is";
            // 
            // ans
            // 
            this.ans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ans.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.Location = new System.Drawing.Point(687, 50);
            this.ans.Multiline = true;
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(100, 40);
            this.ans.TabIndex = 13;
            this.ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(793, 61);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(3);
            this.label15.Size = new System.Drawing.Size(42, 29);
            this.label15.TabIndex = 16;
            this.label15.Text = "cm";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(503, 178);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(3);
            this.label18.Size = new System.Drawing.Size(267, 34);
            this.label18.TabIndex = 17;
            this.label18.Text = "Perimeter Value in Braile";
            // 
            // BrailleLabel
            // 
            this.BrailleLabel.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrailleLabel.Location = new System.Drawing.Point(442, 235);
            this.BrailleLabel.Multiline = true;
            this.BrailleLabel.Name = "BrailleLabel";
            this.BrailleLabel.Size = new System.Drawing.Size(398, 84);
            this.BrailleLabel.TabIndex = 14;
            this.BrailleLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rec
            // 
            this.rec.BackColor = System.Drawing.Color.Transparent;
            this.rec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rec.Controls.Add(this.tritext3);
            this.rec.Controls.Add(this.label1);
            this.rec.Controls.Add(this.label2);
            this.rec.Controls.Add(this.tritext1);
            this.rec.Controls.Add(this.tritext2);
            this.rec.Controls.Add(this.label14);
            this.rec.Controls.Add(this.label23);
            this.rec.Controls.Add(this.label17);
            this.rec.Controls.Add(this.tributton);
            this.rec.Controls.Add(this.label22);
            this.rec.Controls.Add(this.label21);
            this.rec.Location = new System.Drawing.Point(341, 12);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(769, 387);
            this.rec.TabIndex = 26;
            // 
            // tritext1
            // 
            this.tritext1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tritext1.Location = new System.Drawing.Point(329, 104);
            this.tritext1.Name = "tritext1";
            this.tritext1.Size = new System.Drawing.Size(244, 30);
            this.tritext1.TabIndex = 12;
            // 
            // tritext2
            // 
            this.tritext2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tritext2.Location = new System.Drawing.Point(329, 171);
            this.tritext2.Name = "tritext2";
            this.tritext2.Size = new System.Drawing.Size(244, 30);
            this.tritext2.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(579, 170);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(3);
            this.label14.Size = new System.Drawing.Size(50, 33);
            this.label14.TabIndex = 10;
            this.label14.Text = "cm";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(114, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(527, 47);
            this.label23.TabIndex = 2;
            this.label23.Text = "Enter Length for Triangle";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(579, 103);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(3);
            this.label17.Size = new System.Drawing.Size(50, 33);
            this.label17.TabIndex = 9;
            this.label17.Text = "cm";
            // 
            // tributton
            // 
            this.tributton.BackColor = System.Drawing.Color.MediumPurple;
            this.tributton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tributton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tributton.Location = new System.Drawing.Point(307, 316);
            this.tributton.Name = "tributton";
            this.tributton.Padding = new System.Windows.Forms.Padding(3);
            this.tributton.Size = new System.Drawing.Size(113, 42);
            this.tributton.TabIndex = 2;
            this.tributton.Text = "Enter";
            this.tributton.UseVisualStyleBackColor = false;
            this.tributton.Click += new System.EventHandler(this.recbutton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.MediumPurple;
            this.label22.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(125, 103);
            this.label22.Name = "label22";
            this.label22.Padding = new System.Windows.Forms.Padding(3);
            this.label22.Size = new System.Drawing.Size(116, 33);
            this.label22.TabIndex = 3;
            this.label22.Text = "Length 1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.MediumPurple;
            this.label21.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(125, 169);
            this.label21.Name = "label21";
            this.label21.Padding = new System.Windows.Forms.Padding(3);
            this.label21.Size = new System.Drawing.Size(116, 33);
            this.label21.TabIndex = 5;
            this.label21.Text = "Length 2";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.MediumPurple;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(14, 12);
            this.Back.Name = "Back";
            this.Back.Padding = new System.Windows.Forms.Padding(3);
            this.Back.Size = new System.Drawing.Size(113, 42);
            this.Back.TabIndex = 29;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // tritext3
            // 
            this.tritext3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tritext3.Location = new System.Drawing.Point(329, 238);
            this.tritext3.Name = "tritext3";
            this.tritext3.Size = new System.Drawing.Size(244, 30);
            this.tritext3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(579, 237);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(50, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "cm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumPurple;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 236);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(116, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Length 2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1228, 305);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 30;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // triUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel11);
            this.Name = "triUC";
            this.Size = new System.Drawing.Size(1449, 875);
            this.panel11.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.rec.ResumeLayout(false);
            this.rec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label gbPERI;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox BrailleLabel;
        private System.Windows.Forms.Panel rec;
        private System.Windows.Forms.TextBox tritext1;
        private System.Windows.Forms.TextBox tritext2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button tributton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox tritext3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
    }
}
