namespace View
{
    partial class frmProduct
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            groupBox1 = new GroupBox();
            dgvProduct = new DataGridView();
            txtTitle = new TextBox();
            txtUnitPrice = new NumericUpDown();
            txtQuantity = new NumericUpDown();
            lblQuantity = new Label();
            lblUnitPrice = new Label();
            groupBox2 = new GroupBox();
            requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGray;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(200, 200);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 70);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.DragEnter += btnSave_DragEnter_1;
            btnSave.MouseEnter += btnSave_MouseEnter;
            btnSave.MouseLeave += btnSave_MouseLeave;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightGray;
            btnEdit.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(400, 200);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(170, 70);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            btnEdit.MouseEnter += btnEdit_MouseEnter;
            btnEdit.MouseLeave += btnEdit_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightGray;
            btnDelete.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(600, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 70);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += btnDelete_MouseEnter;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(800, 200);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(170, 70);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            btnRefresh.MouseEnter += btnRefresh_MouseEnter;
            btnRefresh.MouseLeave += btnRefresh_MouseLeave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvProduct);
            groupBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(36, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1100, 350);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Products List";
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.BackgroundColor = Color.LightGray;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(10, 48);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1080, 290);
            dgvProduct.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.LightGray;
            txtTitle.Location = new Point(10, 43);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(380, 50);
            txtTitle.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = Color.LightGray;
            txtUnitPrice.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitPrice.Location = new Point(800, 50);
            txtUnitPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(250, 46);
            txtUnitPrice.TabIndex = 7;
            txtUnitPrice.ThousandsSeparator = true;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.LightGray;
            txtQuantity.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(800, 125);
            txtQuantity.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(249, 46);
            txtQuantity.TabIndex = 8;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Tahoma", 12F);
            lblQuantity.Location = new Point(600, 125);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(159, 39);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity :";
            lblQuantity.Click += lblQuantity_Click;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Tahoma", 12F);
            lblUnitPrice.Location = new Point(600, 50);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(174, 39);
            lblUnitPrice.TabIndex = 10;
            lblUnitPrice.Text = "Unit Price :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTitle);
            groupBox2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(140, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 100);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product Title";
            // 
            // requiredFieldValidator1
            // 
            requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            requiredFieldValidator1.ControlToValidate = txtTitle;
            requiredFieldValidator1.ErrorMessage = "Please Fill In The Title!";
            requiredFieldValidator1.Icon = (Icon)resources.GetObject("requiredFieldValidator1.Icon");
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1174, 629);
            Controls.Add(groupBox2);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(groupBox1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product";
            Load += frmProduct_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private GroupBox groupBox1;
        private TextBox txtTitle;
        private NumericUpDown txtUnitPrice;
        private NumericUpDown txtQuantity;
        private Label lblQuantity;
        private Label lblUnitPrice;
        private DataGridView dgvProduct;
        private GroupBox groupBox2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
    }
}