namespace _02.MarketDesktopApp
{
    partial class Form3
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgProducts = new DataGridView();
            Count = new DataGridViewTextBoxColumn();
            PId = new DataGridViewTextBoxColumn();
            PName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            BtnEdit = new DataGridViewButtonColumn();
            BtnRemove = new DataGridViewButtonColumn();
            tabPage2 = new TabPage();
            btnSave = new Button();
            txtPrice = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(971, 480);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgProducts);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(963, 447);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Products";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgProducts
            // 
            dgProducts.AllowUserToAddRows = false;
            dgProducts.AllowUserToResizeRows = false;
            dgProducts.BackgroundColor = SystemColors.Control;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { Count, PId, PName, Price, BtnEdit, BtnRemove });
            dgProducts.Dock = DockStyle.Fill;
            dgProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgProducts.Location = new Point(3, 3);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersVisible = false;
            dgProducts.RowHeadersWidth = 51;
            dgProducts.RowTemplate.Height = 25;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(957, 441);
            dgProducts.TabIndex = 0;
            dgProducts.CellClick += dgProducts_CellClick;
            // 
            // Count
            // 
            Count.HeaderText = "#";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.Width = 125;
            // 
            // PId
            // 
            PId.HeaderText = "Id";
            PId.MinimumWidth = 6;
            PId.Name = "PId";
            PId.Visible = false;
            PId.Width = 125;
            // 
            // PName
            // 
            PName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PName.HeaderText = "Name";
            PName.MinimumWidth = 6;
            PName.Name = "PName";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "c2";
            Price.DefaultCellStyle = dataGridViewCellStyle1;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // BtnEdit
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Edit";
            BtnEdit.DefaultCellStyle = dataGridViewCellStyle2;
            BtnEdit.HeaderText = "Operations";
            BtnEdit.MinimumWidth = 6;
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Resizable = DataGridViewTriState.True;
            BtnEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            BtnEdit.Width = 125;
            // 
            // BtnRemove
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Maroon;
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.NullValue = "Remove";
            dataGridViewCellStyle3.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            BtnRemove.DefaultCellStyle = dataGridViewCellStyle3;
            BtnRemove.HeaderText = "Operations";
            BtnRemove.MinimumWidth = 6;
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Width = 125;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(txtPrice);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtName);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(963, 447);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Product Add";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(216, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(283, 42);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(215, 145);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(284, 27);
            txtPrice.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 111);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // txtName
            // 
            txtName.Location = new Point(210, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(289, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 480);
            Controls.Add(tabControl1);
            Name = "Form3";
            Text = "Form3";
            FormClosing += Form3_FormClosing;
            FormClosed += Form3_FormClosed;
            Load += Form3_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgProducts;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn PId;
        private DataGridViewTextBoxColumn PName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnRemove;
        private TabPage tabPage2;
        private Button btnSave;
        private TextBox txtPrice;
        private Label label2;
        private TextBox txtName;
        private Label label1;
    }
}