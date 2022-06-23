using System.Collections.Generic;

namespace FitnessTracker.Interfaces
{
    public interface IRepository<T, Tid>
    {
        List<T> GetAll();

        T GetById(Tid id);

        T Create(T newData);

        void Edit(T update);

        void Delete(Tid id);
    }
}