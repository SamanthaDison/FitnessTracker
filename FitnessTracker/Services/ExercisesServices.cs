using FitnessTracker.Repositories;

namespace FitnessTracker.Services
{
    public class ExercisesService
    {
        private readonly ExercisesRepository _repo;

        public ExercisesService(ExercisesRepository repo)
        {
            _repo = repo;
        }
    }
}