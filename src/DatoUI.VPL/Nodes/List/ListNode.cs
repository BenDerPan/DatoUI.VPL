using System.Windows;
using System.Windows.Controls;
using DatoUI.VPL.Core;

namespace DatoUI.VPL.Nodes.List
{
    public class ListNode : Node
    {
        public ListNode(Core.VplControl hostCanvas) : base(hostCanvas)
        {
            var label = new Label {Width = 40, Content = "List", Margin = new Thickness(5), FontSize = 14};

            AddControlToNode(label);

            AddInputPortToNode("Items", typeof (object), true);
            AddOutputPortToNode("List", typeof (object));
        }

        public override void Calculate(object userState = null)
        {
            OutputPorts[0].Data = InputPorts[0].Data;
        }

        public override Node Clone()
        {
            var node = new ListNode(HostCanvas)
            {
                Top = Top,
                Left = Left
            };

            return node;
        }
    }
}