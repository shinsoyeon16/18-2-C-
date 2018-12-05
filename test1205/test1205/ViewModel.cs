using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace test1205
{
    class ViewModel : Notifier
    {
        private int sec;
        public int Sec
        {
            get { return sec; }
            set
            {
                sec = value;
                OnPropertyChanged("Sec");
            }
        }
        public bool  StartButton { 
            set { Timer.Start(); } }
        public bool StopButton
        {
            set { Timer.Stop(); }
        }
        public bool ResetButton
        {
            set { Sec=0; }
        }
        public Command MyCommand { get; set; }
        public DispatcherTimer Timer { get; set; }
        public ViewModel()
        {
            Sec = 0;
            MyCommand = new Command(ExecuteMethod);

            Timer = new DispatcherTimer();
            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void ExecuteMethod(object obj)
        {
            if ((string)obj == "start")
            {
                Timer.Start();
            }
            else if ((string)obj == "stop")
            {
                Timer.Stop();
            }
            else if ((string)obj == "reset")
            {
                Sec = 0;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Sec += 1;
        }
    }
}
