using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapProjectDbContext>, ICustomerDal
    {
        public List<CustomerDetailDto> CustomerDetails()
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var results = from cu in context.Customers
                              join u in context.Users
                              on cu.UserId equals u.Id
                              select new CustomerDetailDto
                              {
                                  FirstName = u.FirstName,
                                  LastName = u.LastName,
                                  CompanyName = cu.CompanyName,
                                  Email = u.Email,
                              };
                return results.ToList();
            }
        }
    }
}
