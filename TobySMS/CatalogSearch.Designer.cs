namespace TobySMS
{
    partial class CatalogSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogSearch));
            this.studentNameTxtBox = new System.Windows.Forms.TextBox();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.isbnoTxtBox = new System.Windows.Forms.TextBox();
            this.publishTxtBox = new System.Windows.Forms.TextBox();
            this.categoryTxtBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.titleSearch = new System.Windows.Forms.Button();
            this.searchbyAuthorBtn = new System.Windows.Forms.Button();
            this.searchbyISBNBtn = new System.Windows.Forms.Button();
            this.searchByPublishBtn = new System.Windows.Forms.Button();
            this.searchByCategoryBtn = new System.Windows.Forms.Button();
            this.catalogDataGridView = new System.Windows.Forms.DataGridView();
            this.studentTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDbaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backtoDash = new System.Windows.Forms.Button();
            this.issueBookBtn = new System.Windows.Forms.Button();
            this.dataGridViewHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dashLogOutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDbaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentNameTxtBox
            // 
            this.studentNameTxtBox.Location = new System.Drawing.Point(341, 31);
            this.studentNameTxtBox.Name = "studentNameTxtBox";
            this.studentNameTxtBox.Size = new System.Drawing.Size(530, 23);
            this.studentNameTxtBox.TabIndex = 0;
            this.studentNameTxtBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(341, 57);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(530, 23);
            this.authorTxtBox.TabIndex = 0;
            // 
            // isbnoTxtBox
            // 
            this.isbnoTxtBox.Location = new System.Drawing.Point(341, 83);
            this.isbnoTxtBox.Name = "isbnoTxtBox";
            this.isbnoTxtBox.Size = new System.Drawing.Size(530, 23);
            this.isbnoTxtBox.TabIndex = 0;
            // 
            // publishTxtBox
            // 
            this.publishTxtBox.Location = new System.Drawing.Point(341, 109);
            this.publishTxtBox.Name = "publishTxtBox";
            this.publishTxtBox.Size = new System.Drawing.Size(530, 23);
            this.publishTxtBox.TabIndex = 0;
            // 
            // categoryTxtBox
            // 
            this.categoryTxtBox.Location = new System.Drawing.Point(341, 135);
            this.categoryTxtBox.Name = "categoryTxtBox";
            this.categoryTxtBox.Size = new System.Drawing.Size(530, 23);
            this.categoryTxtBox.TabIndex = 0;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold);
            this.authorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.authorLabel.Location = new System.Drawing.Point(251, 62);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(89, 15);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Book Author ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(251, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(251, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "ISBNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(251, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Publish Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(251, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Category";
            // 
            // titleSearch
            // 
            this.titleSearch.BackColor = System.Drawing.Color.Transparent;
            this.titleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSearch.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.titleSearch.Location = new System.Drawing.Point(877, 31);
            this.titleSearch.Name = "titleSearch";
            this.titleSearch.Size = new System.Drawing.Size(167, 23);
            this.titleSearch.TabIndex = 2;
            this.titleSearch.Text = "Search by Title";
            this.titleSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleSearch.UseVisualStyleBackColor = false;
            this.titleSearch.Click += new System.EventHandler(this.StudentNameSearch_Click);
            // 
            // searchbyAuthorBtn
            // 
            this.searchbyAuthorBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbyAuthorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbyAuthorBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchbyAuthorBtn.Location = new System.Drawing.Point(877, 55);
            this.searchbyAuthorBtn.Name = "searchbyAuthorBtn";
            this.searchbyAuthorBtn.Size = new System.Drawing.Size(167, 23);
            this.searchbyAuthorBtn.TabIndex = 2;
            this.searchbyAuthorBtn.Text = "Search by Author";
            this.searchbyAuthorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchbyAuthorBtn.UseVisualStyleBackColor = false;
            this.searchbyAuthorBtn.Click += new System.EventHandler(this.SearchbyAuthorBtn_Click);
            // 
            // searchbyISBNBtn
            // 
            this.searchbyISBNBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbyISBNBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbyISBNBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchbyISBNBtn.Location = new System.Drawing.Point(878, 82);
            this.searchbyISBNBtn.Name = "searchbyISBNBtn";
            this.searchbyISBNBtn.Size = new System.Drawing.Size(166, 23);
            this.searchbyISBNBtn.TabIndex = 2;
            this.searchbyISBNBtn.Text = "Search by ISBN ";
            this.searchbyISBNBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchbyISBNBtn.UseVisualStyleBackColor = false;
            this.searchbyISBNBtn.Click += new System.EventHandler(this.SearchbyISBNBtn_Click);
            // 
            // searchByPublishBtn
            // 
            this.searchByPublishBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchByPublishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByPublishBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchByPublishBtn.Location = new System.Drawing.Point(878, 106);
            this.searchByPublishBtn.Name = "searchByPublishBtn";
            this.searchByPublishBtn.Size = new System.Drawing.Size(166, 23);
            this.searchByPublishBtn.TabIndex = 2;
            this.searchByPublishBtn.Text = "Search by Publish Date ";
            this.searchByPublishBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchByPublishBtn.UseVisualStyleBackColor = false;
            this.searchByPublishBtn.Click += new System.EventHandler(this.SearchByPublishBtn_Click);
            // 
            // searchByCategoryBtn
            // 
            this.searchByCategoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchByCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByCategoryBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchByCategoryBtn.Location = new System.Drawing.Point(878, 132);
            this.searchByCategoryBtn.Name = "searchByCategoryBtn";
            this.searchByCategoryBtn.Size = new System.Drawing.Size(166, 23);
            this.searchByCategoryBtn.TabIndex = 2;
            this.searchByCategoryBtn.Text = "Search by Category";
            this.searchByCategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchByCategoryBtn.UseVisualStyleBackColor = false;
            this.searchByCategoryBtn.Click += new System.EventHandler(this.SearchByCategoryBtn_Click);
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
            this.catalogDataGridView.DataSource = this.studentTableBindingSource1;
            this.catalogDataGridView.Location = new System.Drawing.Point(217, 271);
            this.catalogDataGridView.Name = "catalogDataGridView";
            this.catalogDataGridView.ReadOnly = true;
            this.catalogDataGridView.Size = new System.Drawing.Size(1085, 400);
            this.catalogDataGridView.TabIndex = 3;
            this.catalogDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatalogDataGridView_CellContentClick);
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataMember = "studentTable";
            // 
            // backtoDash
            // 
            this.backtoDash.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backtoDash.Location = new System.Drawing.Point(761, 694);
            this.backtoDash.Name = "backtoDash";
            this.backtoDash.Size = new System.Drawing.Size(112, 23);
            this.backtoDash.TabIndex = 5;
            this.backtoDash.Text = "Back to dashboard";
            this.backtoDash.UseVisualStyleBackColor = true;
            this.backtoDash.Click += new System.EventHandler(this.BacktoDash_Click);
            // 
            // issueBookBtn
            // 
            this.issueBookBtn.Location = new System.Drawing.Point(491, 694);
            this.issueBookBtn.Name = "issueBookBtn";
            this.issueBookBtn.Size = new System.Drawing.Size(101, 23);
            this.issueBookBtn.TabIndex = 4;
            this.issueBookBtn.Text = "Lend Book(s)";
            this.issueBookBtn.UseVisualStyleBackColor = true;
            this.issueBookBtn.Click += new System.EventHandler(this.IssueBookBtn_Click);
            // 
            // dataGridViewHeader
            // 
            this.dataGridViewHeader.AutoSize = true;
            this.dataGridViewHeader.BackColor = System.Drawing.Color.Transparent;
            this.dataGridViewHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataGridViewHeader.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewHeader.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewHeader.Location = new System.Drawing.Point(596, 225);
            this.dataGridViewHeader.Name = "dataGridViewHeader";
            this.dataGridViewHeader.Size = new System.Drawing.Size(262, 30);
            this.dataGridViewHeader.TabIndex = 6;
            this.dataGridViewHeader.Text = "Catalog Search Results";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.studentNameTxtBox);
            this.groupBox1.Controls.Add(this.authorTxtBox);
            this.groupBox1.Controls.Add(this.isbnoTxtBox);
            this.groupBox1.Controls.Add(this.publishTxtBox);
            this.groupBox1.Controls.Add(this.searchByCategoryBtn);
            this.groupBox1.Controls.Add(this.categoryTxtBox);
            this.groupBox1.Controls.Add(this.searchByPublishBtn);
            this.groupBox1.Controls.Add(this.authorLabel);
            this.groupBox1.Controls.Add(this.searchbyISBNBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.searchbyAuthorBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.titleSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1383, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BookDetails";
            // 
            // dashLogOutBtn
            // 
            this.dashLogOutBtn.AutoSize = true;
            this.dashLogOutBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dashLogOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dashLogOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashLogOutBtn.Image")));
            this.dashLogOutBtn.Location = new System.Drawing.Point(0, 409);
            this.dashLogOutBtn.Name = "dashLogOutBtn";
            this.dashLogOutBtn.Size = new System.Drawing.Size(152, 111);
            this.dashLogOutBtn.TabIndex = 10;
            this.dashLogOutBtn.Text = "LogOut";
            this.dashLogOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashLogOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashLogOutBtn.UseVisualStyleBackColor = false;
            this.dashLogOutBtn.Click += new System.EventHandler(this.DashLogOutBtn_Click);
            // 
            // CatalogSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.backtoDash;
            this.ClientSize = new System.Drawing.Size(1383, 739);
            this.Controls.Add(this.dashLogOutBtn);
            this.Controls.Add(this.catalogDataGridView);
            this.Controls.Add(this.dataGridViewHeader);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.issueBookBtn);
            this.Controls.Add(this.backtoDash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatalogSearch";
            this.Text = "Search Library Catalog";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CatalogSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDbaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox isbnoTxtBox;
        private System.Windows.Forms.TextBox publishTxtBox;
        private System.Windows.Forms.TextBox categoryTxtBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button titleSearch;
        private System.Windows.Forms.Button searchbyAuthorBtn;
        private System.Windows.Forms.Button searchbyISBNBtn;
        private System.Windows.Forms.Button searchByPublishBtn;
        private System.Windows.Forms.Button searchByCategoryBtn;
        private System.Windows.Forms.DataGridView catalogDataGridView;
        private System.Windows.Forms.BindingSource libraryDbaseDataSetBindingSource;
        //private StudentMangementSysDataSet StudentMangementSysDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox studentNameTxtBox;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        //private StudentMangementSysDataSetTableAdapters.studentTableTableAdapter studentTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentTableBindingSource1;
        private System.Windows.Forms.Button backtoDash;
        private System.Windows.Forms.Button issueBookBtn;
        private System.Windows.Forms.Label dataGridViewHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dashLogOutBtn;
    }
}