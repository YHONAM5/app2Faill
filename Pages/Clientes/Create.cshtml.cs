using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using repocru2.Data;
using repocru2.Models;

namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _ctx;

        public CreateModel(AppDbContext ctx)
        {
            _ctx=ctx;
        }

        [BindProperty]
        public Cliente Cliente { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPos()
        {
            _ctx.Clientes.Add(Cliente);
            _ctx.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
