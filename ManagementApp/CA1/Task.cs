using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Task
    {
        public string TaskName { get; set; }

        public string Description { get; set; }

        public Task(string name, string description)
        {
            TaskName = name;

            Description = description;

        }

        public override string ToString()
        {
            return string.Format($"{TaskName}");
        }
    }
}
