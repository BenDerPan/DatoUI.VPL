using System.Windows;
using System.Windows.Controls;
using System.Xml;
using DatoUI.VPL.Core;

namespace DatoUI.VPL.Nodes.Math
{
    public class ModNode : Node
    {
        public ModNode(Core.VplControl hostCanvas) : base(hostCanvas)
        {
            AddInputPortToNode("Value1", typeof (double));
            AddInputPortToNode("Value2", typeof (double));

            AddOutputPortToNode("Value", typeof (double));

            var label = new Label
            {
                Content = "%",
                FontSize = 30,
                HorizontalContentAlignment = HorizontalAlignment.Center
            };

            AddControlToNode(label);
        }

        public override void Calculate(object userState = null)
        {
            OutputPorts[0].Data = double.Parse(InputPorts[0].Data.ToString())%
                                  double.Parse(InputPorts[1].Data.ToString());
        }

        public override void SerializeNetwork(XmlWriter xmlWriter)
        {
            base.SerializeNetwork(xmlWriter);

            // add your xml serialization methods here
        }

        public override void DeserializeNetwork(XmlReader xmlReader)
        {
            base.DeserializeNetwork(xmlReader);

            // add your xml deserialization methods here
        }

        public override Node Clone()
        {
            return new ModNode(HostCanvas)
            {
                Top = Top,
                Left = Left
            };
        }
    }
}