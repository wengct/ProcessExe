using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessExe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.filePath.Text = file.FileName;
        }

        private void startExe_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.filePath.Text) || Path.GetExtension(this.filePath.Text).ToUpper() != ".EXE")
                {
                    writeResult("請選擇EXE類型檔案");
                    return;
                }
                string processName = Path.GetFileName(this.filePath.Text);
                Process p = new Process();
                p.StartInfo.FileName = this.filePath.Text;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                if (!string.IsNullOrEmpty(this.domain.Text) && !string.IsNullOrEmpty(this.userName.Text) && !string.IsNullOrEmpty(this.password.Text))
                {
                    p.StartInfo.Domain = this.domain.Text;
                    p.StartInfo.UserName = this.userName.Text;
                    var secure = new SecureString();
                    foreach (char c in this.password.Text)
                    {
                        secure.AppendChar(c);
                    }
                    p.StartInfo.Password = secure;
                }
                string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                writeResult(now + "-[" + processName + "]開始執行...");
                writeResult(now + "-[" + processName + "]參數：" + Argu.Text);
                p.StartInfo.Arguments = Argu.Text;
                p.Start();
                p.WaitForExit();
                writeResult(p.StandardOutput.ReadToEnd());
                writeResult(now + "-[" + processName + "]執行結束...");
                writeResult(now + "-[" + processName + "]應用程式結束代碼：" + p.ExitCode.ToString());
                writeResult("------------------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                writeResult(ex.Message);
                if (ex.InnerException != null && !String.IsNullOrEmpty(ex.InnerException.Message))
                {
                    writeResult(ex.InnerException.Message);
                }
                writeResult(ex.StackTrace);
            }
        }

        private void writeResult(string s)
        {
            if (String.IsNullOrEmpty(this.result.Text))
            {
                this.result.AppendText(s);
            }
            else
            {
                this.result.AppendText(Environment.NewLine);
                this.result.AppendText(s);
            }
        }

        private void Argu_Enter(object sender, EventArgs e)
        {
            string tip = "例：a B c，參數之前請用空格區隔，如單一參數有空白，則請將此參數使用雙引號包住，例a \"b c\" d";
            toolTip1 = new ToolTip();
            toolTip1.InitialDelay = 0;
            toolTip1.IsBalloon = true;
            toolTip1.ShowAlways = true;
            toolTip1.Show(string.Empty, Argu);
            toolTip1.Show(tip, Argu, 0);
        }

        private void Argu_Leave(object sender, EventArgs e)
        {
            toolTip1.Dispose();
        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            result.Text = string.Empty;
        }
    }
}
