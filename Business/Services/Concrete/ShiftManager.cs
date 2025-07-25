using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class ShiftManager : IShiftService
    {
        private readonly IShiftDal _shiftDal;

        public ShiftManager(IShiftDal shiftDal)
        {
            _shiftDal = shiftDal;
        }

        public void Create(Shift entity)
        {
            _shiftDal.Add(entity);
        }

        public void Update(Shift entity)
        {
            _shiftDal.Update(entity);
        }

        public void Delete(int id)
        {
            var shift = _shiftDal.Get(x => x.Id == id);
            if (shift != null)
            {
                _shiftDal.Delete(shift);
            }
        }

        public Shift GetById(int id)
        {
            return _shiftDal.Get(x => x.Id == id);
        }

        public List<Shift> GetAll()
        {
            return _shiftDal.GetAll().ToList();
        }

        public List<Shift> GetByCompanyId(int companyId)
        {
            return _shiftDal.GetAll(x => x.CompanyId == companyId).ToList();
        }
    }
}
