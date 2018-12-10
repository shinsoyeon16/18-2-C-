using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfApp7
{
    class Car : Notifier
    {
        private string title;

        public string Title
        {
            get { return title; }
            set {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set {
                color = value;
                OnPropertyChanged("Color");
            }
        }

        public int Speed { get; set; }

        private Thickness dist;
        public Thickness Dist
        {
            get { return dist; }
            set
            {
                dist = value;
                OnPropertyChanged("Dist");
            }
        }

        DispatcherTimer dispatcher = new DispatcherTimer();

        public Car(string title, int speed)
        {
            this.Title = title;
            this.Speed = speed;
            dispatcher = new DispatcherTimer();
            dispatcher.Interval = new TimeSpan(0, 0, 1);
            dispatcher.Tick += Dispatcher_Tick;
        }
        private void Dispatcher_Tick(object sender, EventArgs e)
        {
           this.Dist = new Thickness() { Left = this.Dist.Left + this.Speed };
        }
        public void Start() {
            this.Speed = 10;
            dispatcher.Start();
        }
        public void Stop() {
            this.Speed = 0;
            dispatcher.Stop();
        }
        public void Accelerate() {
            this.Speed += 10;
        }
        public void Break() {
            this.Speed -= 10;
        }
    }
}
