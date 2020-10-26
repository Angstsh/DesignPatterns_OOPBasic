namespace ObjectOriented
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCatShout = new System.Windows.Forms.Button();
            this.btnDogshout = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCatShout
            // 
            this.btnCatShout.Location = new System.Drawing.Point(74, 35);
            this.btnCatShout.Name = "btnCatShout";
            this.btnCatShout.Size = new System.Drawing.Size(99, 35);
            this.btnCatShout.TabIndex = 0;
            this.btnCatShout.Text = "猫叫";
            this.btnCatShout.UseVisualStyleBackColor = true;
            this.btnCatShout.Click += new System.EventHandler(this.btnCatShout_Click);
            // 
            // btnDogshout
            // 
            this.btnDogshout.Location = new System.Drawing.Point(74, 76);
            this.btnDogshout.Name = "btnDogshout";
            this.btnDogshout.Size = new System.Drawing.Size(99, 32);
            this.btnDogshout.TabIndex = 1;
            this.btnDogshout.Text = "狗叫";
            this.btnDogshout.UseVisualStyleBackColor = true;
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(74, 114);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(99, 34);
            this.btnSignup.TabIndex = 2;
            this.btnSignup.Text = "动物报名";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(74, 154);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(99, 36);
            this.btnMatch.TabIndex = 3;
            this.btnMatch.Text = "叫声比赛";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(74, 196);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(99, 30);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "变出东西";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnDogshout);
            this.Controls.Add(this.btnCatShout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatShout;
        private System.Windows.Forms.Button btnDogshout;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnChange;
    }
}

