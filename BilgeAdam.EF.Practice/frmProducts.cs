using BilgeAdam.Data.Dtos;
using BilgeAdam.Data.Services.Abstractions;
using BilgeAdam.Data.Services.Concretes;
using System.ComponentModel;

namespace BilgeAdam.EF.Practice
{
    public partial class frmProducts : Form
    {
        private readonly ICategoryService categoryService;

        public frmProducts()
        {
            InitializeComponent();
            categoryService = new CategoryService();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            var categories = categoryService.GetAllCategoriesAsOption();
            lstCategories.DataSource = new BindingList<CategoryListDto>(categories);
            lstCategories.DisplayMember = nameof(CategoryListDto.Name);
            lstCategories.SelectedIndex = -1;
        }
    }
}