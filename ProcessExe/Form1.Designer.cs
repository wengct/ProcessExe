namespace ProcessExe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.filePath = new System.Windows.Forms.TextBox();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.startExe = new System.Windows.Forms.Button();
            this.domain = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Argu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClearResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filePath
            // 
            this.filePath.Font = new System.Drawing.Font("Calibri", 9F);
            this.filePath.Location = new System.Drawing.Point(12, 12);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(446, 22);
            this.filePath.TabIndex = 0;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(465, 10);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 1;
            this.openFileBtn.Text = "瀏覽檔案";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(13, 116);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result.Size = new System.Drawing.Size(527, 165);
            this.result.TabIndex = 2;
            // 
            // startExe
            // 
            this.startExe.Location = new System.Drawing.Point(465, 39);
            this.startExe.Name = "startExe";
            this.startExe.Size = new System.Drawing.Size(75, 23);
            this.startExe.TabIndex = 3;
            this.startExe.Text = "執行";
            this.startExe.UseVisualStyleBackColor = true;
            this.startExe.Click += new System.EventHandler(this.startExe_Click);
            // 
            // domain
            // 
            this.domain.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domain.Location = new System.Drawing.Point(51, 39);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(100, 22);
            this.domain.TabIndex = 4;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Calibri", 9F);
            this.userName.Location = new System.Drawing.Point(204, 39);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 22);
            this.userName.TabIndex = 5;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Calibri", 9F);
            this.password.Location = new System.Drawing.Point(357, 39);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 22);
            this.password.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "網域";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "帳號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "密碼";
            // 
            // Argu
            // 
            this.Argu.Location = new System.Drawing.Point(51, 68);
            this.Argu.Name = "Argu";
            this.Argu.Size = new System.Drawing.Size(406, 22);
            this.Argu.TabIndex = 10;
            this.Argu.Enter += new System.EventHandler(this.Argu_Enter);
            this.Argu.Leave += new System.EventHandler(this.Argu_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "參數";
            // 
            // btnClearResult
            // 
            this.btnClearResult.Location = new System.Drawing.Point(465, 90);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(75, 23);
            this.btnClearResult.TabIndex = 12;
            this.btnClearResult.Text = "清除結果";
            this.btnClearResult.UseVisualStyleBackColor = true;
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 295);
            this.Controls.Add(this.btnClearResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Argu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.startExe);
            this.Controls.Add(this.result);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.filePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ProcessExe v2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button startExe;
        private System.Windows.Forms.TextBox domain;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Argu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClearResult;
    }
}

