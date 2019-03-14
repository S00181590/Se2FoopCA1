using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Member
    {
        public string Name { get; set; }

        public Queue<Task> tasks { get; set; }

        public Member(string name)
        {
            Name = name;

            tasks = new Queue<Task>();
        }

        public void AddTask(Task TaskToAdd)
        {
            tasks.Enqueue(TaskToAdd);
        }

        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }
}
