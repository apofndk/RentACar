using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;

namespace DataAccess.Concrete
{

    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>{
                new Car { CarId=1, BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=1500, Description="Benzinli 5 ileri  araba."},
                new Car { CarId=2, BrandId=3, ColorId=2, ModelYear=2022, DailyPrice=2500, Description="Dizel 5 ileri spor araba."},
                new Car { CarId=3, BrandId=1, ColorId=3, ModelYear=2021, DailyPrice=1900, Description="Benzinli 5 ileri  araba."},
                new Car { CarId=4, BrandId=2, ColorId=3, ModelYear=2024, DailyPrice=3500, Description="dizel 6 ileri arazi arabası."},
                new Car { CarId=5, BrandId=3, ColorId=1, ModelYear=2019, DailyPrice=1300, Description="Benzinli 5 ileri  araba."}
            };
        }
        public void Add(Car car)
        { 
            _car.Add(car);
        }
        public void Delete(Car car)
        {
            Car carToDelete =_car.SingleOrDefault(c=>c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.Description=car.Description;
            carToUpdate.ColorId=car.ColorId;
        }
        public List<Car> GetAll()
        {
            return _car.ToList();
        }
        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.CarId == id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> CarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
