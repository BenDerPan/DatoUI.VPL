﻿using System.Windows;
using System.Windows.Controls.Primitives;
using DatoUI.VPL.Core;

namespace DatoUI.VPL.Nodes.Logic
{
    internal class TrueFalseNode : Node
    {
        private readonly ToggleButton toggleButton;

        public TrueFalseNode(Core.VplControl hostCanvas)
            : base(hostCanvas)
        {
            toggleButton = new ToggleButton
            {
                Width = 40,
                Height = 40,
                Margin = new Thickness(5)
            };

            toggleButton.Checked += toggleButton_Checked;
            toggleButton.Unchecked += toggleButton_Unchecked;

            AddControlToNode(toggleButton);

            AddOutputPortToNode("State", typeof (bool));

            toggleButton.IsChecked = true;
        }

        private void toggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            toggleButton.Content = "False";
            OutputPorts[0].Data = toggleButton.IsChecked;
        }

        private void toggleButton_Checked(object sender, RoutedEventArgs e)
        {
            toggleButton.Content = "True";
            OutputPorts[0].Data = toggleButton.IsChecked;
        }

        public override void Calculate(object userState = null)
        {
        }

        public override Node Clone()
        {
            var node = new TrueFalseNode(HostCanvas)
            {
                Top = Top,
                Left = Left
            };

            return node;
        }
    }
}