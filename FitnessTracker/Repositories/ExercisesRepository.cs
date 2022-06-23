using System.Collections.Generic;
using System.Data;
using Dapper;
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
            string sql = @"
           INSERT INTO exercises
           (title, description, bodyPart, equipment, gifUrl, target)
           VALUES
           (@Title, @Description, @BodyPart, @Equipment, @GifUrl, @Target);
           SELECT LAST_INSERT_ID()";
            int id = _db.ExecuteScalar<int>(sql, newData);
            newData.Id = id;
            return newData;
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