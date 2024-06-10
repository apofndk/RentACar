using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, ReCapProjectDbContext>, IBrandDal
    {


    }
}
