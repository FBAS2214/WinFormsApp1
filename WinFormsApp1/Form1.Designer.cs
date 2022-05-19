namespace WinFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clickMe = new System.Windows.Forms.Button();
            this.btn_Dispose = new System.Windows.Forms.Button();
            this.btn_Image = new System.Windows.Forms.Button();
            this.button_box = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // btn_clickMe
            // 
            this.btn_clickMe.AutoSize = true;
            this.btn_clickMe.Font = new System.Drawing.Font("Sitka Heading", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clickMe.Location = new System.Drawing.Point(607, 37);
            this.btn_clickMe.Name = "btn_clickMe";
            this.btn_clickMe.Size = new System.Drawing.Size(200, 100);
            this.btn_clickMe.TabIndex = 2;
            this.btn_clickMe.Text = "Click Me";
            this.btn_clickMe.UseVisualStyleBackColor = true;
            this.btn_clickMe.Click += new System.EventHandler(this.btn_clickMe_Click);
            // 
            // btn_Dispose
            // 
            this.btn_Dispose.AutoSize = true;
            this.btn_Dispose.Font = new System.Drawing.Font("Vineta BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Dispose.Location = new System.Drawing.Point(347, 232);
            this.btn_Dispose.Name = "btn_Dispose";
            this.btn_Dispose.Size = new System.Drawing.Size(187, 46);
            this.btn_Dispose.TabIndex = 3;
            this.btn_Dispose.Text = "Dispose";
            this.btn_Dispose.UseVisualStyleBackColor = true;
            this.btn_Dispose.Click += new System.EventHandler(this.btn_Dispose_Click);
            // 
            // btn_Image
            // 
            this.btn_Image.AutoSize = true;
            this.btn_Image.Font = new System.Drawing.Font("Vineta BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Image.Location = new System.Drawing.Point(347, 404);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(239, 46);
            this.btn_Image.TabIndex = 5;
            this.btn_Image.Text = "Get Image";
            this.btn_Image.UseVisualStyleBackColor = true;
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // button_box
            // 
            this.button_box.AutoSize = true;
            this.button_box.Font = new System.Drawing.Font("Vineta BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_box.Location = new System.Drawing.Point(504, 599);
            this.button_box.Name = "button_box";
            this.button_box.Size = new System.Drawing.Size(284, 46);
            this.button_box.TabIndex = 6;
            this.button_box.Text = "MessageBox";
            this.button_box.UseVisualStyleBackColor = true;
            this.button_box.Click += new System.EventHandler(this.button_box_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 759);
            this.Controls.Add(this.button_box);
            this.Controls.Add(this.btn_Image);
            this.Controls.Add(this.btn_Dispose);
            this.Controls.Add(this.btn_clickMe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_clickMe;
        private Button btn_Dispose;
        private Button btn_Image;
        private Button button_box;
    }
}