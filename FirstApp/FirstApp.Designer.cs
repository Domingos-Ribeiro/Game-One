namespace FirstApp
{
    partial class FirstApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstApp));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.pic_Title = new System.Windows.Forms.PictureBox();
            this.btn_Welcome = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Title)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(197, 46);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(253, 25);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Welcome to my First App";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(243, 91);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(161, 20);
            this.txt_UserName.TabIndex = 1;
            // 
            // pic_Title
            // 
            this.pic_Title.Image = ((System.Drawing.Image)(resources.GetObject("pic_Title.Image")));
            this.pic_Title.Location = new System.Drawing.Point(71, 169);
            this.pic_Title.Name = "pic_Title";
            this.pic_Title.Size = new System.Drawing.Size(505, 172);
            this.pic_Title.TabIndex = 2;
            this.pic_Title.TabStop = false;
            // 
            // btn_Welcome
            // 
            this.btn_Welcome.Location = new System.Drawing.Point(286, 410);
            this.btn_Welcome.Name = "btn_Welcome";
            this.btn_Welcome.Size = new System.Drawing.Size(75, 23);
            this.btn_Welcome.TabIndex = 3;
            this.btn_Welcome.Text = "Welcome";
            this.btn_Welcome.UseVisualStyleBackColor = true;
            this.btn_Welcome.Click += new System.EventHandler(this.btn_Welcome_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(286, 466);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // FirstApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(634, 546);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Welcome);
            this.Controls.Add(this.pic_Title);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_Title);
            this.Name = "FirstApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First App";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.PictureBox pic_Title;
        private System.Windows.Forms.Button btn_Welcome;
        private System.Windows.Forms.Button btn_Exit;
    }
}

