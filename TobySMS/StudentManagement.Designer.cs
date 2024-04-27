namespace TobySMS
{
    partial class StudentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentManagement));
            this.bookTitleTxtBox = new System.Windows.Forms.TextBox();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.isbnoTxtBox = new System.Windows.Forms.TextBox();
            this.publishTxtBox = new System.Windows.Forms.TextBox();
            this.categoryTxtBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.catalogAcquisition = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.deregisterMemberBtn = new System.Windows.Forms.Button();
            this.clearAdminFieldsBtn = new System.Windows.Forms.Button();
            this.registerAdminBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.catalogDataGridView = new System.Windows.Forms.DataGridView();
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookTitleTxtBox
            // 
            this.bookTitleTxtBox.Location = new System.Drawing.Point(335, 66);
            this.bookTitleTxtBox.Name = "bookTitleTxtBox";
            this.bookTitleTxtBox.Size = new System.Drawing.Size(361, 20);
            this.bookTitleTxtBox.TabIndex = 3;
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(335, 92);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(361, 20);
            this.authorTxtBox.TabIndex = 4;
            // 
            // isbnoTxtBox
            // 
            this.isbnoTxtBox.Location = new System.Drawing.Point(335, 118);
            this.isbnoTxtBox.Name = "isbnoTxtBox";
            this.isbnoTxtBox.Size = new System.Drawing.Size(361, 20);
            this.isbnoTxtBox.TabIndex = 5;
            // 
            // publishTxtBox
            // 
            this.publishTxtBox.Location = new System.Drawing.Point(335, 144);
            this.publishTxtBox.Name = "publishTxtBox";
            this.publishTxtBox.Size = new System.Drawing.Size(361, 20);
            this.publishTxtBox.TabIndex = 6;
            // 
            // categoryTxtBox
            // 
            this.categoryTxtBox.Location = new System.Drawing.Point(335, 170);
            this.categoryTxtBox.Name = "categoryTxtBox";
            this.categoryTxtBox.Size = new System.Drawing.Size(361, 20);
            this.categoryTxtBox.TabIndex = 7;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold);
            this.authorLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.authorLabel.Location = new System.Drawing.Point(229, 96);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(50, 15);
            this.authorLabel.TabIndex = 12;
            this.authorLabel.Text = "FName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(229, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "AdmNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(229, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "ISBNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(229, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Session";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(229, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Course";
            // 
            // catalogAcquisition
            // 
            this.catalogAcquisition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.catalogAcquisition.Image = ((System.Drawing.Image)(resources.GetObject("catalogAcquisition.Image")));
            this.catalogAcquisition.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.catalogAcquisition.Location = new System.Drawing.Point(812, 26);
            this.catalogAcquisition.Name = "catalogAcquisition";
            this.catalogAcquisition.Size = new System.Drawing.Size(205, 114);
            this.catalogAcquisition.TabIndex = 13;
            this.catalogAcquisition.Text = "Book Registration";
            this.catalogAcquisition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.catalogAcquisition.UseVisualStyleBackColor = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(696, 217);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 20;
            // 
            // deregisterMemberBtn
            // 
            this.deregisterMemberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deregisterMemberBtn.ForeColor = System.Drawing.Color.DimGray;
            this.deregisterMemberBtn.Location = new System.Drawing.Point(587, 212);
            this.deregisterMemberBtn.Name = "deregisterMemberBtn";
            this.deregisterMemberBtn.Size = new System.Drawing.Size(80, 23);
            this.deregisterMemberBtn.TabIndex = 17;
            this.deregisterMemberBtn.Text = "Deregister";
            this.deregisterMemberBtn.UseVisualStyleBackColor = true;
            // 
            // clearAdminFieldsBtn
            // 
            this.clearAdminFieldsBtn.Location = new System.Drawing.Point(488, 212);
            this.clearAdminFieldsBtn.Name = "clearAdminFieldsBtn";
            this.clearAdminFieldsBtn.Size = new System.Drawing.Size(56, 23);
            this.clearAdminFieldsBtn.TabIndex = 18;
            this.clearAdminFieldsBtn.Text = "Clear";
            this.clearAdminFieldsBtn.UseVisualStyleBackColor = true;
            // 
            // registerAdminBtn
            // 
            this.registerAdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerAdminBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.registerAdminBtn.Location = new System.Drawing.Point(362, 212);
            this.registerAdminBtn.Name = "registerAdminBtn";
            this.registerAdminBtn.Size = new System.Drawing.Size(84, 23);
            this.registerAdminBtn.TabIndex = 19;
            this.registerAdminBtn.Text = "Register Book";
            this.registerAdminBtn.UseVisualStyleBackColor = true;
            this.registerAdminBtn.Click += new System.EventHandler(this.registerAdminBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "StudentOverview";
            // 
            // catalogDataGridView
            // 
            this.catalogDataGridView.AllowUserToAddRows = false;
            this.catalogDataGridView.AllowUserToDeleteRows = false;
            this.catalogDataGridView.AutoGenerateColumns = false;
            this.catalogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catalogDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.catalogDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catalogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogDataGridView.DataSource = this.studentTableBindingSource;
            this.catalogDataGridView.Location = new System.Drawing.Point(90, 264);
            this.catalogDataGridView.Name = "catalogDataGridView";
            this.catalogDataGridView.ReadOnly = true;
            this.catalogDataGridView.Size = new System.Drawing.Size(927, 400);
            this.catalogDataGridView.TabIndex = 22;
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataMember = "studentTable";
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1128, 489);
            this.Controls.Add(this.catalogDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.deregisterMemberBtn);
            this.Controls.Add(this.clearAdminFieldsBtn);
            this.Controls.Add(this.registerAdminBtn);
            this.Controls.Add(this.catalogAcquisition);
            this.Controls.Add(this.bookTitleTxtBox);
            this.Controls.Add(this.authorTxtBox);
            this.Controls.Add(this.isbnoTxtBox);
            this.Controls.Add(this.publishTxtBox);
            this.Controls.Add(this.categoryTxtBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "StudentManagement";
            this.Text = "CatalogManagement";
            this.Load += new System.EventHandler(this.BookRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookTitleTxtBox;
        public System.Windows.Forms.TextBox authorTxtBox;
        private System.Windows.Forms.TextBox isbnoTxtBox;
        private System.Windows.Forms.TextBox publishTxtBox;
        private System.Windows.Forms.TextBox categoryTxtBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button catalogAcquisition;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button deregisterMemberBtn;
        private System.Windows.Forms.Button clearAdminFieldsBtn;
        private System.Windows.Forms.Button registerAdminBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView catalogDataGridView;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}