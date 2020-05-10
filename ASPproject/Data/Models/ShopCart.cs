using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Data.Models
{
    public class ShopCart
    {
        private AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCartId { get; set; }
        public List<ShopCaritem>ListShopItems{get; set;}
        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CarId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };

        }

        public void AddToCart(Car car)
        {
            appDBContent.ShopCaritems.Add(new ShopCaritem
            {

                ShopCarId = ShopCartId,
                car=car,
                price=car.price

            });
            appDBContent.SaveChanges();
        }
        public List<ShopCaritem> GetShopCaritems()
        {
            return appDBContent.ShopCaritems.Where(c => c.ShopCarId == ShopCartId).Include(s=>s.car).ToList();
        }
    }
}
