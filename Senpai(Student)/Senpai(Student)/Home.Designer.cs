﻿namespace Senpai_Student_
{
    partial class Home
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
            this.ButtonFindCla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonViewInfo = new System.Windows.Forms.Button();
            this.ButtonManageRequests = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxClassroomSelector = new System.Windows.Forms.ComboBox();
            this.ButtonMessages = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonFindCla
            // 
            this.ButtonFindCla.Location = new System.Drawing.Point(25, 67);
            this.ButtonFindCla.Name = "ButtonFindCla";
            this.ButtonFindCla.Size = new System.Drawing.Size(141, 23);
            this.ButtonFindCla.TabIndex = 0;
            this.ButtonFindCla.Text = "Find Classroom";
            this.ButtonFindCla.UseVisualStyleBackColor = true;
            this.ButtonFindCla.Click += new System.EventHandler(this.ButtonFindCla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome User!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonViewInfo
            // 
            this.ButtonViewInfo.Location = new System.Drawing.Point(197, 67);
            this.ButtonViewInfo.Name = "ButtonViewInfo";
            this.ButtonViewInfo.Size = new System.Drawing.Size(131, 23);
            this.ButtonViewInfo.TabIndex = 2;
            this.ButtonViewInfo.Text = "View Info";
            this.ButtonViewInfo.UseVisualStyleBackColor = true;
            // 
            // ButtonManageRequests
            // 
            this.ButtonManageRequests.Location = new System.Drawing.Point(371, 67);
            this.ButtonManageRequests.Name = "ButtonManageRequests";
            this.ButtonManageRequests.Size = new System.Drawing.Size(137, 23);
            this.ButtonManageRequests.TabIndex = 3;
            this.ButtonManageRequests.Text = "Manage Requests";
            this.ButtonManageRequests.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxClassroomSelector);
            this.panel1.Location = new System.Drawing.Point(25, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 213);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select ClassRoom";
            // 
            // comboBoxClassroomSelector
            // 
            this.comboBoxClassroomSelector.FormattingEnabled = true;
            this.comboBoxClassroomSelector.Location = new System.Drawing.Point(37, 49);
            this.comboBoxClassroomSelector.Name = "comboBoxClassroomSelector";
            this.comboBoxClassroomSelector.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClassroomSelector.TabIndex = 5;
            // 
            // ButtonMessages
            // 
            this.ButtonMessages.Location = new System.Drawing.Point(371, 127);
            this.ButtonMessages.Name = "ButtonMessages";
            this.ButtonMessages.Size = new System.Drawing.Size(137, 24);
            this.ButtonMessages.TabIndex = 5;
            this.ButtonMessages.Text = "Messages";
            this.ButtonMessages.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 395);
            this.Controls.Add(this.ButtonMessages);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonManageRequests);
            this.Controls.Add(this.ButtonViewInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonFindCla);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFindCla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonViewInfo;
        private System.Windows.Forms.Button ButtonManageRequests;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxClassroomSelector;
        private System.Windows.Forms.Button ButtonMessages;
    }
}