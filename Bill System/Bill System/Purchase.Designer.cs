namespace Bill_System
{
    partial class Purchase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChkOut_Btn = new System.Windows.Forms.Button();
            this.AddtoCart_Btn = new System.Windows.Forms.Button();
            this.CartView = new System.Windows.Forms.DataGridView();
            this.ClearCart_Btn = new System.Windows.Forms.Button();
            this.Rate_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Qty_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Item_CB = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BillNo_Lbl = new System.Windows.Forms.Label();
            this.Bill_GV = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalAmount_Lbl = new System.Windows.Forms.Label();
            this.TotalItems_Lbl = new System.Windows.Forms.Label();
            this.Date_Lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Print_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChkOut_Btn);
            this.panel1.Controls.Add(this.AddtoCart_Btn);
            this.panel1.Controls.Add(this.CartView);
            this.panel1.Controls.Add(this.ClearCart_Btn);
            this.panel1.Controls.Add(this.Rate_TB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Qty_TB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Item_CB);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 449);
            this.panel1.TabIndex = 0;
            // 
            // ChkOut_Btn
            // 
            this.ChkOut_Btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkOut_Btn.Location = new System.Drawing.Point(319, 400);
            this.ChkOut_Btn.Name = "ChkOut_Btn";
            this.ChkOut_Btn.Size = new System.Drawing.Size(112, 35);
            this.ChkOut_Btn.TabIndex = 11;
            this.ChkOut_Btn.Text = "Check Out";
            this.ChkOut_Btn.UseVisualStyleBackColor = true;
            this.ChkOut_Btn.Click += new System.EventHandler(this.ChkOut_Btn_Click);
            // 
            // AddtoCart_Btn
            // 
            this.AddtoCart_Btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddtoCart_Btn.Location = new System.Drawing.Point(187, 400);
            this.AddtoCart_Btn.Name = "AddtoCart_Btn";
            this.AddtoCart_Btn.Size = new System.Drawing.Size(112, 35);
            this.AddtoCart_Btn.TabIndex = 10;
            this.AddtoCart_Btn.Text = "Add To Cart";
            this.AddtoCart_Btn.UseVisualStyleBackColor = true;
            this.AddtoCart_Btn.Click += new System.EventHandler(this.AddtoCart_Btn_Click);
            // 
            // CartView
            // 
            this.CartView.AllowUserToAddRows = false;
            this.CartView.AllowUserToDeleteRows = false;
            this.CartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartView.Location = new System.Drawing.Point(22, 157);
            this.CartView.Name = "CartView";
            this.CartView.ReadOnly = true;
            this.CartView.Size = new System.Drawing.Size(444, 214);
            this.CartView.TabIndex = 9;
            // 
            // ClearCart_Btn
            // 
            this.ClearCart_Btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCart_Btn.Location = new System.Drawing.Point(55, 400);
            this.ClearCart_Btn.Name = "ClearCart_Btn";
            this.ClearCart_Btn.Size = new System.Drawing.Size(112, 35);
            this.ClearCart_Btn.TabIndex = 8;
            this.ClearCart_Btn.Text = "Clear Cart";
            this.ClearCart_Btn.UseVisualStyleBackColor = true;
            this.ClearCart_Btn.Click += new System.EventHandler(this.ClearCart_Btn_Click);
            // 
            // Rate_TB
            // 
            this.Rate_TB.Enabled = false;
            this.Rate_TB.Location = new System.Drawing.Point(402, 71);
            this.Rate_TB.Name = "Rate_TB";
            this.Rate_TB.Size = new System.Drawing.Size(64, 20);
            this.Rate_TB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rate";
            // 
            // Qty_TB
            // 
            this.Qty_TB.Location = new System.Drawing.Point(93, 115);
            this.Qty_TB.Name = "Qty_TB";
            this.Qty_TB.Size = new System.Drawing.Size(247, 20);
            this.Qty_TB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point of Sales";
            // 
            // Item_CB
            // 
            this.Item_CB.FormattingEnabled = true;
            this.Item_CB.Items.AddRange(new object[] {
            "Pepsi",
            "Lays",
            "Coffee",
            "Suger",
            "Floor",
            "Popcorn",
            "Juice",
            "Chocolate"});
            this.Item_CB.Location = new System.Drawing.Point(93, 70);
            this.Item_CB.Name = "Item_CB";
            this.Item_CB.Size = new System.Drawing.Size(247, 21);
            this.Item_CB.TabIndex = 0;
            this.Item_CB.SelectedIndexChanged += new System.EventHandler(this.Item_CB_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Print_Btn);
            this.panel2.Controls.Add(this.Date_Lbl);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.TotalItems_Lbl);
            this.panel2.Controls.Add(this.TotalAmount_Lbl);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Bill_GV);
            this.panel2.Controls.Add(this.BillNo_Lbl);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(495, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 449);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(121, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 48);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bill";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(124, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bill No.";
            // 
            // BillNo_Lbl
            // 
            this.BillNo_Lbl.AutoSize = true;
            this.BillNo_Lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BillNo_Lbl.Location = new System.Drawing.Point(208, 86);
            this.BillNo_Lbl.Name = "BillNo_Lbl";
            this.BillNo_Lbl.Size = new System.Drawing.Size(0, 19);
            this.BillNo_Lbl.TabIndex = 2;
            // 
            // Bill_GV
            // 
            this.Bill_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bill_GV.Location = new System.Drawing.Point(8, 117);
            this.Bill_GV.Name = "Bill_GV";
            this.Bill_GV.Size = new System.Drawing.Size(286, 272);
            this.Bill_GV.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(136, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(136, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Total Items";
            // 
            // TotalAmount_Lbl
            // 
            this.TotalAmount_Lbl.AutoSize = true;
            this.TotalAmount_Lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.TotalAmount_Lbl.Location = new System.Drawing.Point(240, 398);
            this.TotalAmount_Lbl.Name = "TotalAmount_Lbl";
            this.TotalAmount_Lbl.Size = new System.Drawing.Size(0, 19);
            this.TotalAmount_Lbl.TabIndex = 6;
            // 
            // TotalItems_Lbl
            // 
            this.TotalItems_Lbl.AutoSize = true;
            this.TotalItems_Lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.TotalItems_Lbl.Location = new System.Drawing.Point(240, 421);
            this.TotalItems_Lbl.Name = "TotalItems_Lbl";
            this.TotalItems_Lbl.Size = new System.Drawing.Size(0, 19);
            this.TotalItems_Lbl.TabIndex = 7;
            // 
            // Date_Lbl
            // 
            this.Date_Lbl.AutoSize = true;
            this.Date_Lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Date_Lbl.Location = new System.Drawing.Point(208, 63);
            this.Date_Lbl.Name = "Date_Lbl";
            this.Date_Lbl.Size = new System.Drawing.Size(0, 19);
            this.Date_Lbl.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(124, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Print Date";
            // 
            // Print_Btn
            // 
            this.Print_Btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Btn.Location = new System.Drawing.Point(10, 400);
            this.Print_Btn.Name = "Print_Btn";
            this.Print_Btn.Size = new System.Drawing.Size(112, 35);
            this.Print_Btn.TabIndex = 12;
            this.Print_Btn.Text = "Print";
            this.Print_Btn.UseVisualStyleBackColor = true;
            this.Print_Btn.Click += new System.EventHandler(this.Print_Btn_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChkOut_Btn;
        private System.Windows.Forms.Button AddtoCart_Btn;
        private System.Windows.Forms.DataGridView CartView;
        private System.Windows.Forms.Button ClearCart_Btn;
        private System.Windows.Forms.TextBox Rate_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Qty_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Item_CB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalItems_Lbl;
        private System.Windows.Forms.Label TotalAmount_Lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Bill_GV;
        private System.Windows.Forms.Label BillNo_Lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Date_Lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Print_Btn;
    }
}