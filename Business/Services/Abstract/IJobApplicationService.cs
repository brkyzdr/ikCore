using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IJobApplicationService
    {
        void Submit(JobApplication application);
        void Update(JobApplication application);
        void Delete(int id);

        JobApplication GetById(int id);
        List<JobApplication> GetAll();
        List<JobApplication> GetByRecruitmentPostId(int postId);
        List<JobApplication> GetByCompanyId(int companyId);
        List<JobApplication> GetByEmail(string email); // Aday başvuru sorgulama
    }
}
