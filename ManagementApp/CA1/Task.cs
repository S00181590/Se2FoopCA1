using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    public class Task
    {
        public string TaskName { get; set; }

        public string Description { get; set; }

        public enum Category { Primary, Secondary, Optional }

        public Category AssignedCat { get; set; }

        public DateTime DueDate { get; set; }

        public Task(string name, string description, string category, Double due)
        {
            TaskName = name;

            Description = description;

            AssignedCat = (Category)Enum.Parse(typeof(Category),category);

            DueDate = DateTime.Now;

            DueDate = DueDate.AddDays(due);

        }

        public override string ToString()
        {
            return string.Format($"{TaskName}");
        }
    }
}
