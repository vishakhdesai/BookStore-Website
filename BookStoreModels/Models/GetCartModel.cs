using BookStoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreModels.Models
{
    public class GetCartModel
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public int Bookid { get; set; }
        public int Quantity { get; set; }

        public virtual BookModel Book { get; set; } = null!;

        public GetCartModel() { }

        public GetCartModel(Cart cart)
        {
            Id = cart.Id;
            Userid = cart.Userid;
            Bookid = cart.Bookid;
            Quantity = cart.Quantity;
            Book = new BookModel()
            {
                Base64image = cart.Book.Base64image,
                Quantity = cart.Book.Quantity,
                Id = cart.Book.Id,
                Name = cart.Book.Name,
                Description = cart.Book.Description,
                Categoryid = cart.Book.Categoryid,
                Publisherid = cart.Book.Publisherid,
                Price = cart.Book.Price,
            };
        }
    }
}
