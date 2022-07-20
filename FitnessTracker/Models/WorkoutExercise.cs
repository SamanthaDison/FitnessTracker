using System;
using FitnessTracker.Interfaces;

namespace FitnessTracker.Models
{
    public class WorkoutExercise : IRepoItem<int>
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int Reps { get; set; }
        public int Sets { get; set; }
        public string Description { get; set; }
    }
}
