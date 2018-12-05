//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.ComponentModel;
//using System.Timers;

//namespace test1205
//{
//    class TimerProgram : Notifier
//    {

//        Timer timer = new Timer();
//        private long sec;

//        public long Sec
//        {
//            get { return sec; }
//            set
//            {
//                sec = value;
//                OnPropertyChanged("Sec");
//            }
//        }
//        public bool Enabled { get; set; }
//        public TimerProgram()
//        {
//            Sec = 0;
//        }

//        public void Start()
//        {
//            timer.Interval = 1000; //1초마다 반복되도록 설정
//            timer.Elapsed += new ElapsedEventHandler(timer_event);
//            timer.Start();
//        }

//        private void timer_event(object sender, ElapsedEventArgs e)
//        {
//            Sec += 1;
//            throw new NotImplementedException();
//        }

//        public void Stop()
//        {
//            timer.Stop();
//        }
//    }
//}

