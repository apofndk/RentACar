using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectDbContext>, IRentalDal
    {

        public List<RentalDetailDto> RentalDetails()
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join br in context.Brands
                             on c.BrandId equals br.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join cu in context.Customers
                             on r.CustomerId equals cu.CustomerId
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 CarName = c.Description,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = cu.CompanyName,
                                 Email = u.Email,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                             };
                return result.ToList();
            }
        }
    }
}
