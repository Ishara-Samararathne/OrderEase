namespace OrderEase
{
    partial class OrderList_Form
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
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.orderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailGridView = new System.Windows.Forms.DataGridView();
            this.orderitemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersGridView
            // 
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNo,
            this.dateTime,
            this.subTotal});
            this.ordersGridView.Location = new System.Drawing.Point(45, 76);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.RowTemplate.Height = 25;
            this.ordersGridView.Size = new System.Drawing.Size(328, 233);
            this.ordersGridView.TabIndex = 0;
            this.ordersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersGridView_CellContentClick);
            this.ordersGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ordersGridView_MouseClick);
            // 
            // orderNo
            // 
            this.orderNo.HeaderText = "Order No";
            this.orderNo.Name = "orderNo";
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Date Time";
            this.dateTime.Name = "dateTime";
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "Sub Total";
            this.subTotal.Name = "subTotal";
            // 
            // orderDetailGridView
            // 
            this.orderDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderitemName,
            this.orderItemQuantity,
            this.orderItemPrice});
            this.orderDetailGridView.Location = new System.Drawing.Point(39, 380);
            this.orderDetailGridView.Name = "orderDetailGridView";
            this.orderDetailGridView.RowTemplate.Height = 25;
            this.orderDetailGridView.Size = new System.Drawing.Size(334, 256);
            this.orderDetailGridView.TabIndex = 1;
            // 
            // orderitemName
            // 
            this.orderitemName.HeaderText = "OrderItem Name";
            this.orderitemName.Name = "orderitemName";
            // 
            // orderItemQuantity
            // 
            this.orderItemQuantity.HeaderText = "Quantity";
            this.orderItemQuantity.Name = "orderItemQuantity";
            // 
            // orderItemPrice
            // 
            this.orderItemPrice.HeaderText = "Price";
            this.orderItemPrice.Name = "orderItemPrice";
            // 
            // OrderList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 663);
            this.Controls.Add(this.orderDetailGridView);
            this.Controls.Add(this.ordersGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderList_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderList_Form";
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView ordersGridView;
        private DataGridViewTextBoxColumn orderNo;
        private DataGridViewTextBoxColumn dateTime;
        private DataGridViewTextBoxColumn subTotal;
        private DataGridView orderDetailGridView;
        private DataGridViewTextBoxColumn orderitemName;
        private DataGridViewTextBoxColumn orderItemQuantity;
        private DataGridViewTextBoxColumn orderItemPrice;
    }
}