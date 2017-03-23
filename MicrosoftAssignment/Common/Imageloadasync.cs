using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.FileProperties;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace MicrosoftAssignment.Common
{
   
    class Imageloadasync : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            BitmapImage image = new BitmapImage(new Uri(value.ToString()));                       
            return (image);
        }
       
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
        
    }
}
