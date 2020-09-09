using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommanderWebsite.Models
{
    public class CartController : IDisposable
    {
        public static string ShoppingCartId { get; set; }

        private static CommanderEDM _db = new CommanderEDM();

        public static string CartSessionKey = "CartId";

        public static void AddToCart(int id, int? Qty, string name, decimal? price, string user)
        {

            // Retrieve the product from the database.
            ShoppingCartId = user;
            var cartItem = _db.Carts.SingleOrDefault(
            c => c.cartId == ShoppingCartId
            && c.Product_ID == id);
            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.
                cartItem = new Cart
                {

                    Cart_ID = Guid.NewGuid().ToString(),
                    cartId = ShoppingCartId,
                    Quantity = Qty,
                    DateCreated = DateTime.Now,
                    Product_ID = id,
                    Name = name,
                    Price = price * Qty
                };
                _db.Carts.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart,
                // then add one to the quantity.
                cartItem.Quantity += Qty;
                cartItem.Price += price;
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

        public static string GetCartId()
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

        public static List<Cart> GetCartItems(string user)
        {
            ShoppingCartId = user;
            var d = _db.Carts.Select(c => c);
            var ds = d.Where(c => c.cartId == ShoppingCartId).ToList();
            return ds;
        }

        public static List<Cart> GetCartItems(string user, int id)
        {
            ShoppingCartId = user;
            var d = _db.Carts.Select(c => c);
            var ds = d.Where(c => c.cartId == ShoppingCartId && c.Product_ID == id).ToList();
            return ds;
        }

        public static Cart GetCartItems1(string user, int id)
        {
            ShoppingCartId = user;
            CommanderEDM db = new CommanderEDM();
            var ds = db.Carts.SingleOrDefault(c => c.cartId == ShoppingCartId && c.Product_ID == id);
            return ds;
        }

        public static Cart GetCartItems2(string user)
        {
            ShoppingCartId = user;
            var d = _db.Carts.SingleOrDefault(c => c.cartId == ShoppingCartId);
            return d;
        }

        public static void removeItem(int prod, string user)
        {
            var dbItem = _db.Carts.SingleOrDefault(c => c.Product_ID == prod && c.cartId == user);
            _db.Carts.Remove(dbItem);
            _db.SaveChanges();
        }

    }
}
