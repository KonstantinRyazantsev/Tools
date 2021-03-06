﻿namespace OffchainHelper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textPrivateAddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textGeneratedPrivateKey = new System.Windows.Forms.TextBox();
            this.lPrivateKey = new System.Windows.Forms.Label();
            this.bGenerate = new System.Windows.Forms.Button();
            this.textWordList = new System.Windows.Forms.TextBox();
            this.lWordList = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelCommitmentToSign = new System.Windows.Forms.Label();
            this.textCommitmentToSign = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPrivateKey = new System.Windows.Forms.TextBox();
            this.buttonSign = new System.Windows.Forms.Button();
            this.textSignedTransaction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTxId = new System.Windows.Forms.Label();
            this.textBoxFeeTransactionId = new System.Windows.Forms.TextBox();
            this.labelOutputNumber = new System.Windows.Forms.Label();
            this.textBoxFeeOutputNumber = new System.Windows.Forms.TextBox();
            this.toolTipCommitment = new System.Windows.Forms.ToolTip(this.components);
            this.labelFeePrivateKey = new System.Windows.Forms.Label();
            this.textFeePrivateKey = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 460);
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
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textSignedTransaction);
            this.tabPage2.Controls.Add(this.buttonSign);
            this.tabPage2.Controls.Add(this.textPrivateKey);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textCommitmentToSign);
            this.tabPage2.Controls.Add(this.labelCommitmentToSign);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Commitment Signing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelCommitmentToSign
            // 
            this.labelCommitmentToSign.AutoSize = true;
            this.labelCommitmentToSign.Location = new System.Drawing.Point(6, 3);
            this.labelCommitmentToSign.Name = "labelCommitmentToSign";
            this.labelCommitmentToSign.Size = new System.Drawing.Size(142, 17);
            this.labelCommitmentToSign.TabIndex = 0;
            this.labelCommitmentToSign.Text = "Commitment To Sign:";
            // 
            // textCommitmentToSign
            // 
            this.textCommitmentToSign.Location = new System.Drawing.Point(154, 6);
            this.textCommitmentToSign.Multiline = true;
            this.textCommitmentToSign.Name = "textCommitmentToSign";
            this.textCommitmentToSign.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textCommitmentToSign.Size = new System.Drawing.Size(551, 89);
            this.textCommitmentToSign.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Private Key:";
            // 
            // textPrivateKey
            // 
            this.textPrivateKey.Location = new System.Drawing.Point(154, 101);
            this.textPrivateKey.Name = "textPrivateKey";
            this.textPrivateKey.Size = new System.Drawing.Size(551, 22);
            this.textPrivateKey.TabIndex = 3;
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(630, 238);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(75, 28);
            this.buttonSign.TabIndex = 4;
            this.buttonSign.Text = "&Sign";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // textSignedTransaction
            // 
            this.textSignedTransaction.Location = new System.Drawing.Point(154, 272);
            this.textSignedTransaction.Multiline = true;
            this.textSignedTransaction.Name = "textSignedTransaction";
            this.textSignedTransaction.ReadOnly = true;
            this.textSignedTransaction.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textSignedTransaction.Size = new System.Drawing.Size(551, 148);
            this.textSignedTransaction.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Signed Commiment:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textFeePrivateKey);
            this.groupBox1.Controls.Add(this.labelFeePrivateKey);
            this.groupBox1.Controls.Add(this.textBoxFeeOutputNumber);
            this.groupBox1.Controls.Add(this.labelOutputNumber);
            this.groupBox1.Controls.Add(this.textBoxFeeTransactionId);
            this.groupBox1.Controls.Add(this.labelTxId);
            this.groupBox1.Location = new System.Drawing.Point(9, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fee";
            // 
            // labelTxId
            // 
            this.labelTxId.AutoSize = true;
            this.labelTxId.Location = new System.Drawing.Point(7, 22);
            this.labelTxId.Name = "labelTxId";
            this.labelTxId.Size = new System.Drawing.Size(104, 17);
            this.labelTxId.TabIndex = 0;
            this.labelTxId.Text = "Transaction ID:";
            // 
            // textBoxFeeTransactionId
            // 
            this.textBoxFeeTransactionId.Location = new System.Drawing.Point(113, 22);
            this.textBoxFeeTransactionId.Name = "textBoxFeeTransactionId";
            this.textBoxFeeTransactionId.Size = new System.Drawing.Size(322, 22);
            this.textBoxFeeTransactionId.TabIndex = 1;
            // 
            // labelOutputNumber
            // 
            this.labelOutputNumber.AutoSize = true;
            this.labelOutputNumber.Location = new System.Drawing.Point(442, 26);
            this.labelOutputNumber.Name = "labelOutputNumber";
            this.labelOutputNumber.Size = new System.Drawing.Size(105, 17);
            this.labelOutputNumber.TabIndex = 2;
            this.labelOutputNumber.Text = "Output Number";
            // 
            // textBoxFeeOutputNumber
            // 
            this.textBoxFeeOutputNumber.Location = new System.Drawing.Point(554, 26);
            this.textBoxFeeOutputNumber.Name = "textBoxFeeOutputNumber";
            this.textBoxFeeOutputNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxFeeOutputNumber.TabIndex = 3;
            // 
            // toolTipCommitment
            // 
            this.toolTipCommitment.Tag = "";
            // 
            // labelFeePrivateKey
            // 
            this.labelFeePrivateKey.AutoSize = true;
            this.labelFeePrivateKey.Location = new System.Drawing.Point(29, 56);
            this.labelFeePrivateKey.Name = "labelFeePrivateKey";
            this.labelFeePrivateKey.Size = new System.Drawing.Size(82, 17);
            this.labelFeePrivateKey.TabIndex = 4;
            this.labelFeePrivateKey.Text = "Private key:";
            // 
            // textFeePrivateKey
            // 
            this.textFeePrivateKey.Location = new System.Drawing.Point(113, 51);
            this.textFeePrivateKey.Name = "textFeePrivateKey";
            this.textFeePrivateKey.Size = new System.Drawing.Size(322, 22);
            this.textFeePrivateKey.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 481);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "OffchainHelper";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox textSignedTransaction;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.TextBox textPrivateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCommitmentToSign;
        private System.Windows.Forms.Label labelCommitmentToSign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFeeOutputNumber;
        private System.Windows.Forms.Label labelOutputNumber;
        private System.Windows.Forms.TextBox textBoxFeeTransactionId;
        private System.Windows.Forms.Label labelTxId;
        private System.Windows.Forms.ToolTip toolTipCommitment;
        private System.Windows.Forms.TextBox textFeePrivateKey;
        private System.Windows.Forms.Label labelFeePrivateKey;
    }
}

