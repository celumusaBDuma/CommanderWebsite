using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommanderWebsite.Models
{
    public class CartController : IDisposable
    {
        public string ShoppingCartId { get; set; }

        private CommanderEDM _db = new CommanderEDM();

        public const string CartSessionKey = "CartId";

        public void AddToCart(int id)
        {
            // Retrieve the product from the database.
            ShoppingCartId = GetCartId();
            var cartItem = _db.Carts.SingleOrDefault(
            c => c.CartId == ShoppingCartId
            && c.Product_ID == id);
            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.
                cartItem = new Cart
                {
                    Cart_ID = Guid.NewGuid().ToString(),
                    CartId = ShoppingCartId,
                    Customer_ID = int.Parse((from c in _db.Customers where c.Email == ShoppingCartId select c.Customer_ID).SingleOrDefault().ToString()),
                    Quantity = 1,
                    DateCreated = DateTime.Now,
                    Product_ID = id                    
                };
                _db.Carts.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart,
                // then add one to the quantity.
                cartItem.Quantity++;
            }
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }

        public string GetCartId()
        {
            if (HttpContext.Current.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[CartSessionKey] =
                    HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return HttpContext.Current.Session[CartSessionKey].ToString();
        }

        public List<Cart> GetCartItems()
        {
            ShoppingCartId = GetCartId();
            return _db.Carts.Where(c => c.CartId == ShoppingCartId).ToList();
        }
    }
}
