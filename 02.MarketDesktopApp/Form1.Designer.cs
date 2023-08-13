namespace _02.MarketDesktopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            receiptsToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            addProductToolStripMenuItem = new ToolStripMenuItem();
            txtBarcode = new TextBox();
            groupBox1 = new GroupBox();
            dgList = new DataGridView();
            Count = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            lbTotal = new Label();
            groupBox3 = new GroupBox();
            gbPayment = new GroupBox();
            btnCash = new Button();
            btnKK = new Button();
            txtPayment = new TextBox();
            dgPayment = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            groupBox6 = new GroupBox();
            groupBox5 = new GroupBox();
            btnComplete = new Button();
            btnReset = new Button();
            lbRemaing = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            gbPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayment).BeginInit();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { raporlarToolStripMenuItem, productsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1235, 28);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { receiptsToolStripMenuItem });
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(74, 24);
            raporlarToolStripMenuItem.Text = "Reports";
            // 
            // receiptsToolStripMenuItem
            // 
            receiptsToolStripMenuItem.Name = "receiptsToolStripMenuItem";
            receiptsToolStripMenuItem.Size = new Size(148, 26);
            receiptsToolStripMenuItem.Text = "Receipts";
            receiptsToolStripMenuItem.Click += receiptsToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProductToolStripMenuItem });
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(80, 24);
            productsToolStripMenuItem.Text = "Products";
            // 
            // addProductToolStripMenuItem
            // 
            addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            addProductToolStripMenuItem.Size = new Size(224, 26);
            addProductToolStripMenuItem.Text = "Products";
            addProductToolStripMenuItem.Click += addProductToolStripMenuItem_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Times New Roman", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBarcode.Location = new Point(6, 26);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(664, 62);
            txtBarcode.TabIndex = 14;
            txtBarcode.KeyPress += txtBarcode_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBarcode);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 108);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.BackgroundColor = SystemColors.ButtonFace;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Columns.AddRange(new DataGridViewColumn[] { Count, ProductName, Quantity, Price, TotalPrice });
            dgList.Location = new Point(6, 12);
            dgList.Name = "dgList";
            dgList.RowHeadersVisible = false;
            dgList.RowHeadersWidth = 51;
            dgList.RowTemplate.Height = 25;
            dgList.Size = new Size(664, 512);
            dgList.TabIndex = 0;
            // 
            // Count
            // 
            Count.HeaderText = "#";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.Width = 50;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 230;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgList);
            groupBox2.Location = new Point(12, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(676, 531);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // lbTotal
            // 
            lbTotal.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.ForeColor = Color.Brown;
            lbTotal.Location = new Point(6, 26);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(477, 62);
            lbTotal.TabIndex = 0;
            lbTotal.Text = "0,00 ₺";
            lbTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbTotal);
            groupBox3.Location = new Point(720, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(491, 108);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            // 
            // gbPayment
            // 
            gbPayment.Controls.Add(btnCash);
            gbPayment.Controls.Add(btnKK);
            gbPayment.Controls.Add(txtPayment);
            gbPayment.Location = new Point(720, 145);
            gbPayment.Name = "gbPayment";
            gbPayment.Size = new Size(491, 213);
            gbPayment.TabIndex = 18;
            gbPayment.TabStop = false;
            // 
            // btnCash
            // 
            btnCash.BackColor = Color.LightSteelBlue;
            btnCash.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnCash.Image = Properties.Resources.Money_icon;
            btnCash.Location = new Point(249, 113);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(238, 88);
            btnCash.TabIndex = 2;
            btnCash.UseVisualStyleBackColor = false;
            btnCash.Click += btnCash_Click;
            // 
            // btnKK
            // 
            btnKK.BackColor = Color.LightSteelBlue;
            btnKK.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnKK.Image = Properties.Resources._8168678_credit_card_payment_shopping_icon;
            btnKK.Location = new Point(8, 113);
            btnKK.Name = "btnKK";
            btnKK.Size = new Size(238, 88);
            btnKK.TabIndex = 1;
            btnKK.UseVisualStyleBackColor = false;
            btnKK.Click += btnKK_Click;
            // 
            // txtPayment
            // 
            txtPayment.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtPayment.ForeColor = Color.Teal;
            txtPayment.Location = new Point(8, 28);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(479, 76);
            txtPayment.TabIndex = 0;
            txtPayment.Text = "0";
            txtPayment.TextAlign = HorizontalAlignment.Center;
            // 
            // dgPayment
            // 
            dgPayment.AllowUserToAddRows = false;
            dgPayment.BackgroundColor = SystemColors.ButtonFace;
            dgPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayment.Columns.AddRange(new DataGridViewColumn[] { Type, Total });
            dgPayment.Location = new Point(8, 14);
            dgPayment.Name = "dgPayment";
            dgPayment.RowHeadersVisible = false;
            dgPayment.RowHeadersWidth = 51;
            dgPayment.RowTemplate.Height = 25;
            dgPayment.Size = new Size(477, 121);
            dgPayment.TabIndex = 1;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgPayment);
            groupBox6.Location = new Point(720, 364);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(489, 141);
            groupBox6.TabIndex = 19;
            groupBox6.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnComplete);
            groupBox5.Controls.Add(btnReset);
            groupBox5.Controls.Add(lbRemaing);
            groupBox5.Location = new Point(720, 511);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(491, 165);
            groupBox5.TabIndex = 20;
            groupBox5.TabStop = false;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.Lavender;
            btnComplete.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnComplete.Image = Properties.Resources._1930264_check_complete_done_green_success_icon;
            btnComplete.Location = new Point(250, 86);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(238, 72);
            btnComplete.TabIndex = 4;
            btnComplete.UseVisualStyleBackColor = false;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Lavender;
            btnReset.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = Color.Brown;
            btnReset.Image = Properties.Resources._1553096_letter_red_x_alphabet_letters_icon;
            btnReset.Location = new Point(6, 86);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(238, 72);
            btnReset.TabIndex = 3;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lbRemaing
            // 
            lbRemaing.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbRemaing.ForeColor = Color.Brown;
            lbRemaing.Location = new Point(8, 23);
            lbRemaing.Name = "lbRemaing";
            lbRemaing.Size = new Size(477, 60);
            lbRemaing.TabIndex = 1;
            lbRemaing.Text = "0,00 ₺";
            lbRemaing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 678);
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Controls.Add(gbPayment);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            gbPayment.ResumeLayout(false);
            gbPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayment).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private ToolStripMenuItem receiptsToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem addProductToolStripMenuItem;
        private TextBox txtBarcode;
        private GroupBox groupBox1;
        private DataGridView dgList;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalPrice;
        private Label lbTotal;
        private GroupBox groupBox3;
        private GroupBox gbPayment;
        private Button btnCash;
        private Button btnKK;
        private TextBox txtPayment;
        private DataGridView dgPayment;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Total;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Button btnComplete;
        private Button btnReset;
        private Label lbRemaing;
    }
}