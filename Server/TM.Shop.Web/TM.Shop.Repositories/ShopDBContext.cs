using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TM.Shop.Models.UserModel;

namespace TM.Shop.Repositories
{
    public class ShopDBContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public ShopDBContext(DbContextOptions<ShopDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                return;
            }

            //自动生成数据库时候要用到
            optionsBuilder.UseMySql("server=localhost;userid=root;password=123456;database=shopmall;");
        }

        public ShopDBContext()
        {
        }
    }
}
