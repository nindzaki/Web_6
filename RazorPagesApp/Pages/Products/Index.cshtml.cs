using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Data;
using RazorPagesApp.Models;
using System.Linq;

namespace RazorPagesApp.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        // Параметры для фильтрации
        [BindProperty(SupportsGet = true)]
        public string? DepartmentFilter { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? ProductNameFilter { get; set; }

        // Результаты запросов
        public IList<Product> ProductsInDepartment { get; set; } = new List<Product>();
        public decimal TotalPriceForProduct { get; set; }

        public async Task OnGetAsync()
        {
            // Запрос 1: Наименования всех товаров в заданном отделе
            if (!string.IsNullOrEmpty(DepartmentFilter))
            {
                ProductsInDepartment = await _context.Products
                    .Where(p => p.Department == DepartmentFilter)
                    .ToListAsync();
            }

            // Запрос 2: Суммарная стоимость товара заданного наименования
            if (!string.IsNullOrEmpty(ProductNameFilter))
            {
                TotalPriceForProduct = await _context.Products
                    .Where(p => p.Name == ProductNameFilter)
                    .SumAsync(p => p.Price);
            }
        }
    }
}