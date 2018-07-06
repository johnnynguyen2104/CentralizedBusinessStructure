using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment.DAL.BaseEntities;
using Payment.DAL.Interfaces;
using Payment.DAL.Repositories;

namespace Payment.DAL.UnitOfWork
{
    public partial class UnitOfWork
    {
        public IRepository<User> UserRepository => this.UserRepository ?? new Repository<User>(_dbContextStrategy.);
        //public IRepository<Categories> CategoriesRepository => this.CategoriesRepository ?? new Repository<Categories>(_dbContext);

        //public IRepository<Restaurants> RestaurantsRepository => this.RestaurantsRepository ?? new Repository<Restaurants>(_dbContext);

        //public IRepository<Menu> MenuRepository => this.MenuRepository ?? new Repository<Menu>(_dbContext);

        //public IRepository<Orders> OrdersRepository => this.OrdersRepository ?? new Repository<Orders>(_dbContext);

        //public IRepository<Users> UsersRepository => this.UsersRepository ?? new Repository<Users>(_dbContext);

        //public IRepository<UserTypes> UserTypesRepository => this.UserTypesRepository ?? new Repository<UserTypes>(_dbContext);
        //public IRepository<MenuDetails> MenuDetailsRepository => this.MenuDetailsRepository ?? new Repository<MenuDetails>(_dbContext);
    }
}
