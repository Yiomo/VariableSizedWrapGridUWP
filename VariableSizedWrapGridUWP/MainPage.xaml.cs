using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

//http://blog.jerrynixon.com/2012/08/windows-8-beauty-tip-using.html VariableSizedWrapGrid

namespace VariableSizedWrapGridUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var _Colors = typeof(Colors).GetRuntimeProperties().Select((c,x) => new { Color = (Windows.UI.Color)c.GetValue(null), Name = c.Name, index=x,ColSpan=ColSpan(x), RowSpan=RowSpan(x)});
            this.DataContext = _Colors;
        }

        private object RowSpan(int x)
        {
            return 1;
        }

        private object ColSpan(int x)
        {
            return 1;
        }

    }
}
