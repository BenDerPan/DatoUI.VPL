using System.Windows;
using System.Windows.Controls;
using System.Xml;
using DatoUI.VPL.Core;

namespace DatoUI.VPL.Nodes.Math
{
    public class AbsNode : Node
    {
        public AbsNode(Core.VplControl hostCanvas) : base(hostCanvas)
        {
            AddInputPortToNode("Value", typeof (double));
            AddOutputPortToNode("AbsValue", typeof (double));

            var label = new Label
            {
                Content = "Abs",
                FontSize = 30,
                HorizontalContentAlignment = HorizontalAlignment.Center
            };

            AddControlToNode(label);
        }

        public override void Calculate(object userState)
        {
            OutputPorts[0].Data = System.Math.Abs(double.Parse(InputPorts[0].Data.ToString()));
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
            return new AbsNode(HostCanvas)
            {
                Top = Top,
                Left = Left
            };
        }
    }
}