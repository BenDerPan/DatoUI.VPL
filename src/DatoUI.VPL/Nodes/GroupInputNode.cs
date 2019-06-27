using System.Windows.Controls;
using System.Xml;
using DatoUI.VPL.Core;

namespace DatoUI.VPL.Nodes
{
    public class GroupInputNode : Node
    {
        public GroupInputNode(Core.VplControl hostCanvas)
            : base(hostCanvas)
        {
            AddOutputPortToNode("Input", typeof (object));

            var textBox = new TextBox();
            var comboBox = new ComboBox();

            AddControlToNode(textBox);
            AddControlToNode(comboBox);
        }

        public override void Calculate(object userState = null)
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
            return new GroupInputNode(HostCanvas)
            {
                Top = Top,
                Left = Left
            };
        }
    }
}