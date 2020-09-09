using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommanderWebsite.Controllers
{
    public class WishListController 
    {
        public static string ShoppingCartId { get; set; }

        private static CommanderEDM _db = new CommanderEDM();

        public static string CartSessionKey = "WishListId";

        public static void AddToWishList(int id, int Qty, string name, decimal? price, string user)
        {

            // Retrieve the product from the database.
            ShoppingCartId = user;
            var cartItem = _db.Wishlists.SingleOrDefault(
            c => c.wishlistId == ShoppingCartId
            && c.Product_ID == id);
            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.
                cartItem = new Wishlist
                {
                    wishlistId = ShoppingCartId,
                    Quantity = Qty,
                    DateAdded = DateTime.Now,
                    Product_ID = id,
                    Name = name,
                    Price = price * Qty
                };
                _db.Wishlists.Add(cartItem);
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

      
        public static string GetWishListId()
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

        public static List<Wishlist> GetWishListItems(string user)
        {
            ShoppingCartId = user;
            return _db.Wishlists.Where(c => c.wishlistId == ShoppingCartId).ToList();
        }

        public static Wishlist getWishListItem(string user)
        {
            ShoppingCartId = user;
            return _db.Wishlists.SingleOrDefault(c => c.wishlistId == ShoppingCartId);
        }

        public static void removeItem(int prod, string user)
        {
            var dbItem = _db.Wishlists.SingleOrDefault(c => c.Product_ID == prod && c.wishlistId == user);
            _db.Wishlists.Remove(dbItem);
            _db.SaveChanges();
        }
    }
}