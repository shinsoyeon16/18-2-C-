using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1205
{
    class Car : Notifier
    {
        public string Title { get; set; }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value;
                OnPropertyChanged("Speed");
            }
        }

        public Car(string title, int speed)
        {
            Title = title;
            Speed = speed;
        }
    }
}
