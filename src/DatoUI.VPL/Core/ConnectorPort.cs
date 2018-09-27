using System.Windows;
using System.Windows.Controls;

namespace DatoUI.VPL.Core
{
    public class ConnectorPort : Control
    {
        private readonly VplControl hostCanvas;

        public ConnectorPort(VplControl hostCanvas)
        {
            this.hostCanvas = hostCanvas;


            Style = hostCanvas.FindResource("VplConnectorPortStyle") as Style;

            hostCanvas.Children.Add(this);
        }
    }
}