namespace TKU_course_release
{
    partial class TKUCourse
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_StuID = new System.Windows.Forms.TextBox();
            this.textBox_StuPWD = new System.Windows.Forms.TextBox();
            this.CheckBox_VisiblePassword = new System.Windows.Forms.CheckBox();
            this.Button_Start = new System.Windows.Forms.Button();
            this.groupBox_Mode = new System.Windows.Forms.GroupBox();
            this.radioButton_Loop = new System.Windows.Forms.RadioButton();
            this.radioButton_Normal = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.comboBox_URL = new System.Windows.Forms.ComboBox();
            this.textBox_CourseCode = new System.Windows.Forms.TextBox();
            this.button_FAQ = new System.Windows.Forms.Button();
            this.groupBox_Mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "StuIDNo. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // textBox_StuID
            // 
            this.textBox_StuID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox_StuID.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_StuID.ForeColor = System.Drawing.Color.White;
            this.textBox_StuID.Location = new System.Drawing.Point(95, 28);
            this.textBox_StuID.MaxLength = 9;
            this.textBox_StuID.Name = "textBox_StuID";
            this.textBox_StuID.Size = new System.Drawing.Size(98, 27);
            this.textBox_StuID.TabIndex = 3;
            this.textBox_StuID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_StuID_KeyPress);
            // 
            // textBox_StuPWD
            // 
            this.textBox_StuPWD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox_StuPWD.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_StuPWD.ForeColor = System.Drawing.Color.White;
            this.textBox_StuPWD.Location = new System.Drawing.Point(95, 67);
            this.textBox_StuPWD.Name = "textBox_StuPWD";
            this.textBox_StuPWD.Size = new System.Drawing.Size(98, 27);
            this.textBox_StuPWD.TabIndex = 4;
            this.textBox_StuPWD.UseSystemPasswordChar = true;
            // 
            // CheckBox_VisiblePassword
            // 
            this.CheckBox_VisiblePassword.AutoSize = true;
            this.CheckBox_VisiblePassword.BackColor = System.Drawing.Color.Black;
            this.CheckBox_VisiblePassword.Font = new System.Drawing.Font("新細明體", 12F);
            this.CheckBox_VisiblePassword.Location = new System.Drawing.Point(201, 75);
            this.CheckBox_VisiblePassword.Name = "CheckBox_VisiblePassword";
            this.CheckBox_VisiblePassword.Size = new System.Drawing.Size(15, 14);
            this.CheckBox_VisiblePassword.TabIndex = 5;
            this.CheckBox_VisiblePassword.UseVisualStyleBackColor = false;
            this.CheckBox_VisiblePassword.CheckedChanged += new System.EventHandler(this.CheckBox_VisiblePassword_CheckedChanged);
            // 
            // Button_Start
            // 
            this.Button_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Start.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Start.Location = new System.Drawing.Point(495, 31);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(88, 40);
            this.Button_Start.TabIndex = 7;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = false;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // groupBox_Mode
            // 
            this.groupBox_Mode.Controls.Add(this.radioButton_Loop);
            this.groupBox_Mode.Controls.Add(this.radioButton_Normal);
            this.groupBox_Mode.ForeColor = System.Drawing.Color.White;
            this.groupBox_Mode.Location = new System.Drawing.Point(10, 112);
            this.groupBox_Mode.Name = "groupBox_Mode";
            this.groupBox_Mode.Size = new System.Drawing.Size(206, 47);
            this.groupBox_Mode.TabIndex = 10;
            this.groupBox_Mode.TabStop = false;
            this.groupBox_Mode.Text = "Mode";
            // 
            // radioButton_Loop
            // 
            this.radioButton_Loop.AutoSize = true;
            this.radioButton_Loop.Location = new System.Drawing.Point(124, 21);
            this.radioButton_Loop.Name = "radioButton_Loop";
            this.radioButton_Loop.Size = new System.Drawing.Size(48, 16);
            this.radioButton_Loop.TabIndex = 9;
            this.radioButton_Loop.TabStop = true;
            this.radioButton_Loop.Text = "Loop";
            this.radioButton_Loop.UseVisualStyleBackColor = true;
            // 
            // radioButton_Normal
            // 
            this.radioButton_Normal.AutoSize = true;
            this.radioButton_Normal.Location = new System.Drawing.Point(23, 21);
            this.radioButton_Normal.Name = "radioButton_Normal";
            this.radioButton_Normal.Size = new System.Drawing.Size(58, 16);
            this.radioButton_Normal.TabIndex = 8;
            this.radioButton_Normal.TabStop = true;
            this.radioButton_Normal.Text = "Normal";
            this.radioButton_Normal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "URL :";
            // 
            // webBrowser
            // 
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(11, 232);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(572, 387);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // comboBox_URL
            // 
            this.comboBox_URL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.comboBox_URL.Font = new System.Drawing.Font("新細明體", 12F);
            this.comboBox_URL.ForeColor = System.Drawing.Color.White;
            this.comboBox_URL.FormattingEnabled = true;
            this.comboBox_URL.Items.AddRange(new object[] {
            "http://www.ais.tku.edu.tw/EleCos/login.aspx",
            "http://163.13.121.35/EleCos/login.aspx",
            "http://163.13.121.36/EleCos/login.aspx",
            "http://163.13.121.37/EleCos/login.aspx",
            "http://163.13.121.38/EleCos/login.aspx",
            "http://www.ais.tku.edu.tw/EleCos_English/loginE.aspx",
            "http://163.13.121.35/EleCos_English/loginE.aspx",
            "http://163.13.121.36/EleCos_English/loginE.aspx",
            "http://163.13.121.37/EleCos_English/loginE.aspx",
            "http://163.13.121.38/EleCos_English/loginE.aspx"});
            this.comboBox_URL.Location = new System.Drawing.Point(57, 192);
            this.comboBox_URL.Name = "comboBox_URL";
            this.comboBox_URL.Size = new System.Drawing.Size(526, 24);
            this.comboBox_URL.TabIndex = 12;
            this.comboBox_URL.SelectedIndexChanged += new System.EventHandler(this.comboBox_URL_SelectedIndexChanged);
            this.comboBox_URL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_URL_KeyPress);
            // 
            // textBox_CourseCode
            // 
            this.textBox_CourseCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox_CourseCode.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_CourseCode.ForeColor = System.Drawing.Color.White;
            this.textBox_CourseCode.Location = new System.Drawing.Point(230, 12);
            this.textBox_CourseCode.Multiline = true;
            this.textBox_CourseCode.Name = "textBox_CourseCode";
            this.textBox_CourseCode.Size = new System.Drawing.Size(250, 172);
            this.textBox_CourseCode.TabIndex = 13;
            // 
            // button_FAQ
            // 
            this.button_FAQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_FAQ.ForeColor = System.Drawing.Color.White;
            this.button_FAQ.Location = new System.Drawing.Point(495, 105);
            this.button_FAQ.Name = "button_FAQ";
            this.button_FAQ.Size = new System.Drawing.Size(88, 44);
            this.button_FAQ.TabIndex = 14;
            this.button_FAQ.Text = "Help";
            this.button_FAQ.UseVisualStyleBackColor = false;
            this.button_FAQ.Click += new System.EventHandler(this.button_FAQ_Click);
            // 
            // TKUCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(604, 648);
            this.Controls.Add(this.button_FAQ);
            this.Controls.Add(this.textBox_CourseCode);
            this.Controls.Add(this.comboBox_URL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox_Mode);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.CheckBox_VisiblePassword);
            this.Controls.Add(this.textBox_StuPWD);
            this.Controls.Add(this.textBox_StuID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TKUCourse";
            this.Text = "TKU Course (v1.1)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TKUCourse_FormClosing);
            this.Load += new System.EventHandler(this.TKUCourse_Load);
            this.groupBox_Mode.ResumeLayout(false);
            this.groupBox_Mode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_StuID;
        private System.Windows.Forms.TextBox textBox_StuPWD;
        private System.Windows.Forms.CheckBox CheckBox_VisiblePassword;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.GroupBox groupBox_Mode;
        private System.Windows.Forms.RadioButton radioButton_Loop;
        private System.Windows.Forms.RadioButton radioButton_Normal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ComboBox comboBox_URL;
        private System.Windows.Forms.TextBox textBox_CourseCode;
        private System.Windows.Forms.Button button_FAQ;
    }
}

