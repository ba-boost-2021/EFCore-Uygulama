using BilgeAdam.Data.Dtos;
using BilgeAdam.Data.Services.Abstractions;
using BilgeAdam.Data.Services.Concretes;
using System.ComponentModel;

namespace BilgeAdam.EF.Practice
{
    public partial class frmProducts : Form
    {
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;
        private bool ready;

        public frmProducts()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            productService = new ProductService();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            var categories = categoryService.GetAllCategoriesAsOption();
            lstCategories.DataSource = new BindingList<CategoryListDto>(categories);
            lstCategories.DisplayMember = nameof(CategoryListDto.Name);
            lstCategories.SelectedIndex = -1;
            ready = true;
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategories.SelectedIndex == -1 || !ready)
            {
                return;
            }
            var selectedCategory = lstCategories.SelectedItem as CategoryListDto;
            var products = productService.GetProductsByCategoryId(selectedCategory.Id);
            dgvProducts.DataSource = new BindingList<ProductViewDto>(products);

        }
    }
}