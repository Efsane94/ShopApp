using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public class EfCoreCartRepository : EfCoreRepository<Cart, ShopContext>, ICartRepository
    {
        public Cart GetByUserId(string userId)
        {
            using(var context=new ShopContext())
            {
                return context.Carts
                        .Include(i => i.CartItems)
                        .ThenInclude(i => i.Product)
                        .FirstOrDefault(i => i.UserId == userId);
            }
        }


        public override void Update(Cart entity)
        {
            using (var context=new ShopContext())
            {
                context.Carts.Update(entity);
                context.SaveChanges();
            }
        }

        public void DeleteFromCart(int cartId, int productId)
        {
            using (var context=new ShopContext())
            {
                var cmd = @"Delete From CartItem where CartId=@p0 And ProductId=@p1";

                context.Database.ExecuteSqlCommand(cmd, cartId, productId);

            }
        }
    }
}
