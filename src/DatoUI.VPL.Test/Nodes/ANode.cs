using System.Windows.Controls;
using System.Xml;
using DatoUI.VPL.Core;

namespace DatoUI.VPL.Test.Nodes
{
    public class ANode : Node
    {
        public ANode(Core.VplControl hostCanvas)
            : base(hostCanvas)
        {
            AddControlToNode(new Label { Content = "ANode测试" });
            AddInputPortToNode("AInput1", typeof (string));
            AddOutputPortToNode("AOutput1", typeof (string));

           
        }

        public override void Calculate()
        {
            OutputPorts[0].Data = InputPorts[0].Data;
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
            return new ANode(HostCanvas)
            {
                Top = Top,
                Left = Left
            };
        }
    }
}