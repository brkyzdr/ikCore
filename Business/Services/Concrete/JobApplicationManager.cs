using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class JobApplicationManager : IJobApplicationService
    {
        private readonly IJobApplicationDal _jobApplicationDal;

        public JobApplicationManager(IJobApplicationDal jobApplicationDal)
        {
            _jobApplicationDal = jobApplicationDal;
        }

        public void Submit(JobApplication application)
        {
            _jobApplicationDal.Add(application);
        }

        public void Update(JobApplication application)
        {
            _jobApplicationDal.Update(application);
        }

        public void Delete(int id)
        {
            var entity = _jobApplicationDal.Get(x => x.Id == id);
            if (entity != null)
                _jobApplicationDal.Delete(entity);
        }

        public JobApplication GetById(int id)
        {
            return _jobApplicationDal.Get(x => x.Id == id);
        }

        public List<JobApplication> GetAll()
        {
            return _jobApplicationDal.GetAll().ToList();
        }

        public List<JobApplication> GetByRecruitmentPostId(int postId)
        {
            return _jobApplicationDal.GetAll(x => x.RecruitmentPostId == postId).ToList();
        }

        public List<JobApplication> GetByCompanyId(int companyId)
        {
            return _jobApplicationDal.GetAll(x => x.CompanyId == companyId).ToList();
        }

        public List<JobApplication> GetByEmail(string email)
        {
            return _jobApplicationDal.GetAll(x => x.Email == email).ToList();
        }
    }
}
