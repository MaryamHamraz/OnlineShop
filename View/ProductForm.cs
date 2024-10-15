using Services;
using Model.DomainModels;
using ValidationComponents;

namespace View
{
    public partial class frmProduct : Form
    {
        private readonly ProductService _productservice;
        private bool isEditing = false;
        private int idToEdit = 0;
        public frmProduct()
        {
            InitializeComponent();
            _productservice = new ProductService();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = _productservice.FillGrid();
            dgvProduct.Columns[0].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                var product = new Product()
                {
                    Title = txtTitle.Text,
                    UnitPrice = txtUnitPrice.Value,
                    Quantity = (int)txtQuantity.Value,
                };
                if (!isEditing)
                {
                    _productservice.Save(product);
                    MessageBox.Show("Done", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _productservice.Edit(idToEdit, product);
                    MessageBox.Show("Done", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idToEdit = 0;
                    isEditing = false;
                }
            }
            dgvProduct.DataSource = _productservice.FillGrid();
            txtTitle.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow != null)
            {
                txtTitle.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                txtUnitPrice.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
                txtQuantity.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
                isEditing = true;
                idToEdit = int.Parse(dgvProduct.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            var title = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            if (dgvProduct.CurrentRow != null)
            {
                if ((MessageBox.Show($"Are You Sure You Want To Delete {title} ?!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))
                {
                    _productservice.Delete(int.Parse(id));
                }
                dgvProduct.DataSource = _productservice.FillGrid();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = _productservice.FillGrid();
            txtTitle.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }



        private void btnSave_DragEnter_1(object sender, DragEventArgs e)
        {

        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LightGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LightGray;
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.LightYellow;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.LightGray;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.LightCoral;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.LightGray;
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.LightBlue;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.LightGray;
        }
    }
}