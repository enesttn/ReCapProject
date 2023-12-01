using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            // İş kodları

            //Şayet iş kurallarından geçiyorsa: (Ör: Yetkisi var mı?)
          
            return _carDal.GetAll();
        }
    }
}
