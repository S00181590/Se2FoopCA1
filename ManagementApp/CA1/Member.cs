using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Member
    {
        public string Name { get; set; }

        public ObservableCollection<Task> tasks { get; set; }

        public Member(string name)
        {
            Name = name;

            tasks = new ObservableCollection<Task>();
        }

        public void AddTask(Task TaskToAdd)
        {
            tasks.Add(TaskToAdd);
        }

        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }
}
