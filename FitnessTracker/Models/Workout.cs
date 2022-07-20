using System;
using FitnessTracker.Interfaces;

namespace FitnessTracker.Models
{
    public class Workout : IRepoItem<int>
    {

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public int PlanId { get; set; }
    }
}