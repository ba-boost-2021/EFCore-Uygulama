using BilgeAdam.Data.Dtos;
using BilgeAdam.Data.Services.Abstractions;
using BilgeAdam.Data.Services.Concretes;
using System.ComponentModel;

namespace BilgeAdam.EF.Practice
{
    public partial class frmEmployeeManagement : Form
    {
        private readonly IEmployeeService service;
        public frmEmployeeManagement()
        {
            InitializeComponent();
            service = new EmployeeService();
        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = new BindingList<EmployeeViewDto>(service.GetAllEmployee());
        }
    }
}