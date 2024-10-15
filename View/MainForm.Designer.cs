namespace View
{
    partial class MainForm
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
            btnPerson = new Button();
            btnProduct = new Button();
            SuspendLayout();
            // 
            // btnPerson
            // 
            btnPerson.BackColor = Color.LightGray;
            btnPerson.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPerson.Location = new Point(130, 120);
            btnPerson.Name = "btnPerson";
            btnPerson.Size = new Size(200, 85);
            btnPerson.TabIndex = 0;
            btnPerson.Text = "Persons";
            btnPerson.UseVisualStyleBackColor = false;
            btnPerson.Click += btnPerson_Click;
            btnPerson.MouseEnter += btnPerson_MouseEnter;
            btnPerson.MouseLeave += btnPerson_MouseLeave;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.LightGray;
            btnProduct.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.Location = new Point(450, 120);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(200, 85);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Products";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            btnProduct.MouseEnter += btnProduct_MouseEnter;
            btnProduct.MouseLeave += btnProduct_MouseLeave;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(774, 329);
            Controls.Add(btnProduct);
            Controls.Add(btnPerson);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Online Shop";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPerson;
        private Button btnProduct;
    }
}
