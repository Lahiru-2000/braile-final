namespace braile_final
{
    partial class cirUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cirUC));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbPERI = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.brailtext = new System.Windows.Forms.TextBox();
            this.rec = new System.Windows.Forms.Panel();
            this.cirtext = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cirbutton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rec.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(17, 412);
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
            this.panel2.Controls.Add(this.brailtext);
            this.panel2.Location = new System.Drawing.Point(7, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 383);
            this.panel2.TabIndex = 22;
            // 
            // gbPERI
            // 
            this.gbPERI.AutoSize = true;
            this.gbPERI.BackColor = System.Drawing.Color.White;
            this.gbPERI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPERI.Location = new System.Drawing.Point(444, 59);
            this.gbPERI.Name = "gbPERI";
            this.gbPERI.Padding = new System.Windows.Forms.Padding(3);
            this.gbPERI.Size = new System.Drawing.Size(234, 29);
            this.gbPERI.TabIndex = 15;
            this.gbPERI.Text = "Perimeter of the Circle is";
            // 
            // ans
            // 
            this.ans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ans.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.Location = new System.Drawing.Point(686, 51);
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
            this.label15.Location = new System.Drawing.Point(792, 59);
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
            this.label18.Location = new System.Drawing.Point(519, 179);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(3);
            this.label18.Size = new System.Drawing.Size(267, 34);
            this.label18.TabIndex = 17;
            this.label18.Text = "Perimeter Value in Braile";
            // 
            // brailtext
            // 
            this.brailtext.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brailtext.Location = new System.Drawing.Point(458, 236);
            this.brailtext.Multiline = true;
            this.brailtext.Name = "brailtext";
            this.brailtext.Size = new System.Drawing.Size(398, 84);
            this.brailtext.TabIndex = 14;
            this.brailtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rec
            // 
            this.rec.BackColor = System.Drawing.Color.Transparent;
            this.rec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rec.Controls.Add(this.cirtext);
            this.rec.Controls.Add(this.label23);
            this.rec.Controls.Add(this.label17);
            this.rec.Controls.Add(this.cirbutton);
            this.rec.Controls.Add(this.label22);
            this.rec.Location = new System.Drawing.Point(355, 30);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(670, 337);
            this.rec.TabIndex = 26;
            // 
            // cirtext
            // 
            this.cirtext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cirtext.Location = new System.Drawing.Point(291, 136);
            this.cirtext.Name = "cirtext";
            this.cirtext.Size = new System.Drawing.Size(244, 30);
            this.cirtext.TabIndex = 12;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(206, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(284, 47);
            this.label23.TabIndex = 2;
            this.label23.Text = "Enter Radius";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(541, 135);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(3);
            this.label17.Size = new System.Drawing.Size(50, 33);
            this.label17.TabIndex = 9;
            this.label17.Text = "cm";
            // 
            // cirbutton
            // 
            this.cirbutton.BackColor = System.Drawing.Color.MediumPurple;
            this.cirbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cirbutton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cirbutton.Location = new System.Drawing.Point(272, 249);
            this.cirbutton.Name = "cirbutton";
            this.cirbutton.Padding = new System.Windows.Forms.Padding(3);
            this.cirbutton.Size = new System.Drawing.Size(113, 42);
            this.cirbutton.TabIndex = 2;
            this.cirbutton.Text = "Enter";
            this.cirbutton.UseVisualStyleBackColor = false;
            this.cirbutton.Click += new System.EventHandler(this.recbutton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.MediumPurple;
            this.label22.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(87, 135);
            this.label22.Name = "label22";
            this.label22.Padding = new System.Windows.Forms.Padding(3);
            this.label22.Size = new System.Drawing.Size(97, 33);
            this.label22.TabIndex = 3;
            this.label22.Text = "Radius";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1232, 315);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 31;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 17);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(113, 42);
            this.button2.TabIndex = 32;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cirUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rec);
            this.Name = "cirUC";
            this.Size = new System.Drawing.Size(1449, 875);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.rec.ResumeLayout(false);
            this.rec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label gbPERI;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox brailtext;
        private System.Windows.Forms.Panel rec;
        private System.Windows.Forms.TextBox cirtext;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button cirbutton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
