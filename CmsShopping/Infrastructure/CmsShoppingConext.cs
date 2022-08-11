using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsShopping.Infrastructure
{
    public class CmsShoppingConext : DbContext
    {
        public CmsShoppingConext(DbContextOptions<CmsShoppingConext> options ) 
            :base(options)
        {
        }
    }
}
    