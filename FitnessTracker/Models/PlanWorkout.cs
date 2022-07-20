using System;
using FitnessTracker.Interfaces;

namespace FitnessTracker.Models
{
    public class PlanWorkout : IRepoItem<int>
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int WorkoutId { get; set; }
        public int PlanId { get; set; }
        public int Day { get; set; }
    }
}