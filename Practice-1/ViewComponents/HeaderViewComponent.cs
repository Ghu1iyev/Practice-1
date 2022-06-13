using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice_1.DAL;
using Practice_1.Models;
using System.Threading.Tasks;

namespace Practice_1.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Setting setting = await _context.Settings.FirstOrDefaultAsync();
            return View(setting);
        }
    }
}
