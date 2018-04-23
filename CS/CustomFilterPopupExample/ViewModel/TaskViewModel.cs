using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFilterPopupExample
{
    class TaskViewModel
    {
        private ObservableCollection<Task> _List;

        public ObservableCollection<Task> List
        {
            get
            {
                if (_List == null)
                {
                    _List = new ObservableCollection<Task>();
                    for (int i = 0; i < 100; i++)
                    {
                        _List.Add(new Task() { Name = "Task" + i, Date = new DateTime(2014, 10, new Random().Next(1, 31)), SubscribeNumber = i * i });
                    }
                }
                return _List;
            }
        }

        public class Task
        {
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public int SubscribeNumber { get; set; }
        }
    }
}
