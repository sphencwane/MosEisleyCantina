using MosEisleyCantina.Data.Repositories.Entities;

namespace MosEisleyCantina.Data.Repositories.Contracts
{
    public interface IRatingRepository
    {
       Task RateMenuItem(Rating rating);
    }
}
