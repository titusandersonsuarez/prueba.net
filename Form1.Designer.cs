namespace proyecto
{
    partial class tbProducMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgOrder = new System.Windows.Forms.DataGridView();
            this.dtgOrderDetails = new System.Windows.Forms.DataGridView();
            this.btNextDetails = new System.Windows.Forms.Button();
            this.btPreviusDetails = new System.Windows.Forms.Button();
            this.btSearchDetails = new System.Windows.Forms.Button();
            this.tbSearchDetails = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearchOrder = new System.Windows.Forms.Button();
            this.btPreviousOrder = new System.Windows.Forms.Button();
            this.btNextOrder = new System.Windows.Forms.Button();
            this.btAddOrder = new System.Windows.Forms.Button();
            this.btUpdateOrder = new System.Windows.Forms.Button();
            this.pDtw = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCancelDtw = new System.Windows.Forms.Button();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.tbProduc = new System.Windows.Forms.TextBox();
            this.btAddDtw = new System.Windows.Forms.Button();
            this.btAddDetails = new System.Windows.Forms.Button();
            this.lbOrder = new System.Windows.Forms.Label();
            this.lbDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pOrderDetails = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.numberOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalitems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderDetails)).BeginInit();
            this.pDtw.SuspendLayout();
            this.pOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgOrder
            // 
            this.dtgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberOrden,
            this.client,
            this.totalitems,
            this.total,
            this.createdorder});
            this.dtgOrder.Location = new System.Drawing.Point(24, 118);
            this.dtgOrder.Name = "dtgOrder";
            this.dtgOrder.Size = new System.Drawing.Size(593, 333);
            this.dtgOrder.TabIndex = 0;
            this.dtgOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtgOrderDetails
            // 
            this.dtgOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.qty,
            this.price,
            this.comments});
            this.dtgOrderDetails.Location = new System.Drawing.Point(38, 61);
            this.dtgOrderDetails.Name = "dtgOrderDetails";
            this.dtgOrderDetails.Size = new System.Drawing.Size(602, 269);
            this.dtgOrderDetails.TabIndex = 1;
            // 
            // btNextDetails
            // 
            this.btNextDetails.Location = new System.Drawing.Point(297, 336);
            this.btNextDetails.Name = "btNextDetails";
            this.btNextDetails.Size = new System.Drawing.Size(75, 23);
            this.btNextDetails.TabIndex = 2;
            this.btNextDetails.Text = "next";
            this.btNextDetails.UseVisualStyleBackColor = true;
            this.btNextDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPreviusDetails
            // 
            this.btPreviusDetails.Location = new System.Drawing.Point(387, 337);
            this.btPreviusDetails.Name = "btPreviusDetails";
            this.btPreviusDetails.Size = new System.Drawing.Size(75, 23);
            this.btPreviusDetails.TabIndex = 3;
            this.btPreviusDetails.Text = "Previus";
            this.btPreviusDetails.UseVisualStyleBackColor = true;
            this.btPreviusDetails.Click += new System.EventHandler(this.btPreviusDetails_Click);
            // 
            // btSearchDetails
            // 
            this.btSearchDetails.Location = new System.Drawing.Point(187, 336);
            this.btSearchDetails.Name = "btSearchDetails";
            this.btSearchDetails.Size = new System.Drawing.Size(75, 23);
            this.btSearchDetails.TabIndex = 4;
            this.btSearchDetails.Text = "search";
            this.btSearchDetails.UseVisualStyleBackColor = true;
            this.btSearchDetails.Click += new System.EventHandler(this.btSearchDetails_Click);
            // 
            // tbSearchDetails
            // 
            this.tbSearchDetails.Location = new System.Drawing.Point(38, 339);
            this.tbSearchDetails.Name = "tbSearchDetails";
            this.tbSearchDetails.Size = new System.Drawing.Size(123, 20);
            this.tbSearchDetails.TabIndex = 5;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(24, 459);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(181, 20);
            this.tbSearch.TabIndex = 9;
            // 
            // btSearchOrder
            // 
            this.btSearchOrder.Location = new System.Drawing.Point(211, 457);
            this.btSearchOrder.Name = "btSearchOrder";
            this.btSearchOrder.Size = new System.Drawing.Size(75, 23);
            this.btSearchOrder.TabIndex = 8;
            this.btSearchOrder.Text = "search";
            this.btSearchOrder.UseVisualStyleBackColor = true;
            this.btSearchOrder.Click += new System.EventHandler(this.btSearchOrder_Click);
            // 
            // btPreviousOrder
            // 
            this.btPreviousOrder.Location = new System.Drawing.Point(390, 459);
            this.btPreviousOrder.Name = "btPreviousOrder";
            this.btPreviousOrder.Size = new System.Drawing.Size(87, 23);
            this.btPreviousOrder.TabIndex = 7;
            this.btPreviousOrder.Text = "Previus";
            this.btPreviousOrder.UseVisualStyleBackColor = true;
            this.btPreviousOrder.Click += new System.EventHandler(this.btPreviousOrder_Click);
            // 
            // btNextOrder
            // 
            this.btNextOrder.Location = new System.Drawing.Point(292, 459);
            this.btNextOrder.Name = "btNextOrder";
            this.btNextOrder.Size = new System.Drawing.Size(92, 23);
            this.btNextOrder.TabIndex = 6;
            this.btNextOrder.Text = "next";
            this.btNextOrder.UseVisualStyleBackColor = true;
            this.btNextOrder.Click += new System.EventHandler(this.btNextOrder_Click);
            // 
            // btAddOrder
            // 
            this.btAddOrder.Location = new System.Drawing.Point(24, 72);
            this.btAddOrder.Name = "btAddOrder";
            this.btAddOrder.Size = new System.Drawing.Size(244, 23);
            this.btAddOrder.TabIndex = 10;
            this.btAddOrder.Text = " add";
            this.btAddOrder.UseVisualStyleBackColor = true;
            this.btAddOrder.Click += new System.EventHandler(this.button7_Click);
            // 
            // btUpdateOrder
            // 
            this.btUpdateOrder.Location = new System.Drawing.Point(274, 72);
            this.btUpdateOrder.Name = "btUpdateOrder";
            this.btUpdateOrder.Size = new System.Drawing.Size(343, 23);
            this.btUpdateOrder.TabIndex = 11;
            this.btUpdateOrder.Text = "uptade";
            this.btUpdateOrder.UseVisualStyleBackColor = true;
            this.btUpdateOrder.Click += new System.EventHandler(this.button8_Click);
            // 
            // pDtw
            // 
            this.pDtw.Controls.Add(this.label7);
            this.pDtw.Controls.Add(this.label6);
            this.pDtw.Controls.Add(this.label5);
            this.pDtw.Controls.Add(this.label4);
            this.pDtw.Controls.Add(this.btCancelDtw);
            this.pDtw.Controls.Add(this.tbQty);
            this.pDtw.Controls.Add(this.tbPrice);
            this.pDtw.Controls.Add(this.tbComments);
            this.pDtw.Controls.Add(this.tbProduc);
            this.pDtw.Controls.Add(this.btAddDtw);
            this.pDtw.Location = new System.Drawing.Point(731, 459);
            this.pDtw.Name = "pDtw";
            this.pDtw.Size = new System.Drawing.Size(457, 156);
            this.pDtw.TabIndex = 12;
            this.pDtw.Paint += new System.Windows.Forms.PaintEventHandler(this.pDtw_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "comments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "PRICE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "QTY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "product";
            // 
            // btCancelDtw
            // 
            this.btCancelDtw.Location = new System.Drawing.Point(233, 105);
            this.btCancelDtw.Name = "btCancelDtw";
            this.btCancelDtw.Size = new System.Drawing.Size(206, 23);
            this.btCancelDtw.TabIndex = 5;
            this.btCancelDtw.Text = "cancel";
            this.btCancelDtw.UseVisualStyleBackColor = true;
            this.btCancelDtw.Click += new System.EventHandler(this.btCancelDtw_Click);
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(127, 67);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(100, 20);
            this.tbQty.TabIndex = 4;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(233, 67);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 3;
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(339, 67);
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(100, 20);
            this.tbComments.TabIndex = 2;
            // 
            // tbProduc
            // 
            this.tbProduc.Location = new System.Drawing.Point(21, 67);
            this.tbProduc.Name = "tbProduc";
            this.tbProduc.Size = new System.Drawing.Size(100, 20);
            this.tbProduc.TabIndex = 1;
            // 
            // btAddDtw
            // 
            this.btAddDtw.Location = new System.Drawing.Point(21, 105);
            this.btAddDtw.Name = "btAddDtw";
            this.btAddDtw.Size = new System.Drawing.Size(206, 23);
            this.btAddDtw.TabIndex = 0;
            this.btAddDtw.Text = "add";
            this.btAddDtw.UseVisualStyleBackColor = true;
            this.btAddDtw.Click += new System.EventHandler(this.btAddDtw_Click);
            // 
            // btAddDetails
            // 
            this.btAddDetails.Location = new System.Drawing.Point(38, 13);
            this.btAddDetails.Name = "btAddDetails";
            this.btAddDetails.Size = new System.Drawing.Size(139, 23);
            this.btAddDetails.TabIndex = 13;
            this.btAddDetails.Text = "add";
            this.btAddDetails.UseVisualStyleBackColor = true;
            this.btAddDetails.Click += new System.EventHandler(this.btAddDetails_Click);
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Location = new System.Drawing.Point(24, 102);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(46, 13);
            this.lbOrder.TabIndex = 15;
            this.lbOrder.Text = "ORDER";
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Location = new System.Drawing.Point(35, 45);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(94, 13);
            this.lbDetails.TabIndex = 16;
            this.lbDetails.Text = "ORDER DETAILS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "supermarket fruits";
            // 
            // pOrderDetails
            // 
            this.pOrderDetails.Controls.Add(this.btnClose);
            this.pOrderDetails.Controls.Add(this.btSave);
            this.pOrderDetails.Controls.Add(this.btAddDetails);
            this.pOrderDetails.Controls.Add(this.dtgOrderDetails);
            this.pOrderDetails.Controls.Add(this.btNextDetails);
            this.pOrderDetails.Controls.Add(this.btPreviusDetails);
            this.pOrderDetails.Controls.Add(this.lbDetails);
            this.pOrderDetails.Controls.Add(this.btSearchDetails);
            this.pOrderDetails.Controls.Add(this.tbSearchDetails);
            this.pOrderDetails.Location = new System.Drawing.Point(731, 78);
            this.pOrderDetails.Name = "pOrderDetails";
            this.pOrderDetails.Size = new System.Drawing.Size(684, 373);
            this.pOrderDetails.TabIndex = 20;
            this.pOrderDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pOrderDetails_Paint);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(187, 14);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(89, 23);
            this.btSave.TabIndex = 17;
            this.btSave.Text = "save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(297, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // numberOrden
            // 
            this.numberOrden.HeaderText = "number of order";
            this.numberOrden.Name = "numberOrden";
            this.numberOrden.Width = 50;
            // 
            // client
            // 
            this.client.HeaderText = "client";
            this.client.Name = "client";
            this.client.Width = 50;
            // 
            // totalitems
            // 
            this.totalitems.HeaderText = "Total items";
            this.totalitems.Name = "totalitems";
            this.totalitems.Width = 50;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.Width = 200;
            // 
            // createdorder
            // 
            this.createdorder.HeaderText = "created order";
            this.createdorder.Name = "createdorder";
            this.createdorder.Width = 200;
            // 
            // product
            // 
            this.product.HeaderText = "product";
            this.product.Name = "product";
            // 
            // qty
            // 
            this.qty.HeaderText = "qty";
            this.qty.Name = "qty";
            this.qty.Width = 50;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.Width = 200;
            // 
            // comments
            // 
            this.comments.HeaderText = "comments";
            this.comments.Name = "comments";
            this.comments.Width = 200;
            // 
            // tbProducMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 683);
            this.Controls.Add(this.pOrderDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.pDtw);
            this.Controls.Add(this.btUpdateOrder);
            this.Controls.Add(this.btAddOrder);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btSearchOrder);
            this.Controls.Add(this.btNextOrder);
            this.Controls.Add(this.btPreviousOrder);
            this.Controls.Add(this.dtgOrder);
            this.Name = "tbProducMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderDetails)).EndInit();
            this.pDtw.ResumeLayout(false);
            this.pDtw.PerformLayout();
            this.pOrderDetails.ResumeLayout(false);
            this.pOrderDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOrder;
        private System.Windows.Forms.DataGridView dtgOrderDetails;
        private System.Windows.Forms.Button btNextDetails;
        private System.Windows.Forms.Button btPreviusDetails;
        private System.Windows.Forms.Button btSearchDetails;
        private System.Windows.Forms.TextBox tbSearchDetails;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearchOrder;
        private System.Windows.Forms.Button btPreviousOrder;
        private System.Windows.Forms.Button btNextOrder;
        private System.Windows.Forms.Button btAddOrder;
        private System.Windows.Forms.Button btUpdateOrder;
        private System.Windows.Forms.Panel pDtw;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.TextBox tbProduc;
        private System.Windows.Forms.Button btAddDtw;
        private System.Windows.Forms.Button btAddDetails;
        private System.Windows.Forms.Button btCancelDtw;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pOrderDetails;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalitems;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments;
    }
}

