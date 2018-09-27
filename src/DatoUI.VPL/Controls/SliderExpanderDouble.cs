﻿using System.Windows;
using System.Windows.Controls;

namespace DatoUI.VPL.Controls
{
    public class SliderExpanderDouble : Expander
    {
        public static readonly DependencyProperty SliderValueProperty =
            DependencyProperty.Register("SliderValue",
                typeof (double), typeof (SliderExpanderDouble)); // optionally metadata for defaults etc.

        public static readonly DependencyProperty SliderMinProperty =
            DependencyProperty.Register("SliderMin",
                typeof (double), typeof (SliderExpanderDouble)); // optionally metadata for defaults etc.

        public static readonly DependencyProperty SliderMaxProperty =
            DependencyProperty.Register("SliderMax",
                typeof (double), typeof (SliderExpanderDouble)); // optionally metadata for defaults etc.

        public static readonly DependencyProperty SliderStepProperty =
            DependencyProperty.Register("SliderStep",
                typeof (double), typeof (SliderExpanderDouble)); // optionally metadata for defaults etc.

        public double SliderValue
        {
            get { return (double) GetValue(SliderValueProperty); }
            set { SetValue(SliderValueProperty, value); }
        }

        public double SliderMin
        {
            get { return (double) GetValue(SliderMinProperty); }
            set { SetValue(SliderMinProperty, value); }
        }

        public double SliderMax
        {
            get { return (double) GetValue(SliderMaxProperty); }
            set { SetValue(SliderMaxProperty, value); }
        }

        public double SliderStep
        {
            get { return (double) GetValue(SliderStepProperty); }
            set { SetValue(SliderStepProperty, value); }
        }
    }
}