﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace DatoUI.VPL.Core
{
    public class NodeQuestionButton : Button
    {
        public NodeQuestionButton(VplElement hostNodeGroup)
        {
            HostElement = hostNodeGroup;
            //HostElement.HostCanvas.Children.Add(this);
            HostElement.HitTestGrid.Children.Add(this);
            Grid.SetColumn(this, 0);

            Style = FindResource("QuestButton20") as Style;


            HostNodeGroup_PropertyChanged(null, null);
            HostElement.PropertyChanged += HostNodeGroup_PropertyChanged;
        }

        public VplElement HostElement { get; set; }

        private void HostNodeGroup_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var hostPosition = HostElement.GetPosition();
            Canvas.SetTop(this, hostPosition.Y - 30);
            Canvas.SetLeft(this, hostPosition.X - 5);
        }
    }
}