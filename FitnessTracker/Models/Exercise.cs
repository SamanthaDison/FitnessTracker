using System;
using FitnessTracker.Interfaces;

namespace FitnessTracker.Models
{
    public class Exercise : IRepoItem<int>
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BodyPart { get; set; }
        public string Equipment { get; set; }
        public string GifUrl { get; set; }
        public string Target { get; set; }
    }
}

