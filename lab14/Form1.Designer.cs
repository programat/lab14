namespace lab14
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
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.String_box = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Status_box = new System.Windows.Forms.TextBox();
            this.Pr_level_box = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Error_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(122, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(711, 322);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Built tree from text box";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // String_box
            // 
            this.String_box.Location = new System.Drawing.Point(122, 8);
            this.String_box.Margin = new System.Windows.Forms.Padding(2);
            this.String_box.Name = "String_box";
            this.String_box.Size = new System.Drawing.Size(712, 20);
            this.String_box.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 97);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "Modify tree";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Status_box
            // 
            this.Status_box.Location = new System.Drawing.Point(8, 159);
            this.Status_box.Margin = new System.Windows.Forms.Padding(2);
            this.Status_box.Name = "Status_box";
            this.Status_box.ReadOnly = true;
            this.Status_box.Size = new System.Drawing.Size(99, 20);
            this.Status_box.TabIndex = 7;
            // 
            // Pr_level_box
            // 
            this.Pr_level_box.Location = new System.Drawing.Point(8, 188);
            this.Pr_level_box.Margin = new System.Windows.Forms.Padding(2);
            this.Pr_level_box.Multiline = true;
            this.Pr_level_box.Name = "Pr_level_box";
            this.Pr_level_box.ReadOnly = true;
            this.Pr_level_box.Size = new System.Drawing.Size(99, 48);
            this.Pr_level_box.TabIndex = 8;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(8, 248);
            this.Save_button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(98, 28);
            this.Save_button.TabIndex = 9;
            this.Save_button.Text = "Save Tree to file";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Error_box
            // 
            this.Error_box.ForeColor = System.Drawing.Color.Crimson;
            this.Error_box.Location = new System.Drawing.Point(8, 8);
            this.Error_box.Margin = new System.Windows.Forms.Padding(2);
            this.Error_box.Name = "Error_box";
            this.Error_box.Size = new System.Drawing.Size(111, 20);
            this.Error_box.TabIndex = 10;
            this.Error_box.Text = "некорректный ввод";
            this.Error_box.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 375);
            this.Controls.Add(this.Error_box);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Pr_level_box);
            this.Controls.Add(this.Status_box);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.String_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox String_box;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox Status_box;
        private System.Windows.Forms.TextBox Pr_level_box;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox Error_box;
    }
}