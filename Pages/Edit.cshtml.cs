using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages
{
    public class EditModel : PageModel
    {
        private readonly IBookStoreData books;

        public Book book { get; set; }

        public EditModel(IBookStoreData books)
        {
            this.books = books;
        }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
                book = books.GetById(id.Value);

            if (book == null)
            {
                return RedirectToPage("./NotFound");
            }


            return Page();

        }
    }
}