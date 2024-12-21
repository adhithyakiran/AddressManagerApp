using Wisej.Web;
using AddressManagerApp.Models;
using AddressManagerApp.Repositories;

namespace AddressManagerApp.Forms
{
    public partial class AddOrganizationForm : Form
    {
        private OrganizationRepository _repository;

        public AddOrganizationForm(OrganizationRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var organization = new Organization
            {
                Name = txtName.Text,
                Street = txtStreet.Text,
                Zip = txtZip.Text,
                City = txtCity.Text,
                Country = txtCountry.Text
            };

            _repository.AddOrganization(organization);
            this.Close();
        }
    }
}
