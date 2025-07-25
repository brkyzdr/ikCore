using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class RecruitmentPostManager : IRecruitmentPostService
    {
        private readonly IRecruitmentPostDal _recruitmentPostDal;

        public RecruitmentPostManager(IRecruitmentPostDal recruitmentPostDal)
        {
            _recruitmentPostDal = recruitmentPostDal;
        }

        public void Create(RecruitmentPost entity)
        {
            entity.PublishDate = DateTime.UtcNow;
            _recruitmentPostDal.Add(entity);
        }

        public void Update(RecruitmentPost entity)
        {
            _recruitmentPostDal.Update(entity);
        }

        public void Delete(int id)
        {
            var post = _recruitmentPostDal.Get(x => x.Id == id);
            if (post != null)
            {
                _recruitmentPostDal.Delete(post);
            }
        }

        public RecruitmentPost GetById(int id)
        {
            return _recruitmentPostDal.Get(x => x.Id == id);
        }

        public List<RecruitmentPost> GetAll()
        {
            return _recruitmentPostDal.GetAll().ToList();
        }

        public List<RecruitmentPost> GetByCompanyId(int companyId)
        {
            return _recruitmentPostDal.GetAll(x => x.CompanyId == companyId).ToList();
        }

        public List<RecruitmentPost> GetActivePosts()
        {
            var today = DateTime.UtcNow.Date;
            return _recruitmentPostDal.GetAll(x => x.IsActive && x.ApplicationDeadline >= today).ToList();
        }
    }
}
