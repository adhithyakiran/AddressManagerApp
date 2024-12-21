using Wisej.Web;
using AddressManagerApp.Repositories;

namespace AddressManagerApp.Forms
{
    public partial class MainForm : Form
    {
        private OrganizationRepository _repository;

        public MainForm()
        {
            InitializeComponent();
            _repository = new OrganizationRepository();
            LoadOrganizations();
        }

        private void LoadOrganizations()
        {
            var organizations = _repository.GetOrganizations();
            dataGridView1.DataSource = organizations;
        }
    }
}
