using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TKU_course_release
{
    public partial class TKUCourse : Form
    {
        Boolean BrowserWait = false;
        Boolean BrowserChange = false;
        Boolean ApplicationClose = false;
        string String_Web = "";
        public TKUCourse()
        {
            InitializeComponent();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString() != webBrowser.Url.ToString())
                return;
            if (webBrowser.ReadyState != WebBrowserReadyState.Complete)
                return;
            if (BrowserWait == false)
                return;
            if (BrowserWait == true) String_Web = webBrowser.Document.Body.InnerText;
            BrowserChange = true;
            BrowserWait = false;
        }

        private void BrowserLoading()
        {
            while (BrowserWait != false && ApplicationClose != true)
                Application.DoEvents();
            BrowserWait = true;
            while (BrowserChange == false && ApplicationClose != true)
                Application.DoEvents();
            BrowserChange = false;
            if (ApplicationClose == true) Application.Exit();
        }

        private void CheckBox_VisiblePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_VisiblePassword.Checked == true) textBox_StuPWD.UseSystemPasswordChar = false;
            else textBox_StuPWD.UseSystemPasswordChar = true;
        }

        private void TKUCourse_Load(object sender, EventArgs e)
        {     
            comboBox_URL.SelectedIndex = 0;
            radioButton_Normal.Checked = true;
            webBrowser.Navigate(comboBox_URL.Text);
            if (MessageBox.Show("This program only provides ease of enrollment, developer for not assume any responsibility for the following conditions:\n1. Any error when using this program (including the program crashes, the school system revision, etc.).\n2. The use of any improper use.\n3. The breakdown of the above statements since many developers retain the final interpretation.\n＊ If you click \"Yes\" and use it means that you have agreed to the above specification or else click \"No\" to exit the application.", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) Close();
            MessageBox.Show("This application version : 1.1\nMake sure to check the latest version from the following URL http://tkucourseapplication.souceforge.net", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Normal_Mode()
        {
            string String_Result = "";
            Boolean FinishState = false;

            webBrowser.Navigate(comboBox_URL.Text);
            BrowserLoading();
            while (FinishState == false)
            {
                try
                {
                    do
                    {
                        webBrowser.Document.Body.All["txtStuNo"].InnerText = textBox_StuID.Text;
                        webBrowser.Document.Body.All["txtPSWD"].InnerText = textBox_StuPWD.Text;
                        webBrowser.Document.GetElementById("btnLogin").InvokeMember("click");
                        BrowserLoading();
                    } while (String_Web.IndexOf("「淡江大學個人化入口網」", 0) != -1);

                    char[] charsToTrim = { ' ', '\n', '#' };
                    string[] region = textBox_CourseCode.Text.Split(',', '\n');
                    foreach (string s_1 in region)
                    {
                        if (s_1.Trim() == "")
                            continue;
                        string[] Course = s_1.Split('>', ' ');
                        foreach (string Code in Course)
                        {
                            if (Code.Trim() == "")
                                break;
                            if (Code.IndexOf("#") == -1)
                            {
                                webBrowser.Document.Body.All["txtCosEleSeq"].InnerText = Code.Trim();
                                webBrowser.Document.GetElementById("btnAdd").InvokeMember("click");
                                BrowserLoading();
                                if (String_Web.IndexOf("I000", 0) != -1)
                                {
                                    String_Result = String_Result + "No. " + Code.Trim() + " add successfully!!\n";
                                    break;
                                }
                                else
                                    String_Result = String_Result + "No. " + Code.Trim() + " add failed!!\n";
                            }
                            else
                            {
                                webBrowser.Document.Body.All["txtCosEleSeq"].InnerText = Code.Trim(charsToTrim).Trim();
                                webBrowser.Document.GetElementById("btnDel").InvokeMember("click");
                                BrowserLoading();
                                String_Result = String_Result + "No. " + Code.Trim(charsToTrim) + " drop!!\n";
                            }
                        }
                    }
                    FinishState = true;
                }
                catch (Exception error)
                {
                    webBrowser.Navigate(comboBox_URL.Text);
                    BrowserLoading();
                }
            }
            MessageBox.Show(String_Result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Loop_Mode()
        {
            string String_Result = "";
            int count;

            webBrowser.Navigate(comboBox_URL.Text);
            BrowserLoading();
            while(true)
            {
                try
                {
                    do{
                        webBrowser.Document.Body.All["txtStuNo"].InnerText = textBox_StuID.Text;
                        webBrowser.Document.Body.All["txtPSWD"].InnerText = textBox_StuPWD.Text;
                        webBrowser.Document.GetElementById("btnLogin").InvokeMember("click");
                        BrowserLoading();
                    } while (String_Web.IndexOf("「淡江大學個人化入口網」", 0) != -1);
                    count = 0;
                    while(true)
                    {
                        string[] Code = textBox_CourseCode.Text.Split(',','\n');
                        foreach (string s in Code)
                        {
                            if (s.Trim() == "")
                                continue;
                            webBrowser.Document.Body.All["txtCosEleSeq"].InnerText = s.Trim();
                            webBrowser.Document.GetElementById("btnAdd").InvokeMember("click");
                            BrowserLoading();
                            count++;
//                            if (String_Web.IndexOf("I000", 0) != -1)
//                            {
//                                String_Result = String_Result + "No. " + s.Trim() + " add successfully!!\n";
//                                break;
//                            }
                            if (count >= 30)
                            {
                                webBrowser.Document.GetElementById("btnLogout").InvokeMember("click");
                                BrowserLoading();
                                break;
                            }
                        }
                        if(count >= 30)
                        {
                            count = 0;
                            break;
                        }
                    }
                } 
                catch(Exception error)
                {
                    webBrowser.Navigate(comboBox_URL.Text);
                    BrowserLoading();
                }
            }
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            int Int_RegionCount=1;
            string String_CourseAnalysis="";
            if (radioButton_Normal.Checked)
            {
                char[] charsToTrim = {' ','\n', '#' };
                string[] region = textBox_CourseCode.Text.Split(',', '\n');
                String_CourseAnalysis = "The analysis of your code (Normal mode) :\n";
                foreach (string s_1 in region)
                {
                    
                    if (s_1.Trim() == "")
                        continue;
                    String_CourseAnalysis = String_CourseAnalysis + "\nR" + Int_RegionCount++ + " : ";
                    string[] Course = s_1.Split('>', ' ');
                    foreach (string Code in Course)
                    {
                        if (Code.Trim() == "")
                            break;
                        if (Code.IndexOf("#") == -1)
                        {
                            String_CourseAnalysis = String_CourseAnalysis + "Add:" + Code.Trim() + ", ";
                        }
                        else
                        {
                            String_CourseAnalysis = String_CourseAnalysis + "Drop:" + Code.Trim(charsToTrim).Trim() + ", ";
                        }
                    }
                }
                String_CourseAnalysis = String_CourseAnalysis + "\n\nIf it is correct, please click \"Yes\" to run the application, or else click \"NO\" to modify your code!!";
                if (MessageBox.Show(String_CourseAnalysis, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No) return;
                Button_Start.Enabled = false;
                textBox_StuID.Enabled = false;
                textBox_StuPWD.Enabled = false;
                CheckBox_VisiblePassword.Enabled = false;
                groupBox_Mode.Enabled = false;
                CheckBox_VisiblePassword.Enabled = false;
                comboBox_URL.Enabled = false;
                textBox_CourseCode.Enabled = false;
                button_FAQ.Enabled = false;
                Normal_Mode();
            }
            else
            {
                string[] region = textBox_CourseCode.Text.Split(',', '\n');
                String_CourseAnalysis = "The analysis of your code (Loop mode) :\n\n";
                foreach (string s_1 in region)
                {
                    if (s_1.Trim() == "")
                        continue;
                    String_CourseAnalysis = String_CourseAnalysis + "Add:" + s_1.Trim() + "\n";
                }
                String_CourseAnalysis = String_CourseAnalysis + "\n\nIf it is correct, please click \"Yes\" to run the application, or else click \"NO\" to modify your code!!";
                if (MessageBox.Show(String_CourseAnalysis, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No) return;
                Button_Start.Enabled = false;
                textBox_StuID.Enabled = false;
                textBox_StuPWD.Enabled = false;
                CheckBox_VisiblePassword.Enabled = false;
                groupBox_Mode.Enabled = false;
                CheckBox_VisiblePassword.Enabled = false;
                comboBox_URL.Enabled = false;
                textBox_CourseCode.Enabled = false;
                button_FAQ.Enabled = false;
                Loop_Mode();
            }
                



        }

        private void comboBox_URL_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser.Navigate(comboBox_URL.Text);
        }

        private void TKUCourse_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationClose = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_URL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void textBox_StuID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > '9' || e.KeyChar < '0' && e.KeyChar != '\b')
                e.Handled = true;
            return;
        }

        private void button_FAQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please use “>”, “#” and ”,” these symbols to separate your course codes.\n※“,” is your region divide symbol\n※“>” is your order divide symbol\n※“#” is drop course symbol, should be used at the beginning of the course code, be extra careful using this!!\n\nInput example : 0000>1111>2222,#3333,4444,5555>6666,7777>#8888>9999,1234>#2345>3456\nIf course 0000,4444,5555,6666,7777 are full, the application will execute as fellow :\nAdd 0000 (full, use alternate) \n-> Add 1111(success, jump to the next region)\n->Drop 3333(always drop)\n->Add 4444(full, always add)\n->Add 5555(full, use alternate)\n->Add 6666(full, no alternative just jump to the next region)\n->Add 7777(full, use alternate)\n->Drop 8888(always drop and use next alternate)\n->Add 9999(success, jump to the next)\n->Add 1234(success, jump to the next)\n-> end(no next region)", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
