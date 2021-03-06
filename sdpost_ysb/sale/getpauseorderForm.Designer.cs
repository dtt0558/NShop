﻿namespace NShop.sale
{
    partial class getpauseorderForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivablePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPostCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coupon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MemberNo,
            this.FlowNo,
            this.GoodsNum,
            this.OriginalPrice,
            this.Discount,
            this.NCSC,
            this.ReceivablePrice,
            this.Received,
            this.Change,
            this.DiscountRate,
            this.Profit,
            this.PayType,
            this.Cash,
            this.BandCard,
            this.IsPostCard,
            this.Coupon,
            this.ValueCard,
            this.ValueCardNo,
            this.CreateTime,
            this.Memo,
            this.UpdateTime,
            this.Modifier,
            this.Status,
            this.Scores});
            this.dataGridView1.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(640, 275);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "订单号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // MemberNo
            // 
            this.MemberNo.DataPropertyName = "MemberNo";
            this.MemberNo.HeaderText = "会员号";
            this.MemberNo.Name = "MemberNo";
            this.MemberNo.Visible = false;
            // 
            // FlowNo
            // 
            this.FlowNo.DataPropertyName = "FlowNo";
            this.FlowNo.FillWeight = 80F;
            this.FlowNo.HeaderText = "订单流水号";
            this.FlowNo.MinimumWidth = 10;
            this.FlowNo.Name = "FlowNo";
            this.FlowNo.ReadOnly = true;
            // 
            // GoodsNum
            // 
            this.GoodsNum.DataPropertyName = "GoodsNum";
            this.GoodsNum.FillWeight = 50F;
            this.GoodsNum.HeaderText = "商品数量";
            this.GoodsNum.Name = "GoodsNum";
            this.GoodsNum.ReadOnly = true;
            // 
            // OriginalPrice
            // 
            this.OriginalPrice.DataPropertyName = "OriginalPrice";
            this.OriginalPrice.HeaderText = "原始价格";
            this.OriginalPrice.Name = "OriginalPrice";
            this.OriginalPrice.ReadOnly = true;
            this.OriginalPrice.Visible = false;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "总优惠金额";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Visible = false;
            // 
            // NCSC
            // 
            this.NCSC.DataPropertyName = "NCSC";
            this.NCSC.HeaderText = "抹零";
            this.NCSC.Name = "NCSC";
            this.NCSC.ReadOnly = true;
            this.NCSC.Visible = false;
            // 
            // ReceivablePrice
            // 
            this.ReceivablePrice.DataPropertyName = "ReceivablePrice";
            this.ReceivablePrice.FillWeight = 50F;
            this.ReceivablePrice.HeaderText = "订单金额";
            this.ReceivablePrice.Name = "ReceivablePrice";
            this.ReceivablePrice.ReadOnly = true;
            // 
            // Received
            // 
            this.Received.DataPropertyName = "Received";
            this.Received.HeaderText = "实收金额";
            this.Received.Name = "Received";
            this.Received.ReadOnly = true;
            this.Received.Visible = false;
            // 
            // Change
            // 
            this.Change.DataPropertyName = "Change";
            this.Change.HeaderText = "找零";
            this.Change.Name = "Change";
            this.Change.ReadOnly = true;
            this.Change.Visible = false;
            // 
            // DiscountRate
            // 
            this.DiscountRate.DataPropertyName = "DiscountRate";
            this.DiscountRate.HeaderText = "整单折扣率";
            this.DiscountRate.Name = "DiscountRate";
            this.DiscountRate.Visible = false;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            this.Profit.HeaderText = "利润额";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Visible = false;
            // 
            // PayType
            // 
            this.PayType.DataPropertyName = "PayType";
            this.PayType.HeaderText = "支付类型";
            this.PayType.Name = "PayType";
            this.PayType.ReadOnly = true;
            this.PayType.Visible = false;
            // 
            // Cash
            // 
            this.Cash.DataPropertyName = "Cash";
            this.Cash.HeaderText = "现金";
            this.Cash.Name = "Cash";
            this.Cash.ReadOnly = true;
            this.Cash.Visible = false;
            // 
            // BandCard
            // 
            this.BandCard.DataPropertyName = "BandCard";
            this.BandCard.HeaderText = "银行卡";
            this.BandCard.Name = "BandCard";
            this.BandCard.ReadOnly = true;
            this.BandCard.Visible = false;
            // 
            // IsPostCard
            // 
            this.IsPostCard.DataPropertyName = "IsPostCard";
            this.IsPostCard.HeaderText = "是否绿卡";
            this.IsPostCard.Name = "IsPostCard";
            this.IsPostCard.ReadOnly = true;
            this.IsPostCard.Visible = false;
            // 
            // Coupon
            // 
            this.Coupon.DataPropertyName = "Coupon";
            this.Coupon.HeaderText = "优惠卷";
            this.Coupon.Name = "Coupon";
            this.Coupon.ReadOnly = true;
            this.Coupon.Visible = false;
            // 
            // ValueCard
            // 
            this.ValueCard.DataPropertyName = "ValueCard";
            this.ValueCard.HeaderText = "储值卡";
            this.ValueCard.Name = "ValueCard";
            this.ValueCard.ReadOnly = true;
            this.ValueCard.Visible = false;
            // 
            // ValueCardNo
            // 
            this.ValueCardNo.DataPropertyName = "ValueCardNo";
            this.ValueCardNo.HeaderText = "储值卡号";
            this.ValueCardNo.Name = "ValueCardNo";
            this.ValueCardNo.Visible = false;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.FillWeight = 80F;
            this.CreateTime.HeaderText = "挂单时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // Memo
            // 
            this.Memo.DataPropertyName = "Memo";
            this.Memo.FillWeight = 80F;
            this.Memo.HeaderText = "备注";
            this.Memo.Name = "Memo";
            this.Memo.ReadOnly = true;
            // 
            // UpdateTime
            // 
            this.UpdateTime.DataPropertyName = "UpdateTime";
            this.UpdateTime.HeaderText = "修改时间";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.ReadOnly = true;
            this.UpdateTime.Visible = false;
            // 
            // Modifier
            // 
            this.Modifier.DataPropertyName = "Modifier";
            this.Modifier.HeaderText = "修改人";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // Scores
            // 
            this.Scores.DataPropertyName = "Scores";
            this.Scores.HeaderText = "积分";
            this.Scores.Name = "Scores";
            this.Scores.Visible = false;
            // 
            // getpauseorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 275);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "getpauseorderForm";
            this.Text = "选择代售订单（Enter选择，Esc取消）";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivablePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Received;
        private System.Windows.Forms.DataGridViewTextBoxColumn Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPostCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coupon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scores;
    }
}