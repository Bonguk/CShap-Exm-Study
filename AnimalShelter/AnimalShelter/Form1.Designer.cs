﻿namespace AnimalShelter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.CusDetailPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CusFullName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CusDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CusIsQualified = new System.Windows.Forms.Label();
            this.CusNewPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CusNewFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CusNewLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CusNewBirthday = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CusNewAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CusNewDescription = new System.Windows.Forms.TextBox();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.CusDetailPanel.SuspendLayout();
            this.CusNewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(165, 370);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(106, 41);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "입양자 생성";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CusDetailPanel
            // 
            this.CusDetailPanel.Controls.Add(this.CusDescription);
            this.CusDetailPanel.Controls.Add(this.label8);
            this.CusDetailPanel.Controls.Add(this.CusAddress);
            this.CusDetailPanel.Controls.Add(this.label6);
            this.CusDetailPanel.Controls.Add(this.CusAge);
            this.CusDetailPanel.Controls.Add(this.label4);
            this.CusDetailPanel.Controls.Add(this.CusIsQualified);
            this.CusDetailPanel.Controls.Add(this.CusFullName);
            this.CusDetailPanel.Controls.Add(this.label1);
            this.CusDetailPanel.Controls.Add(this.label2);
            this.CusDetailPanel.Location = new System.Drawing.Point(428, 13);
            this.CusDetailPanel.Name = "CusDetailPanel";
            this.CusDetailPanel.Size = new System.Drawing.Size(360, 425);
            this.CusDetailPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "이름 : ";
            // 
            // CusFullName
            // 
            this.CusFullName.AutoSize = true;
            this.CusFullName.Location = new System.Drawing.Point(87, 27);
            this.CusFullName.Name = "CusFullName";
            this.CusFullName.Size = new System.Drawing.Size(38, 12);
            this.CusFullName.TabIndex = 1;
            this.CusFullName.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "나이 : ";
            // 
            // CusAge
            // 
            this.CusAge.AutoSize = true;
            this.CusAge.Location = new System.Drawing.Point(87, 84);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(38, 12);
            this.CusAge.TabIndex = 1;
            this.CusAge.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "주소 : ";
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.Location = new System.Drawing.Point(87, 114);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(38, 12);
            this.CusAddress.TabIndex = 1;
            this.CusAddress.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "설명 : ";
            // 
            // CusDescription
            // 
            this.CusDescription.AutoSize = true;
            this.CusDescription.Location = new System.Drawing.Point(87, 140);
            this.CusDescription.Name = "CusDescription";
            this.CusDescription.Size = new System.Drawing.Size(38, 12);
            this.CusDescription.TabIndex = 1;
            this.CusDescription.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "입양가능 : ";
            // 
            // CusIsQualified
            // 
            this.CusIsQualified.AutoSize = true;
            this.CusIsQualified.Location = new System.Drawing.Point(87, 56);
            this.CusIsQualified.Name = "CusIsQualified";
            this.CusIsQualified.Size = new System.Drawing.Size(38, 12);
            this.CusIsQualified.TabIndex = 1;
            this.CusIsQualified.Text = "label2";
            // 
            // CusNewPanel
            // 
            this.CusNewPanel.Controls.Add(this.CusNewDescription);
            this.CusNewPanel.Controls.Add(this.label10);
            this.CusNewPanel.Controls.Add(this.CreateCustomer);
            this.CusNewPanel.Controls.Add(this.CusNewAddress);
            this.CusNewPanel.Controls.Add(this.label9);
            this.CusNewPanel.Controls.Add(this.CusNewBirthday);
            this.CusNewPanel.Controls.Add(this.label7);
            this.CusNewPanel.Controls.Add(this.CusNewLastName);
            this.CusNewPanel.Controls.Add(this.label5);
            this.CusNewPanel.Controls.Add(this.CusNewFirstName);
            this.CusNewPanel.Controls.Add(this.label3);
            this.CusNewPanel.Location = new System.Drawing.Point(138, 13);
            this.CusNewPanel.Name = "CusNewPanel";
            this.CusNewPanel.Size = new System.Drawing.Size(284, 425);
            this.CusNewPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "성 :";
            // 
            // CusNewFirstName
            // 
            this.CusNewFirstName.Location = new System.Drawing.Point(62, 32);
            this.CusNewFirstName.Name = "CusNewFirstName";
            this.CusNewFirstName.Size = new System.Drawing.Size(100, 21);
            this.CusNewFirstName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "이름 : ";
            // 
            // CusNewLastName
            // 
            this.CusNewLastName.Location = new System.Drawing.Point(62, 60);
            this.CusNewLastName.Name = "CusNewLastName";
            this.CusNewLastName.Size = new System.Drawing.Size(100, 21);
            this.CusNewLastName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "생일 :";
            // 
            // CusNewBirthday
            // 
            this.CusNewBirthday.Location = new System.Drawing.Point(62, 87);
            this.CusNewBirthday.Name = "CusNewBirthday";
            this.CusNewBirthday.Size = new System.Drawing.Size(100, 21);
            this.CusNewBirthday.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "주소 :";
            // 
            // CusNewAddress
            // 
            this.CusNewAddress.Location = new System.Drawing.Point(62, 114);
            this.CusNewAddress.Name = "CusNewAddress";
            this.CusNewAddress.Size = new System.Drawing.Size(100, 21);
            this.CusNewAddress.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "설명 :";
            // 
            // CusNewDescription
            // 
            this.CusNewDescription.Location = new System.Drawing.Point(62, 141);
            this.CusNewDescription.Multiline = true;
            this.CusNewDescription.Name = "CusNewDescription";
            this.CusNewDescription.Size = new System.Drawing.Size(209, 218);
            this.CusNewDescription.TabIndex = 1;
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.ItemHeight = 12;
            this.CustomerList.Location = new System.Drawing.Point(12, 13);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(120, 208);
            this.CustomerList.TabIndex = 3;
            this.CustomerList.Click += new System.EventHandler(this.CustomerList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.CusNewPanel);
            this.Controls.Add(this.CusDetailPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CusDetailPanel.ResumeLayout(false);
            this.CusDetailPanel.PerformLayout();
            this.CusNewPanel.ResumeLayout(false);
            this.CusNewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Panel CusDetailPanel;
        private System.Windows.Forms.Label CusDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CusAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CusAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CusFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CusIsQualified;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CusNewPanel;
        private System.Windows.Forms.TextBox CusNewDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CusNewAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CusNewBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CusNewLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CusNewFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox CustomerList;
    }
}

