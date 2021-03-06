﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace MicrosoftAssignment
{
    public sealed partial class ImageUserControl : UserControl
    {
        public static DependencyProperty SourceProperty =
         DependencyProperty.Register("Source",
                typeof(ImageSource),
                typeof(ImageUserControl), null);
        public static DependencyProperty LoadingContentProperty =
          DependencyProperty.Register("LoadingContent",
                typeof(object),
                typeof(ImageUserControl), null);

        public static DependencyProperty FailedContentProperty =
         DependencyProperty.Register("FailedContent",
                typeof(object),
                typeof(ImageUserControl), null);
        public ImageUserControl()
        {
            this.InitializeComponent();
        }
        

        

        public object LoadingContent
        {
            get
            {
                return (base.GetValue(LoadingContentProperty));
            }
            set
            {
                base.SetValue(LoadingContentProperty, value);
            }
        }
        public object FailedContent
        {
            get
            {
                return (base.GetValue(FailedContentProperty));
            }
            set
            {
                base.SetValue(FailedContentProperty, value);
            }
        }

        public ImageSource Source
        {
            get
            {
                return ((ImageSource)base.GetValue(SourceProperty));
            }
            set
            {
                base.SetValue(SourceProperty, value);
            }
        }

        static void OnSourceChanged(DependencyObject sender,
      DependencyPropertyChangedEventArgs args)
        {
            ImageUserControl loader = (ImageUserControl)sender;
            VisualStateManager.GoToState(loader, "Loading", true);
        }

        void OnImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "Failed", true);
        }

        void OnImageOpened(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "Displaying", true);
        }
    }
}
