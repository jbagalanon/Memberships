using Memmberships.Areas.Admin.Models;
using Memmberships.Entities;
using Memmberships.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;

namespace Memmberships.Areas.Admin.Extensions
{
    public static class ConversionExtensions
    {
        public static async Task<IEnumerable<ProductModel>> Convert (
            
            this IEnumerable <Product> products, ApplicationDbContext db)
        {
            var texts = await db.ProductLinkTexts.ToListAsync();
            var types = await db.ProductTypes.ToListAsync();

            return from p in products
                   select new ProductModel
                   {
                       Id = p.Id,
                       Title = p.Title,
                       Description = p.Description,
                       ImageUrl = p.ImageUrl,
                       ProductTypeId = p.ProductTypeId,
                       ProductLinkTextId = p.ProductLinkTextId,
                       ProductTypes = types
                   };
        }

    }
}