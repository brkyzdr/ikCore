using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class PerformanceReviewManager : IPerformanceReviewService
    {
        private readonly IPerformanceReviewDal _performanceReviewDal;

        public PerformanceReviewManager(IPerformanceReviewDal performanceReviewDal)
        {
            _performanceReviewDal = performanceReviewDal;
        }

        public void Create(PerformanceReview entity)
        {
            entity.ReviewDate = DateTime.UtcNow;
            _performanceReviewDal.Add(entity);
        }

        public void Update(PerformanceReview entity)
        {
            _performanceReviewDal.Update(entity);
        }

        public void Delete(int id)
        {
            var review = _performanceReviewDal.Get(x => x.Id == id);
            if (review != null)
                _performanceReviewDal.Delete(review);
        }

        public PerformanceReview GetById(int id)
        {
            return _performanceReviewDal.Get(x => x.Id == id);
        }

        public List<PerformanceReview> GetAll()
        {
            return _performanceReviewDal.GetAll().ToList();
        }

        public List<PerformanceReview> GetByEmployeeId(int employeeId)
        {
            return _performanceReviewDal.GetAll(x => x.EmployeeId == employeeId).ToList();
        }

        public List<PerformanceReview> GetByCompanyId(int companyId)
        {
            return _performanceReviewDal.GetAll(x => x.Employee.CompanyId == companyId).ToList();
        }

        public List<PerformanceReview> GetByPeriod(DateTime startDate, DateTime endDate, int? companyId = null)
        {
            IEnumerable<PerformanceReview> query = _performanceReviewDal.GetAll(x =>
                x.ReviewPeriodStart >= startDate &&
                x.ReviewPeriodEnd <= endDate);

            if (companyId.HasValue)
            {
                query = query.Where(x => x.Employee.CompanyId == companyId.Value);
            }

            return query.ToList();
        }
    }
}
