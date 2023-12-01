using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=2,ColorId=1,DailyPrice=350,ModelYear=2008,Description="Bentley"},
                new Car{CarId=2,BrandId=2,ColorId=1,DailyPrice=250,ModelYear=2012,Description="Aston Martin"},
                new Car{CarId=3,BrandId=1,ColorId=3,DailyPrice=200,ModelYear=2009,Description="Mini Cooper"},
                new Car{CarId=4,BrandId=4,ColorId=3,DailyPrice=450,ModelYear=2018,Description="Range Rover"},
                new Car{CarId=5,BrandId=3,ColorId=4,DailyPrice=550,ModelYear=2019,Description="Tesla Model S"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Uptade(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
