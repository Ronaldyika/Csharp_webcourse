namespace My_crud_implementation
{
    partial class Yika
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
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnMarchant = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.bgholder = new System.Windows.Forms.GroupBox();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCustomerCrud = new System.Windows.Forms.Button();
            this.btnMarchantCrud = new System.Windows.Forms.Button();
            this.btnPaymentCrud = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPayment.Location = new System.Drawing.Point(31, 228);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnMarchant
            // 
            this.btnMarchant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMarchant.Location = new System.Drawing.Point(31, 146);
            this.btnMarchant.Name = "btnMarchant";
            this.btnMarchant.Size = new System.Drawing.Size(75, 23);
            this.btnMarchant.TabIndex = 0;
            this.btnMarchant.Text = "Marchant";
            this.btnMarchant.UseVisualStyleBackColor = false;
            this.btnMarchant.Click += new System.EventHandler(this.btnMarchant_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCustomer.Location = new System.Drawing.Point(31, 309);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // bgholder
            // 
            this.bgholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bgholder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bgholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bgholder.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bgholder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgholder.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgholder.Location = new System.Drawing.Point(1, 1);
            this.bgholder.Name = "bgholder";
            this.bgholder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bgholder.Size = new System.Drawing.Size(787, 77);
            this.bgholder.TabIndex = 4;
            this.bgholder.TabStop = false;
            this.bgholder.Text = "Transactions";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(188, 99);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.Size = new System.Drawing.Size(571, 283);
            this.dgvTransactions.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "TransactionTable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Proceed to perform CRUD on>>";
            // 
            // btnCustomerCrud
            // 
            this.btnCustomerCrud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerCrud.Location = new System.Drawing.Point(571, 407);
            this.btnCustomerCrud.Name = "btnCustomerCrud";
            this.btnCustomerCrud.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerCrud.TabIndex = 5;
            this.btnCustomerCrud.Text = "Customer.";
            this.btnCustomerCrud.UseVisualStyleBackColor = true;
            this.btnCustomerCrud.Click += new System.EventHandler(this.btnCustomerCrud_Click);
            // 
            // btnMarchantCrud
            // 
            this.btnMarchantCrud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarchantCrud.Location = new System.Drawing.Point(374, 407);
            this.btnMarchantCrud.Name = "btnMarchantCrud";
            this.btnMarchantCrud.Size = new System.Drawing.Size(75, 23);
            this.btnMarchantCrud.TabIndex = 3;
            this.btnMarchantCrud.Text = "Marchant.";
            this.btnMarchantCrud.UseVisualStyleBackColor = true;
            this.btnMarchantCrud.Click += new System.EventHandler(this.btnMarchantCrud_Click);
            // 
            // btnPaymentCrud
            // 
            this.btnPaymentCrud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaymentCrud.Location = new System.Drawing.Point(468, 407);
            this.btnPaymentCrud.Name = "btnPaymentCrud";
            this.btnPaymentCrud.Size = new System.Drawing.Size(75, 23);
            this.btnPaymentCrud.TabIndex = 4;
            this.btnPaymentCrud.Text = "Payment.";
            this.btnPaymentCrud.UseVisualStyleBackColor = true;
            this.btnPaymentCrud.Click += new System.EventHandler(this.btnPaymentCrud_Click);
            // 
            // Yika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnPaymentCrud);
            this.Controls.Add(this.btnMarchantCrud);
            this.Controls.Add(this.btnCustomerCrud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.bgholder);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnMarchant);
            this.Controls.Add(this.btnPayment);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 650);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Yika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yika";
            this.Load += new System.EventHandler(this.Yika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnMarchant;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.GroupBox bgholder;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCustomerCrud;
        private System.Windows.Forms.Button btnMarchantCrud;
        private System.Windows.Forms.Button btnPaymentCrud;
    }
}

