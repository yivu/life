using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeManager.Data
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Deadline { get; set; }
        public string Difficulty { get; set; }
    }
}
