using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp7
{
    class ViewModel : Notifier
    {
        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
                OnTitleChanged();
            }
        }

        private void OnTitleChanged()
        {
            myCar.Title = Title;
        }

        private string color;

        public string Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged("Color");
                OnColorChanged();
            }
        }

        private void OnColorChanged()
        {
            myCar.Color = Color;
        }

        public CarCommand MyStart { get; set; }
        public CarCommand MyStop { get; set; }
        public CarCommand MyAccel { get; set; }
        public CarCommand MyBreak { get; set; }

        public Car myCar;

        public ViewModel()
        {
            MyStart = new CarCommand(ExecStartMethod);
            MyStop = new CarCommand(ExecStopMethod);
            MyAccel = new CarCommand(ExecAccelMethod);
            MyBreak = new CarCommand(ExecBreakMethod);
            
            myCar = new Car("MyCar", 0);
        }

        //private void SelectCar1Method()
        //{
        //    Title = myCar1.Title;
        //        Color = myCar1.Color;
        //        myCar = myCar1;
            
        //}
        //private void SelectCar2Method()
        //{
        //    Title = myCar2.Title;
        //    Color = myCar2.Color;
        //    myCar = myCar2;
        //}
        //private void SelectCar3Method()
        //{
        //    Title = myCar3.Title;
        //    Color = myCar3.Color;
        //    myCar = myCar3;
        //}

        private void ExecBreakMethod()
        {
            myCar.Break();
        }

        private void ExecAccelMethod()
        {
            myCar.Accelerate();
        }

        private void ExecStopMethod()
        {
            myCar.Stop();
        }

        private void ExecStartMethod()
        {
            myCar.Start();
        }
    }
}
