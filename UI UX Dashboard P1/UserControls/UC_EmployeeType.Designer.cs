namespace HotelManagementSystem.UserControls
{
    partial class UC_EmployeeType
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowLocked = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvEmployeeType = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEdit.Location = new System.Drawing.Point(140, 55);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 41);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Thistle;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnShowAll.Location = new System.Drawing.Point(861, 55);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(127, 41);
            this.btnShowAll.TabIndex = 14;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(675, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Show Actived";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnShowLocked
            // 
            this.btnShowLocked.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnShowLocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLocked.ForeColor = System.Drawing.Color.DarkRed;
            this.btnShowLocked.Location = new System.Drawing.Point(488, 55);
            this.btnShowLocked.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowLocked.Name = "btnShowLocked";
            this.btnShowLocked.Size = new System.Drawing.Size(183, 41);
            this.btnShowLocked.TabIndex = 16;
            this.btnShowLocked.Text = "Show Locked";
            this.btnShowLocked.UseVisualStyleBackColor = false;
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.YellowGreen;
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnActive.Location = new System.Drawing.Point(372, 55);
            this.btnActive.Margin = new System.Windows.Forms.Padding(4);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(112, 41);
            this.btnActive.TabIndex = 17;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.LightCoral;
            this.btnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLock.Location = new System.Drawing.Point(256, 55);
            this.btnLock.Margin = new System.Windows.Forms.Padding(4);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(112, 41);
            this.btnLock.TabIndex = 18;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Location = new System.Drawing.Point(24, 55);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 41);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvEmployeeType
            // 
            this.dgvEmployeeType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeType.Location = new System.Drawing.Point(0, 156);
            this.dgvEmployeeType.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployeeType.Name = "dgvEmployeeType";
            this.dgvEmployeeType.RowHeadersWidth = 51;
            this.dgvEmployeeType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeType.Size = new System.Drawing.Size(1524, 698);
            this.dgvEmployeeType.TabIndex = 12;
            this.dgvEmployeeType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeType_CellContentClick);
            this.dgvEmployeeType.Click += new System.EventHandler(this.dgvEmployeeType_Click);
            // 
            // UC_EmployeeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowLocked);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvEmployeeType);
            this.Name = "UC_EmployeeType";
            this.Size = new System.Drawing.Size(1528, 854);
            this.Load += new System.EventHandler(this.UC_EmployeeType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowLocked;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.DataGridView dgvEmployeeType;
    }
}
