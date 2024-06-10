using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapProjectDbContext>, IUserDal
    {

    }
}
