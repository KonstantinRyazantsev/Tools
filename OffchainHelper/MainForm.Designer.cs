namespace OffchainHelper
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textGeneratedPrivateKey = new System.Windows.Forms.TextBox();
            this.lPrivateKey = new System.Windows.Forms.Label();
            this.bGenerate = new System.Windows.Forms.Button();
            this.textWordList = new System.Windows.Forms.TextBox();
            this.lWordList = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textPrivateAddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 276);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textPrivateAddr);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textGeneratedPrivateKey);
            this.tabPage1.Controls.Add(this.lPrivateKey);
            this.tabPage1.Controls.Add(this.bGenerate);
            this.tabPage1.Controls.Add(this.textWordList);
            this.tabPage1.Controls.Add(this.lWordList);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Key Generation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textGeneratedPrivateKey
            // 
            this.textGeneratedPrivateKey.Location = new System.Drawing.Point(119, 124);
            this.textGeneratedPrivateKey.Name = "textGeneratedPrivateKey";
            this.textGeneratedPrivateKey.ReadOnly = true;
            this.textGeneratedPrivateKey.Size = new System.Drawing.Size(586, 22);
            this.textGeneratedPrivateKey.TabIndex = 4;
            // 
            // lPrivateKey
            // 
            this.lPrivateKey.AutoSize = true;
            this.lPrivateKey.Location = new System.Drawing.Point(34, 124);
            this.lPrivateKey.Name = "lPrivateKey";
            this.lPrivateKey.Size = new System.Drawing.Size(84, 17);
            this.lPrivateKey.TabIndex = 3;
            this.lPrivateKey.Text = "Private Key:";
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(617, 86);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(88, 29);
            this.bGenerate.TabIndex = 2;
            this.bGenerate.Text = "Generate";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // textWordList
            // 
            this.textWordList.Location = new System.Drawing.Point(80, 6);
            this.textWordList.Multiline = true;
            this.textWordList.Name = "textWordList";
            this.textWordList.Size = new System.Drawing.Size(625, 73);
            this.textWordList.TabIndex = 1;
            // 
            // lWordList
            // 
            this.lWordList.AutoSize = true;
            this.lWordList.Location = new System.Drawing.Point(6, 3);
            this.lWordList.Name = "lWordList";
            this.lWordList.Size = new System.Drawing.Size(68, 17);
            this.lWordList.TabIndex = 0;
            this.lWordList.Text = "Word List";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Commitment Signing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textPrivateAddr
            // 
            this.textPrivateAddr.Location = new System.Drawing.Point(119, 154);
            this.textPrivateAddr.Name = "textPrivateAddr";
            this.textPrivateAddr.ReadOnly = true;
            this.textPrivateAddr.Size = new System.Drawing.Size(586, 22);
            this.textPrivateAddr.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Private Address:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 300);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "OffchainHelper";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textGeneratedPrivateKey;
        private System.Windows.Forms.Label lPrivateKey;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.TextBox textWordList;
        private System.Windows.Forms.Label lWordList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textPrivateAddr;
        private System.Windows.Forms.Label label1;
    }
}

