using System;
using System.Collections.Generic;

namespace Supers.Models
{
    public partial class Mission
    {
        public int Id { get; set; }
        public int? SuperId { get; set; }
        public string MissionName { get; set; }
        public bool Completed { get; set; }
        public int Difficulty { get; set; }
        public DateTime DueDate { get; set; }

        public virtual Super Super { get; set; }
    }
}
