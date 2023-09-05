namespace DeltaBicycles.UI
{
    partial class MountainBikesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtManufacturingYear = new System.Windows.Forms.TextBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbSuspensionType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "MY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 253);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(382, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(14, 304);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(382, 31);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(64, 32);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(331, 27);
            this.txtId.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(64, 79);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(331, 27);
            this.txtModel.TabIndex = 10;
            // 
            // txtManufacturingYear
            // 
            this.txtManufacturingYear.Location = new System.Drawing.Point(64, 123);
            this.txtManufacturingYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtManufacturingYear.Name = "txtManufacturingYear";
            this.txtManufacturingYear.Size = new System.Drawing.Size(331, 27);
            this.txtManufacturingYear.TabIndex = 11;
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Green"});
            this.cbColor.Location = new System.Drawing.Point(102, 165);
            this.cbColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(138, 28);
            this.cbColor.TabIndex = 12;
            // 
            // cbSuspensionType
            // 
            this.cbSuspensionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuspensionType.FormattingEnabled = true;
            this.cbSuspensionType.Items.AddRange(new object[] {
            "Front",
            "Rear",
            "Dual"});
            this.cbSuspensionType.Location = new System.Drawing.Point(102, 204);
            this.cbSuspensionType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSuspensionType.Name = "cbSuspensionType";
            this.cbSuspensionType.Size = new System.Drawing.Size(138, 28);
            this.cbSuspensionType.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Suspension:";
            // 
            // MountainBikesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 348);
            this.Controls.Add(this.cbSuspensionType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.txtManufacturingYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MountainBikesForm";
            this.Text = "MountainBikesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnUpdate;
        private TextBox txtId;
        private TextBox txtModel;
        private TextBox txtManufacturingYear;
        private ComboBox cbColor;
        private ComboBox cbSuspensionType;
        private Label label5;
    }
}