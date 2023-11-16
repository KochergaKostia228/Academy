using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Академія.Domain.Task
{
    public class MyTask : INotifyPropertyChanged
    {
        private string? name { get; set; }
        private string? description { get; set; }
        private int? rating { get; set; }

        public MyTask(string name, string description) {  Name = name; Description = description; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public string? Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            } 
        }
        public string? Description 
        {
            get
            {
                return this.description;
            }
            set
            {
                description = value; 
                OnPropertyChanged("Description");
            }
        }
        public int? Rating 
        {
            get
            {
                return this.rating;
            }
            set
            {
                rating = value;
                OnPropertyChanged("Rating");
            }
        }

        protected void OnPropertyChanged(string propetyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
        }
    }
}
