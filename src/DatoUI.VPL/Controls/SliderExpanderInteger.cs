﻿using System.Windows;
using System.Windows.Controls;

namespace DatoUI.VPL.Controls
{
    public class SliderExpanderInteger : Expander
    {
        public static readonly DependencyProperty SliderValueProperty =
            DependencyProperty.Register("SliderValue",
                typeof (int), typeof (SliderExpanderInteger)); // optionally metadata for defaults etc.

        public static readonly DependencyProperty SliderMinProperty =
            DependencyProperty.Register("SliderMin",
                typeof (int), typeof (SliderExpanderInteger)); // optionally metadata for defaults etc.

        public static readonly DependencyProperty SliderMaxProperty =
            DependencyProperty.Register("SliderMax",
                typeof (int), typeof (SliderExpanderInteger)); // optionally metadata for defaults etc.

        public static readonly DependencyProperty SliderStepProperty =
            DependencyProperty.Register("SliderStep",
                typeof (int), typeof (SliderExpanderInteger)); // optionally metadata for defaults etc.

        public int SliderValue
        {
            get { return (int) GetValue(SliderValueProperty); }
            set { SetValue(SliderValueProperty, value); }
        }

        public int SliderMin
        {
            get { return (int) GetValue(SliderMinProperty); }
            set { SetValue(SliderMinProperty, value); }
        }

        public int SliderMax
        {
            get { return (int) GetValue(SliderMaxProperty); }
            set { SetValue(SliderMaxProperty, value); }
        }

        public int SliderStep
        {
            get { return (int) GetValue(SliderStepProperty); }
            set { SetValue(SliderStepProperty, value); }
        }
    }
}