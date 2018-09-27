using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using DatoUI.VPL.Core;
using DatoUI.VPL.Utilities;

namespace DatoUI.VPL.Test
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            KeyDown += VplControl.VplControl_KeyDown;
            KeyUp += VplControl.VplControl_KeyUp;

            KeyDown += VplGroupControl.MainVplControl.VplControl_KeyDown;
            KeyUp += VplGroupControl.MainVplControl.VplControl_KeyUp;

            Loaded += OnLoaded;
            VplControl.ExternalNodeTypes.AddRange(Utilities.Utilities.GetTypesInNamespace(Assembly.GetExecutingAssembly(), "DatoUI.VPL.Test.Nodes")
                    .ToList());

            VplControl.ExternalNodeTypes.AddRange(Utilities.Utilities.GetTypesInNamespace(Assembly.LoadFile(Path.Combine(Environment.CurrentDirectory, "DatoUI.VPL.Scripting.dll")), "DatoUI.VPL.Scripting.Nodes")
                    .ToList());

            VplControl.ExternalNodeTypes.AddRange(Utilities.Utilities.GetTypesInNamespace(Assembly.LoadFile(Path.Combine(Environment.CurrentDirectory, "DatoUI.VPL.Watch3D.dll")), "DatoUI.VPL.Watch3D.Nodes")
                    .ToList());

            VplControl.NodeTypeMode = NodeTypeModes.All;
            VplGroupControl.MainVplControl.ExternalNodeTypes.AddRange(
                Utilities.Utilities.GetTypesInNamespace(Assembly.GetExecutingAssembly(), "DatoUI.VPL.Test.Nodes")
                    .ToList());

            VplGroupControl.MainVplControl.NodeTypeMode = NodeTypeModes.All;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            //var filePath = @"../testdata/test.vplxml";
            //if (File.Exists(filePath))
            //{
            //    VplControl.OpenFile(filePath);
            //    //VplGroupControl.MainVplControl.OpenFile(filePath);
            //}
        }
    }
}