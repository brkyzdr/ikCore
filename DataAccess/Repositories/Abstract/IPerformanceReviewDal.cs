using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IPerformanceReviewDal : IGenericRepository<PerformanceReview>
    {
        // Tarih aralığına göre değerlendirme sorguları gibi işlemler burada tanımlanabilir
    }
}
