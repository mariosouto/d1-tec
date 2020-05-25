using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        private Logic myLogic;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myLogic = new Logic();
            dataGridViewPersons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPersons.DataSource = myLogic.GetPeople();
            this.RenameTableHeaders();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string personName = this.personNameInput.Text;
            if (personName != "")
            {
                int personAge = (int)this.personAgeInput.Value;
                myLogic.AddPerson(personName, personAge);
                personNameInput.Clear();
                dataGridViewPersons.DataSource = myLogic.GetPeople();
            }
        }

        private void RenameTableHeaders()
        {
            dataGridViewPersons.Columns[0].HeaderText = "Identificador";
            dataGridViewPersons.Columns[1].HeaderText = "Nombre";
            dataGridViewPersons.Columns[2].HeaderText = "Edad";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersons.SelectedRows.Count > 0)
            {
                Person personToDelete = (Person)dataGridViewPersons.SelectedRows[0].DataBoundItem;
                myLogic.DeletePerson(personToDelete);
                dataGridViewPersons.DataSource = myLogic.GetPeople();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersons.SelectedRows.Count > 0)
            {
                Person personToEdit = (Person)dataGridViewPersons.SelectedRows[0].DataBoundItem;
                myLogic.EditPersonName(personToEdit, "DA1");
                dataGridViewPersons.DataSource = myLogic.GetPeople();
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            int filterAge = (int)this.ageFilterInput.Value;
            List<Person> filteredList = myLogic.FindByAge(filterAge);
            dataGridViewPersons.DataSource = filteredList;
        }
    }
}
