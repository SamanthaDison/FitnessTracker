using System.Collections.Generic;
using System.Data;
using FitnessTracker.Interfaces;
using FitnessTracker.Models;

namespace FitnessTracker.Repositories
{
    public class ExercisesRepository : IRepository<Exercise, int>
    {
        private readonly IDbConnection _db;

        public ExercisesRepository(IDbConnection db)
        {
            _db = db;
        }

        public Exercise Create(Exercise newData)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(Exercise update)
        {
            throw new System.NotImplementedException();
        }

        public List<Exercise> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Exercise GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}