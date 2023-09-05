namespace DeltaBicycles.UI
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddRB = new System.Windows.Forms.Button();
            this.btnAddMB = new System.Windows.Forms.Button();
            this.btnUpdateRB = new System.Windows.Forms.Button();
            this.btnUpdateMB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSB = new System.Windows.Forms.TextBox();
            this.btnRemoveById = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvBikes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbRoadBike = new System.Windows.Forms.RadioButton();
            this.rbMountainBike = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemoveByIndex = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(777, 604);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 52);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddRB
            // 
            this.btnAddRB.Location = new System.Drawing.Point(53, 61);
            this.btnAddRB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRB.Name = "btnAddRB";
            this.btnAddRB.Size = new System.Drawing.Size(133, 71);
            this.btnAddRB.TabIndex = 1;
            this.btnAddRB.Text = "Add";
            this.btnAddRB.UseVisualStyleBackColor = true;
            this.btnAddRB.Click += new System.EventHandler(this.btnAddRB_Click);
            // 
            // btnAddMB
            // 
            this.btnAddMB.Location = new System.Drawing.Point(73, 61);
            this.btnAddMB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMB.Name = "btnAddMB";
            this.btnAddMB.Size = new System.Drawing.Size(133, 71);
            this.btnAddMB.TabIndex = 2;
            this.btnAddMB.Text = "Add";
            this.btnAddMB.UseVisualStyleBackColor = true;
            this.btnAddMB.Click += new System.EventHandler(this.btnAddMB_Click);
            // 
            // btnUpdateRB
            // 
            this.btnUpdateRB.Location = new System.Drawing.Point(258, 61);
            this.btnUpdateRB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateRB.Name = "btnUpdateRB";
            this.btnUpdateRB.Size = new System.Drawing.Size(133, 71);
            this.btnUpdateRB.TabIndex = 3;
            this.btnUpdateRB.Text = "Update";
            this.btnUpdateRB.UseVisualStyleBackColor = true;
            this.btnUpdateRB.Click += new System.EventHandler(this.btnUpdateRB_Click);
            // 
            // btnUpdateMB
            // 
            this.btnUpdateMB.Location = new System.Drawing.Point(275, 61);
            this.btnUpdateMB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateMB.Name = "btnUpdateMB";
            this.btnUpdateMB.Size = new System.Drawing.Size(133, 71);
            this.btnUpdateMB.TabIndex = 4;
            this.btnUpdateMB.Text = "Update";
            this.btnUpdateMB.UseVisualStyleBackColor = true;
            this.btnUpdateMB.Click += new System.EventHandler(this.btnUpdateMB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddRB);
            this.groupBox1.Controls.Add(this.btnUpdateRB);
            this.groupBox1.Location = new System.Drawing.Point(14, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(443, 199);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Road Bikes";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAddMB);
            this.groupBox2.Controls.Add(this.btnUpdateMB);
            this.groupBox2.Location = new System.Drawing.Point(464, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(437, 199);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mountain Bikes";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(146, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 63);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtSB);
            this.groupBox3.Controls.Add(this.btnRemoveById);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Location = new System.Drawing.Point(593, 295);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(307, 87);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Specific Bike";
            // 
            // txtSB
            // 
            this.txtSB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSB.Location = new System.Drawing.Point(7, 33);
            this.txtSB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSB.Name = "txtSB";
            this.txtSB.Size = new System.Drawing.Size(132, 27);
            this.txtSB.TabIndex = 12;
            // 
            // btnRemoveById
            // 
            this.btnRemoveById.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveById.Location = new System.Drawing.Point(230, 16);
            this.btnRemoveById.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveById.Name = "btnRemoveById";
            this.btnRemoveById.Size = new System.Drawing.Size(71, 63);
            this.btnRemoveById.TabIndex = 11;
            this.btnRemoveById.Text = "Remove by Id";
            this.btnRemoveById.UseVisualStyleBackColor = true;
            this.btnRemoveById.Click += new System.EventHandler(this.btnRemoveById_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(914, 72);
            this.label1.TabIndex = 12;
            this.label1.Text = "Delta Bikes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "List by:";
            // 
            // lvBikes
            // 
            this.lvBikes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBikes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvBikes.FullRowSelect = true;
            this.lvBikes.GridLines = true;
            this.lvBikes.Location = new System.Drawing.Point(14, 389);
            this.lvBikes.Name = "lvBikes";
            this.lvBikes.Size = new System.Drawing.Size(886, 205);
            this.lvBikes.TabIndex = 14;
            this.lvBikes.UseCompatibleStateImageBehavior = false;
            this.lvBikes.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 886;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(136, 339);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(48, 24);
            this.rbAll.TabIndex = 15;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbRoadBike
            // 
            this.rbRoadBike.AutoSize = true;
            this.rbRoadBike.Location = new System.Drawing.Point(190, 339);
            this.rbRoadBike.Name = "rbRoadBike";
            this.rbRoadBike.Size = new System.Drawing.Size(97, 24);
            this.rbRoadBike.TabIndex = 16;
            this.rbRoadBike.Text = "Road Bike";
            this.rbRoadBike.UseVisualStyleBackColor = true;
            this.rbRoadBike.CheckedChanged += new System.EventHandler(this.rbRoadBike_CheckedChanged);
            // 
            // rbMountainBike
            // 
            this.rbMountainBike.AutoSize = true;
            this.rbMountainBike.Location = new System.Drawing.Point(293, 339);
            this.rbMountainBike.Name = "rbMountainBike";
            this.rbMountainBike.Size = new System.Drawing.Size(125, 24);
            this.rbMountainBike.TabIndex = 17;
            this.rbMountainBike.Text = "Mountain BIke";
            this.rbMountainBike.UseVisualStyleBackColor = true;
            this.rbMountainBike.CheckedChanged += new System.EventHandler(this.rbMountainBike_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(648, 604);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 52);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemoveByIndex
            // 
            this.btnRemoveByIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveByIndex.Location = new System.Drawing.Point(518, 604);
            this.btnRemoveByIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveByIndex.Name = "btnRemoveByIndex";
            this.btnRemoveByIndex.Size = new System.Drawing.Size(123, 52);
            this.btnRemoveByIndex.TabIndex = 19;
            this.btnRemoveByIndex.Text = "Remove by Index";
            this.btnRemoveByIndex.UseVisualStyleBackColor = true;
            this.btnRemoveByIndex.Click += new System.EventHandler(this.btnRemoveByIndex_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 675);
            this.Controls.Add(this.btnRemoveByIndex);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbMountainBike);
            this.Controls.Add(this.rbRoadBike);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.lvBikes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExit;
        private Button btnAddRB;
        private Button btnAddMB;
        private Button btnUpdateRB;
        private Button btnUpdateMB;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSearch;
        private GroupBox groupBox3;
        private TextBox txtSB;
        private Button btnRemoveById;
        private Label label1;
        private Label label2;
        private ListView lvBikes;
        private ColumnHeader columnHeader1;
        private RadioButton rbAll;
        private RadioButton rbRoadBike;
        private RadioButton rbMountainBike;
        private Button btnSave;
        private Button btnRemoveByIndex;
    }
}