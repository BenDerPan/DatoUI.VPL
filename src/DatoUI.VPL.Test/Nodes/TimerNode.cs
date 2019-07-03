using DatoUI.VPL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace DatoUI.VPL.Test.Nodes
{
    public class TimerNode : Node
    {
        DispatcherTimer timer;
        TextBox tbInterval;
        public TimerNode(VplControl hostCanvas):base(hostCanvas)
        {
            AddOutputPortToNode("String", typeof(string));
            Button btnStart = new Button { Content = "Start Timer" };
            btnStart.Click += BtnStart_Click;
            tbInterval = new TextBox() { Width = 80, Text = "1000",VerticalContentAlignment=System.Windows.VerticalAlignment.Center,VerticalAlignment=System.Windows.VerticalAlignment.Center };
            StackPanel panel = new StackPanel() { Orientation = Orientation.Horizontal };
            panel.Children.Add(new TextBlock() { Text = "计时器间隔",VerticalAlignment=System.Windows.VerticalAlignment.Center });
            panel.Children.Add(tbInterval);
            AddControlToNode(new TextBlock { Text = "MBot计时器(ms)" });
            AddControlToNode(panel);
            AddControlToNode(btnStart);

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Calculate();
        }

        private void BtnStart_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (timer.IsEnabled)
            {
                timer.Stop();
                (sender as Button).Content = "Start Timer";
                tbInterval.IsEnabled = true;
            }
            else
            {
                timer.Interval = TimeSpan.FromMilliseconds(int.Parse(tbInterval.Text));
                timer.Start();
                (sender as Button).Content = "Stop Timer";
                tbInterval.IsEnabled = false;
            }
        }

        public override void Calculate(object userState = null)
        {
            OutputPorts[0].Data = DateTime.Now.ToString("HH:mm:ss");
        }

        public override Node Clone()
        {
            return new TimerNode(HostCanvas)
            {
                Top = Top,
                Left = Left
            };
        }
    }
}
