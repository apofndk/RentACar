using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<Car> GetCarByID(int carId);
        IDataResult<List<Car>> GetCarsByBrandID(int brandId);
        IDataResult<List<Car>> GetCarsByColorID(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
