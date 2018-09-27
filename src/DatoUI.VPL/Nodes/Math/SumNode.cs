using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using DatoUI.VPL.Core;

namespace DatoUI.VPL.Nodes.Math
{
    public class SumNode : Node
    {
        public SumNode(Core.VplControl hostCanvas) : base(hostCanvas)
        {
            AddInputPortToNode("Values", typeof (object), true);
            AddOutputPortToNode("Value", typeof (double));

            var label = new Label
            {
                Content = "Sum",
                FontSize = 30,
                HorizontalContentAlignment = HorizontalAlignment.Center
            };

            AddControlToNode(label);
        }

        public override void Calculate()
        {
            double sum = 0;

            var collection = InputPorts[0].Data as ICollection;
            if (collection != null)
            {
                sum += collection.Cast<object>().Sum(obj => double.Parse(obj.ToString()));
            }
            OutputPorts[0].Data = sum;
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
            return new SumNode(HostCanvas)
            {
                Top = Top,
                Left = Left
            };
        }
    }
}