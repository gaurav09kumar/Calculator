namespace Calculator
{
    partial class btn_register
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
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_courses_list = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.trainers_list = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_select_file = new System.Windows.Forms.Button();
            this.ofd_select_file = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello Welcome to Windows Forms";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(216, 85);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 1;
            this.userName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(216, 112);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cb_courses_list
            // 
            this.cb_courses_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_courses_list.FormattingEnabled = true;
            this.cb_courses_list.Items.AddRange(new object[] {
            "C#",
            "C",
            "Java",
            "Python",
            "VC",
            "VB"});
            this.cb_courses_list.Location = new System.Drawing.Point(173, 195);
            this.cb_courses_list.Name = "cb_courses_list";
            this.cb_courses_list.Size = new System.Drawing.Size(121, 21);
            this.cb_courses_list.TabIndex = 6;
            this.cb_courses_list.SelectedIndexChanged += new System.EventHandler(this.cb_courses_list_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "RegisterCourse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Courses";
            // 
            // trainers_list
            // 
            this.trainers_list.FormattingEnabled = true;
            this.trainers_list.Items.AddRange(new object[] {
            "ABC",
            "XYZ"});
            this.trainers_list.Location = new System.Drawing.Point(321, 184);
            this.trainers_list.Name = "trainers_list";
            this.trainers_list.Size = new System.Drawing.Size(120, 95);
            this.trainers_list.TabIndex = 9;
            this.trainers_list.SelectedIndexChanged += new System.EventHandler(this.trainers_list_SelectedIndexChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btn_select_file
            // 
            this.btn_select_file.Location = new System.Drawing.Point(194, 293);
            this.btn_select_file.Name = "btn_select_file";
            this.btn_select_file.Size = new System.Drawing.Size(75, 23);
            this.btn_select_file.TabIndex = 10;
            this.btn_select_file.Text = "Select File";
            this.btn_select_file.UseVisualStyleBackColor = true;
            this.btn_select_file.Click += new System.EventHandler(this.btn_select_file_Click);
            // 
            // ofd_select_file
            // 
            this.ofd_select_file.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // btn_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 387);
            this.Controls.Add(this.btn_select_file);
            this.Controls.Add(this.trainers_list);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_courses_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "btn_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_courses_list;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox trainers_list;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_select_file;
        private System.Windows.Forms.OpenFileDialog ofd_select_file;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
    }
}

