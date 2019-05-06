namespace Game1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtPlayerLog = new System.Windows.Forms.TextBox();
            this.txtMonster = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "史萊姆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlayerLog
            // 
            this.txtPlayerLog.Location = new System.Drawing.Point(76, 12);
            this.txtPlayerLog.Multiline = true;
            this.txtPlayerLog.Name = "txtPlayerLog";
            this.txtPlayerLog.Size = new System.Drawing.Size(206, 238);
            this.txtPlayerLog.TabIndex = 3;
            // 
            // txtMonster
            // 
            this.txtMonster.Location = new System.Drawing.Point(386, 12);
            this.txtMonster.Multiline = true;
            this.txtMonster.Name = "txtMonster";
            this.txtMonster.Size = new System.Drawing.Size(194, 238);
            this.txtMonster.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMonster);
            this.Controls.Add(this.txtPlayerLog);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPlayerLog;
        private System.Windows.Forms.TextBox txtMonster;
        private System.Windows.Forms.Button button2;
    }
}

