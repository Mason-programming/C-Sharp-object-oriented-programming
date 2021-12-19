
namespace HW_6_ch12
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.weighrsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killogramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouncesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 40);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weighrsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(899, 40);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // weighrsToolStripMenuItem
            // 
            this.weighrsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gramsToolStripMenuItem,
            this.killogramsToolStripMenuItem,
            this.poundsToolStripMenuItem,
            this.ouncesToolStripMenuItem});
            this.weighrsToolStripMenuItem.Name = "weighrsToolStripMenuItem";
            this.weighrsToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.weighrsToolStripMenuItem.Text = "Weights";
            this.weighrsToolStripMenuItem.Click += new System.EventHandler(this.weighrsToolStripMenuItem_Click);
            // 
            // gramsToolStripMenuItem
            // 
            this.gramsToolStripMenuItem.Name = "gramsToolStripMenuItem";
            this.gramsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.gramsToolStripMenuItem.Text = "Grams";
            this.gramsToolStripMenuItem.Click += new System.EventHandler(this.gramsToolStripMenuItem_Click);
            // 
            // killogramsToolStripMenuItem
            // 
            this.killogramsToolStripMenuItem.Name = "killogramsToolStripMenuItem";
            this.killogramsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.killogramsToolStripMenuItem.Text = "kilograms";
            this.killogramsToolStripMenuItem.Click += new System.EventHandler(this.killogramsToolStripMenuItem_Click);
            // 
            // poundsToolStripMenuItem
            // 
            this.poundsToolStripMenuItem.Name = "poundsToolStripMenuItem";
            this.poundsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.poundsToolStripMenuItem.Text = "pounds";
            this.poundsToolStripMenuItem.Click += new System.EventHandler(this.poundsToolStripMenuItem_Click);
            // 
            // ouncesToolStripMenuItem
            // 
            this.ouncesToolStripMenuItem.Name = "ouncesToolStripMenuItem";
            this.ouncesToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.ouncesToolStripMenuItem.Text = "ounces.";
            this.ouncesToolStripMenuItem.Click += new System.EventHandler(this.ouncesToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(186, 190);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(552, 326);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 39);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter weight in pounds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem weighrsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killogramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouncesToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

