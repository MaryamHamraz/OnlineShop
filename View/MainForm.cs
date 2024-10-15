namespace View
{
    public partial class MainForm : Form
    {
        private Size originalSize;
        public MainForm()
        {
            InitializeComponent();
            originalSize = btnPerson.Size;
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            frmPerson frmPerson = new frmPerson();
            frmPerson.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct.ShowDialog();
        }

        private void btnPerson_MouseEnter(object sender, EventArgs e)
        {
            originalSize = btnPerson.Size;
            btnPerson.Size = new Size(originalSize.Width + 20, originalSize.Height + 10);
        }

        private void btnPerson_MouseLeave(object sender, EventArgs e)
        {
            btnPerson.Size = originalSize;
        }

        private void btnProduct_MouseEnter(object sender, EventArgs e)
        {
            originalSize = btnProduct.Size;
            btnProduct.Size = new Size(originalSize.Width + 20, originalSize.Height + 10);
        }

        private void btnProduct_MouseLeave(object sender, EventArgs e)
        {
            btnProduct.Size = originalSize;
        }
    }
}
