using System;

namespace TobySMS
{

    partial class AdminDashboard
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel_Course = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel_Student = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.studentStatusButton = new System.Windows.Forms.Button();
            this.studentManageButton = new System.Windows.Forms.Button();
            this.studentRegButton = new System.Windows.Forms.Button();
            this.dashboardMainPanel = new System.Windows.Forms.Panel();
            this.CurriculumBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_Course.SuspendLayout();
            this.panel_Student.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel_Course);
            this.panel2.Controls.Add(this.panel_Student);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 792);
            this.panel2.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Location = new System.Drawing.Point(12, 484);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 222);
            this.panel5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(121, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Student";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(12, 174);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(270, 34);
            this.button7.TabIndex = 0;
            this.button7.Text = "Print";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(12, 134);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(270, 34);
            this.button8.TabIndex = 0;
            this.button8.Text = "Student Status";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(12, 92);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(270, 34);
            this.button9.TabIndex = 0;
            this.button9.Text = "Manage Student";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(12, 52);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(270, 34);
            this.button10.TabIndex = 0;
            this.button10.Text = "New Student Registration";
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // panel_Course
            // 
            this.panel_Course.Controls.Add(this.label4);
            this.panel_Course.Controls.Add(this.button1);
            this.panel_Course.Controls.Add(this.button2);
            this.panel_Course.Controls.Add(this.button3);
            this.panel_Course.Controls.Add(this.CurriculumBtn);
            this.panel_Course.Controls.Add(this.button5);
            this.panel_Course.Location = new System.Drawing.Point(12, 225);
            this.panel_Course.Name = "panel_Course";
            this.panel_Course.Size = new System.Drawing.Size(293, 238);
            this.panel_Course.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(100, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Academics";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Print";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Student Status";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Results";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(12, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(270, 34);
            this.button5.TabIndex = 0;
            this.button5.Text = "Grading";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel_Student
            // 
            this.panel_Student.Controls.Add(this.label1);
            this.panel_Student.Controls.Add(this.printButton);
            this.panel_Student.Controls.Add(this.studentStatusButton);
            this.panel_Student.Controls.Add(this.studentManageButton);
            this.panel_Student.Controls.Add(this.studentRegButton);
            this.panel_Student.Location = new System.Drawing.Point(12, 9);
            this.panel_Student.Name = "panel_Student";
            this.panel_Student.Size = new System.Drawing.Size(293, 189);
            this.panel_Student.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(121, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student";
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printButton.Location = new System.Drawing.Point(12, 150);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(270, 34);
            this.printButton.TabIndex = 0;
            this.printButton.Text = "Print";
            this.printButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // studentStatusButton
            // 
            this.studentStatusButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentStatusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentStatusButton.Location = new System.Drawing.Point(12, 110);
            this.studentStatusButton.Name = "studentStatusButton";
            this.studentStatusButton.Size = new System.Drawing.Size(270, 34);
            this.studentStatusButton.TabIndex = 0;
            this.studentStatusButton.Text = "Student Status";
            this.studentStatusButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.studentStatusButton.UseVisualStyleBackColor = false;
            // 
            // studentManageButton
            // 
            this.studentManageButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentManageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentManageButton.Location = new System.Drawing.Point(12, 68);
            this.studentManageButton.Name = "studentManageButton";
            this.studentManageButton.Size = new System.Drawing.Size(270, 34);
            this.studentManageButton.TabIndex = 0;
            this.studentManageButton.Text = "Manage Student";
            this.studentManageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.studentManageButton.UseVisualStyleBackColor = false;
            this.studentManageButton.Click += new System.EventHandler(this.studentManageButton_Click);
            // 
            // studentRegButton
            // 
            this.studentRegButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentRegButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentRegButton.Location = new System.Drawing.Point(12, 28);
            this.studentRegButton.Name = "studentRegButton";
            this.studentRegButton.Size = new System.Drawing.Size(270, 34);
            this.studentRegButton.TabIndex = 0;
            this.studentRegButton.Text = "New Student Registration";
            this.studentRegButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.studentRegButton.UseVisualStyleBackColor = false;
            this.studentRegButton.Click += new System.EventHandler(this.studentRegButton_Click);
            // 
            // dashboardMainPanel
            // 
            this.dashboardMainPanel.Location = new System.Drawing.Point(335, 9);
            this.dashboardMainPanel.Name = "dashboardMainPanel";
            this.dashboardMainPanel.Size = new System.Drawing.Size(1026, 783);
            this.dashboardMainPanel.TabIndex = 12;
            // 
            // CurriculumBtn
            // 
            this.CurriculumBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurriculumBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurriculumBtn.Location = new System.Drawing.Point(12, 28);
            this.CurriculumBtn.Name = "CurriculumBtn";
            this.CurriculumBtn.Size = new System.Drawing.Size(270, 34);
            this.CurriculumBtn.TabIndex = 0;
            this.CurriculumBtn.Text = "Curriculum";
            this.CurriculumBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CurriculumBtn.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1364, 792);
            this.Controls.Add(this.dashboardMainPanel);
            this.Controls.Add(this.panel2);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_Course.ResumeLayout(false);
            this.panel_Course.PerformLayout();
            this.panel_Student.ResumeLayout(false);
            this.panel_Student.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Student;
        private System.Windows.Forms.Button studentRegButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button studentStatusButton;
        private System.Windows.Forms.Button studentManageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel_Course;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel dashboardMainPanel;
        private System.Windows.Forms.Button CurriculumBtn;
    }
}