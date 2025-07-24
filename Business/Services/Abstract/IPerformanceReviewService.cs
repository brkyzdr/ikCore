using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IPerformanceReviewService
    {
        void Create(PerformanceReview entity);
        void Update(PerformanceReview entity);
        void Delete(int id);

        PerformanceReview GetById(int id);
        List<PerformanceReview> GetAll();
        List<PerformanceReview> GetByEmployeeId(int employeeId);
        List<PerformanceReview> GetByCompanyId(int companyId);
        List<PerformanceReview> GetByPeriod(DateTime startDate, DateTime endDate, int? companyId = null);
    }
}
