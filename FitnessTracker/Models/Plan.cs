using System;
using FitnessTracker.Interfaces;

namespace FitnessTracker.Models
{
    public class Plan : IRepoItem<int>
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Focus { get; set; }
        public string Difficulty { get; set; }
        public Account Creator { get; set; }
        public string CreatorId { get; set; }
    }
}