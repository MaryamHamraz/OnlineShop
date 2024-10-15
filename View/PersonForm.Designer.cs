namespace View
{
    partial class frmPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerson));
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            groupBox1 = new GroupBox();
            dgvPerson = new DataGridView();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(components);
            requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
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
            btnSave.MouseEnter += btnSave_MouseEnter;
            btnSave.MouseLeave += btnSave_MouseLeave;
            btnSave.MouseHover += btnSave_MouseHover;
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
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(250, 25);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(191, 39);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name :";
            lblFirstName.Click += lblFirstName_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(250, 100);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(188, 39);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPerson);
            groupBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(36, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1100, 350);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Persons List";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgvPerson
            // 
            dgvPerson.AllowUserToAddRows = false;
            dgvPerson.AllowUserToDeleteRows = false;
            dgvPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerson.BackgroundColor = Color.LightGray;
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Location = new Point(10, 48);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.ReadOnly = true;
            dgvPerson.RowHeadersWidth = 51;
            dgvPerson.Size = new Size(1080, 290);
            dgvPerson.TabIndex = 0;
            dgvPerson.CellContentClick += dgvPerson_CellContentClick;
            dgvPerson.CellMouseEnter += dgvPerson_CellMouseEnter;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.LightGray;
            txtFirstName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(450, 25);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(450, 55);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.LightGray;
            txtLastName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(450, 100);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(450, 55);
            txtLastName.TabIndex = 8;
            // 
            // requiredFieldValidator1
            // 
            requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            requiredFieldValidator1.ControlToValidate = txtFirstName;
            requiredFieldValidator1.ErrorMessage = "Please Fill In The First Name!";
            requiredFieldValidator1.Icon = (Icon)resources.GetObject("requiredFieldValidator1.Icon");
            // 
            // requiredFieldValidator2
            // 
            requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            requiredFieldValidator2.ControlToValidate = txtLastName;
            requiredFieldValidator2.ErrorMessage = "Please Fill In The Last Name!";
            requiredFieldValidator2.Icon = (Icon)resources.GetObject("requiredFieldValidator2.Icon");
            // 
            // frmPerson
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1174, 629);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(groupBox1);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmPerson";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Person";
            Load += frmPerson_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Label lblFirstName;
        private Label lblLastName;
        private GroupBox groupBox1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DataGridView dgvPerson;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
    }
}