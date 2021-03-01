using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Abstract
{
    public interface ICartRepository : IRepository<Cart>
    {
        void Create(Cart cart);
        Cart GetByUserId(string userId);
        void DeleteFromCart(int cartId, int productId);
    }
}
