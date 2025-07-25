using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class PositionManager : IPositionService
    {
        private readonly IPositionDal _positionDal;

        public PositionManager(IPositionDal positionDal)
        {
            _positionDal = positionDal;
        }

        public void Create(Position entity)
        {
            _positionDal.Add(entity);
        }

        public void Update(Position entity)
        {
            _positionDal.Update(entity);
        }

        public void Delete(int id)
        {
            var position = _positionDal.Get(x => x.Id == id);
            if (position != null)
            {
                _positionDal.Delete(position);
            }
        }

        public Position GetById(int id)
        {
            return _positionDal.Get(x => x.Id == id);
        }

        public List<Position> GetAll()
        {
            return _positionDal.GetAll().ToList();
        }

        public List<Position> GetByCompanyId(int companyId)
        {
            return _positionDal.GetAll(x => x.Department.CompanyId == companyId).ToList();
        }
    }
}
