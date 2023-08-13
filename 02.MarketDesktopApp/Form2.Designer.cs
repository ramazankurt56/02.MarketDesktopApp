namespace _02.MarketDesktopApp
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dgReceiptPayments = new DataGridView();
            RPCount = new DataGridViewTextBoxColumn();
            RPType = new DataGridViewTextBoxColumn();
            RPAmount = new DataGridViewTextBoxColumn();
            dgReceiptDetails = new DataGridView();
            RDCount = new DataGridViewTextBoxColumn();
            RDProductName = new DataGridViewTextBoxColumn();
            RDQuantity = new DataGridViewTextBoxColumn();
            RDPrice = new DataGridViewTextBoxColumn();
            RDTotal = new DataGridViewTextBoxColumn();
            dgReceipts = new DataGridView();
            Count = new DataGridViewTextBoxColumn();
            RId = new DataGridViewTextBoxColumn();
            ReceiptNumber = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Payment = new DataGridViewTextBoxColumn();
            Remaining = new DataGridViewTextBoxColumn();
            BtnPrint = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgReceiptPayments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgReceiptDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgReceipts).BeginInit();
            SuspendLayout();
            // 
            // dgReceiptPayments
            // 
            dgReceiptPayments.AllowUserToAddRows = false;
            dgReceiptPayments.BackgroundColor = SystemColors.ButtonFace;
            dgReceiptPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReceiptPayments.Columns.AddRange(new DataGridViewColumn[] { RPCount, RPType, RPAmount });
            dgReceiptPayments.Location = new Point(699, 265);
            dgReceiptPayments.Name = "dgReceiptPayments";
            dgReceiptPayments.RowHeadersVisible = false;
            dgReceiptPayments.RowHeadersWidth = 51;
            dgReceiptPayments.RowTemplate.Height = 25;
            dgReceiptPayments.Size = new Size(348, 202);
            dgReceiptPayments.TabIndex = 5;
            // 
            // RPCount
            // 
            RPCount.HeaderText = "#";
            RPCount.MinimumWidth = 6;
            RPCount.Name = "RPCount";
            RPCount.Width = 125;
            // 
            // RPType
            // 
            RPType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RPType.HeaderText = "Type";
            RPType.MinimumWidth = 6;
            RPType.Name = "RPType";
            // 
            // RPAmount
            // 
            RPAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "c2";
            RPAmount.DefaultCellStyle = dataGridViewCellStyle1;
            RPAmount.HeaderText = "Amount";
            RPAmount.MinimumWidth = 6;
            RPAmount.Name = "RPAmount";
            // 
            // dgReceiptDetails
            // 
            dgReceiptDetails.AllowUserToAddRows = false;
            dgReceiptDetails.AllowUserToResizeRows = false;
            dgReceiptDetails.BackgroundColor = SystemColors.ButtonFace;
            dgReceiptDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReceiptDetails.Columns.AddRange(new DataGridViewColumn[] { RDCount, RDProductName, RDQuantity, RDPrice, RDTotal });
            dgReceiptDetails.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgReceiptDetails.Location = new Point(2, 265);
            dgReceiptDetails.Name = "dgReceiptDetails";
            dgReceiptDetails.RowHeadersVisible = false;
            dgReceiptDetails.RowHeadersWidth = 51;
            dgReceiptDetails.RowTemplate.Height = 25;
            dgReceiptDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgReceiptDetails.Size = new Size(672, 202);
            dgReceiptDetails.TabIndex = 4;
            // 
            // RDCount
            // 
            RDCount.HeaderText = "#";
            RDCount.MinimumWidth = 6;
            RDCount.Name = "RDCount";
            RDCount.Width = 125;
            // 
            // RDProductName
            // 
            RDProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RDProductName.HeaderText = "Product Name";
            RDProductName.MinimumWidth = 6;
            RDProductName.Name = "RDProductName";
            // 
            // RDQuantity
            // 
            dataGridViewCellStyle2.Format = "c2";
            RDQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            RDQuantity.HeaderText = "Quantity";
            RDQuantity.MinimumWidth = 6;
            RDQuantity.Name = "RDQuantity";
            RDQuantity.Width = 125;
            // 
            // RDPrice
            // 
            RDPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "c2";
            RDPrice.DefaultCellStyle = dataGridViewCellStyle3;
            RDPrice.HeaderText = "Price";
            RDPrice.MinimumWidth = 6;
            RDPrice.Name = "RDPrice";
            // 
            // RDTotal
            // 
            RDTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "c2";
            RDTotal.DefaultCellStyle = dataGridViewCellStyle4;
            RDTotal.HeaderText = "Total";
            RDTotal.MinimumWidth = 6;
            RDTotal.Name = "RDTotal";
            // 
            // dgReceipts
            // 
            dgReceipts.AllowUserToAddRows = false;
            dgReceipts.AllowUserToDeleteRows = false;
            dgReceipts.AllowUserToResizeRows = false;
            dgReceipts.BackgroundColor = SystemColors.ButtonFace;
            dgReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReceipts.Columns.AddRange(new DataGridViewColumn[] { Count, RId, ReceiptNumber, Date, Total, Payment, Remaining, BtnPrint });
            dgReceipts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgReceipts.Location = new Point(2, 12);
            dgReceipts.Name = "dgReceipts";
            dgReceipts.RowHeadersVisible = false;
            dgReceipts.RowHeadersWidth = 51;
            dgReceipts.RowTemplate.Height = 25;
            dgReceipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgReceipts.Size = new Size(1045, 237);
            dgReceipts.TabIndex = 3;
            dgReceipts.CellContentClick += dgReceipts_CellContentClick;
            dgReceipts.Click += dgReceipts_Click;
            // 
            // Count
            // 
            Count.HeaderText = "#";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.Width = 50;
            // 
            // RId
            // 
            RId.HeaderText = "Id";
            RId.MinimumWidth = 6;
            RId.Name = "RId";
            RId.Visible = false;
            RId.Width = 125;
            // 
            // ReceiptNumber
            // 
            ReceiptNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ReceiptNumber.HeaderText = "ReceiptNumber";
            ReceiptNumber.MinimumWidth = 6;
            ReceiptNumber.Name = "ReceiptNumber";
            ReceiptNumber.Width = 200;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Format = "F";
            dataGridViewCellStyle5.NullValue = null;
            Date.DefaultCellStyle = dataGridViewCellStyle5;
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 300;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "c2";
            dataGridViewCellStyle6.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle6;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            // 
            // Payment
            // 
            Payment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Format = "c2";
            Payment.DefaultCellStyle = dataGridViewCellStyle7;
            Payment.HeaderText = "Payment";
            Payment.MinimumWidth = 6;
            Payment.Name = "Payment";
            // 
            // Remaining
            // 
            Remaining.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Format = "c2";
            Remaining.DefaultCellStyle = dataGridViewCellStyle8;
            Remaining.HeaderText = "Remaining";
            Remaining.MinimumWidth = 6;
            Remaining.Name = "Remaining";
            // 
            // BtnPrint
            // 
            BtnPrint.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = "Print";
            BtnPrint.DefaultCellStyle = dataGridViewCellStyle9;
            BtnPrint.HeaderText = "Operations";
            BtnPrint.MinimumWidth = 6;
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Resizable = DataGridViewTriState.True;
            BtnPrint.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 490);
            Controls.Add(dgReceiptPayments);
            Controls.Add(dgReceiptDetails);
            Controls.Add(dgReceipts);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgReceiptPayments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgReceiptDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgReceipts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgReceiptPayments;
        private DataGridViewTextBoxColumn RPCount;
        private DataGridViewTextBoxColumn RPType;
        private DataGridViewTextBoxColumn RPAmount;
        private DataGridView dgReceiptDetails;
        private DataGridViewTextBoxColumn RDCount;
        private DataGridViewTextBoxColumn RDProductName;
        private DataGridViewTextBoxColumn RDQuantity;
        private DataGridViewTextBoxColumn RDPrice;
        private DataGridViewTextBoxColumn RDTotal;
        private DataGridView dgReceipts;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn RId;
        private DataGridViewTextBoxColumn ReceiptNumber;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Payment;
        private DataGridViewTextBoxColumn Remaining;
        private DataGridViewButtonColumn BtnPrint;
    }
}