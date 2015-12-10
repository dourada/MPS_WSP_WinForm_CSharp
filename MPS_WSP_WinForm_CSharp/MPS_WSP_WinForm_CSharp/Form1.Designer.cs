namespace MPS_WSP_WinForm_CSharp
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
            this.btnPaymentCredit = new System.Windows.Forms.Button();
            this.btnMenuApple = new System.Windows.Forms.Button();
            this.btnMenuOrange = new System.Windows.Forms.Button();
            this.btnMenuGrape = new System.Windows.Forms.Button();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.btnPaymentDebit = new System.Windows.Forms.Button();
            this.btnPaymentPrePaid = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPaymentCredit
            // 
            this.btnPaymentCredit.Location = new System.Drawing.Point(21, 21);
            this.btnPaymentCredit.Name = "btnPaymentCredit";
            this.btnPaymentCredit.Size = new System.Drawing.Size(75, 23);
            this.btnPaymentCredit.TabIndex = 0;
            this.btnPaymentCredit.Text = "Credit";
            this.btnPaymentCredit.UseVisualStyleBackColor = true;
            this.btnPaymentCredit.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnMenuApple
            // 
            this.btnMenuApple.Location = new System.Drawing.Point(391, 32);
            this.btnMenuApple.Name = "btnMenuApple";
            this.btnMenuApple.Size = new System.Drawing.Size(75, 23);
            this.btnMenuApple.TabIndex = 1;
            this.btnMenuApple.Text = "Apple";
            this.btnMenuApple.UseVisualStyleBackColor = true;
            this.btnMenuApple.Click += new System.EventHandler(this.btnMenuApple_Click);
            // 
            // btnMenuOrange
            // 
            this.btnMenuOrange.Location = new System.Drawing.Point(391, 61);
            this.btnMenuOrange.Name = "btnMenuOrange";
            this.btnMenuOrange.Size = new System.Drawing.Size(75, 23);
            this.btnMenuOrange.TabIndex = 2;
            this.btnMenuOrange.Text = "Orange";
            this.btnMenuOrange.UseVisualStyleBackColor = true;
            // 
            // btnMenuGrape
            // 
            this.btnMenuGrape.Location = new System.Drawing.Point(391, 90);
            this.btnMenuGrape.Name = "btnMenuGrape";
            this.btnMenuGrape.Size = new System.Drawing.Size(75, 23);
            this.btnMenuGrape.TabIndex = 3;
            this.btnMenuGrape.Text = "Grape";
            this.btnMenuGrape.UseVisualStyleBackColor = true;
            // 
            // txtReceipt
            // 
            this.txtReceipt.Location = new System.Drawing.Point(13, 26);
            this.txtReceipt.Multiline = true;
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.Size = new System.Drawing.Size(286, 223);
            this.txtReceipt.TabIndex = 4;
            // 
            // btnPaymentDebit
            // 
            this.btnPaymentDebit.Location = new System.Drawing.Point(391, 248);
            this.btnPaymentDebit.Name = "btnPaymentDebit";
            this.btnPaymentDebit.Size = new System.Drawing.Size(75, 23);
            this.btnPaymentDebit.TabIndex = 5;
            this.btnPaymentDebit.Text = "Debit";
            this.btnPaymentDebit.UseVisualStyleBackColor = true;
            // 
            // btnPaymentPrePaid
            // 
            this.btnPaymentPrePaid.Location = new System.Drawing.Point(391, 277);
            this.btnPaymentPrePaid.Name = "btnPaymentPrePaid";
            this.btnPaymentPrePaid.Size = new System.Drawing.Size(75, 23);
            this.btnPaymentPrePaid.TabIndex = 6;
            this.btnPaymentPrePaid.Text = "PrePaid";
            this.btnPaymentPrePaid.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(391, 147);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(370, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Items";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPaymentCredit);
            this.groupBox2.Location = new System.Drawing.Point(370, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 125);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Methods";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(391, 329);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(391, 358);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(75, 23);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(13, 324);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(286, 68);
            this.txtLog.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Receipt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnPaymentPrePaid);
            this.Controls.Add(this.btnPaymentDebit);
            this.Controls.Add(this.txtReceipt);
            this.Controls.Add(this.btnMenuGrape);
            this.Controls.Add(this.btnMenuOrange);
            this.Controls.Add(this.btnMenuApple);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "MPS WSP WinForm";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaymentCredit;
        private System.Windows.Forms.Button btnMenuApple;
        private System.Windows.Forms.Button btnMenuOrange;
        private System.Windows.Forms.Button btnMenuGrape;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.Button btnPaymentDebit;
        private System.Windows.Forms.Button btnPaymentPrePaid;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

