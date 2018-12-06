using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp7
{
    class ViewModel : Notifier
    {
        Car car;
        public void CarChanged()
        {
            Title = car.Title; Speed = car.Speed; Position = car.Position; isCarRun = car.isCarRun;
        }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                speed = value; OnPropertyChanged("Speed");
            }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged("Title"); }
        }
        private string position;
        public string Position
        {
            get { return position; }
            set { position = value; OnPropertyChanged("Position"); }
        }
        private string isCarrun;

        public string isCarRun
        {
            get { return isCarrun; }
            set { isCarrun = value; OnPropertyChanged("isCarRun"); }
        }

        public Command MyCommand { get; set; }
        public ViewModel()
        {
            car = new Car();
            MyCommand = new Command(ExecuteMethod);
            car.isCarRun = "Hidden";
            CarChanged();
        }
        private void ExecuteMethod(object obj)
        {
            switch ((string)obj)
            {
                case "Accelerate": { if (Speed == 700) { MessageBox.Show("속력을 올릴 수 없습니다."); break; } car.Accelerate(); break; }
                case "Break": { if (Speed == 0) { MessageBox.Show("속력을 내릴 수 없습니다."); break; } car.Break(); break; }
                case "Stop": { car.Stop(); break; }
                default: { if (obj.ToString() == "") { MessageBox.Show("차 이름을 입력해주십시오."); break; } car.Start(obj);  break; }
            }
            CarChanged();
        }
    }
}

