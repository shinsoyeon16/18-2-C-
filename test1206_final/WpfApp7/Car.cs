using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp7
{
    class Car : Button
    {
        public string Title { get; set; }
        // 색상은 못하겠습니다ㅠㅠ  public SolidColorBrush Color { get; set; }
        public int Speed { get; set; }
        public string Position { get; set; }
        public string isCarRun { get; set; }

        public void Start(object obj) {
            Speed = 0;
            isCarRun = "Visible";
            Position = 10+"";
            Title = obj.ToString(); 
        }
        public void Stop() {
            Speed = 0;
            Title = "";
            isCarRun = "Hidden";
            Position = (10+Speed).ToString() + ",10,0,10";
       }
        public void Accelerate() { Speed += 10; Position = (10 + Speed).ToString() + ",10,0,10"; }
        public void Break() { Speed -= 10; Position = (10 + Speed).ToString() + ",10,0,10"; }
    }
}
