using Service;
using Model.DomainModels;
using ValidationComponents;

namespace View;

public partial class frmPerson : Form
{
    private readonly PersonService _personService;
    private bool isEditing = false;
    private int idToEdit = 0;
    public frmPerson()
    {
        InitializeComponent();
        _personService = new PersonService();
    }

    private void frmPerson_Load(object sender, EventArgs e)
    {
        dgvPerson.DataSource = _personService.FillGrid();
        dgvPerson.Columns[0].Visible = false;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (BaseValidator.IsFormValid(this.components))
        {
            var person = new Person
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };

            if (!isEditing)
            {
                _personService.Save(person);
                MessageBox.Show("Done", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _personService.Edit(idToEdit, person);
                MessageBox.Show("Done", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idToEdit = 0;
                isEditing = false;
            }
        }
        dgvPerson.DataSource = _personService.FillGrid();
        txtFirstName.Text = string.Empty;
        txtLastName.Text = string.Empty;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvPerson.CurrentRow != null)
        {
            txtFirstName.Text = dgvPerson.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgvPerson.CurrentRow.Cells[2].Value.ToString();
            isEditing = true;
            idToEdit = int.Parse(dgvPerson.CurrentRow.Cells[0].Value.ToString());
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        var id = dgvPerson.CurrentRow.Cells[0].Value.ToString();
        var firstName = dgvPerson.CurrentRow.Cells[1].Value.ToString();
        var lastname = dgvPerson.CurrentRow.Cells[2].Value.ToString();
        var fullName = firstName + " " + lastname;

        if (dgvPerson.CurrentRow != null)
        {
            if ((MessageBox.Show($"Are You Sure You Want To Delete {fullName} ?!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))
            {
                _personService.Delete(int.Parse(id));
            }
        }
        dgvPerson.DataSource = _personService.FillGrid();
    }
    private void btnRefresh_Click(object sender, EventArgs e)
    {
        dgvPerson.DataSource = _personService.FillGrid();
        txtFirstName.Text = string.Empty;
        txtLastName.Text = string.Empty;
    }

    private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void dgvPerson_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btnSave_MouseLeave(object sender, EventArgs e)
    {
        btnSave.BackColor = Color.LightGray;
    }

    private void btnSave_MouseHover(object sender, EventArgs e)
    {

    }

    private void btnSave_MouseEnter(object sender, EventArgs e)
    {
        btnSave.BackColor = Color.LightGreen;

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

    private void lblFirstName_Click(object sender, EventArgs e)
    {

    }
}