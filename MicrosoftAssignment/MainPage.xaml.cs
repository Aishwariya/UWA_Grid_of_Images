using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Search;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MicrosoftAssignment
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();
            
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            
            ObservableCollection<Uri> uris = new ObservableCollection<Uri>()
              {
                new Uri("http://static.pexels.com/photos/2324/skyline-buildings-new-york-skyscrapers.jpg"),
                new Uri("http://static.pexels.com/photos/1562/italian-landscape-mountains-nature.jpg"),
                new Uri("http://static.pexels.com/photos/479/landscape-nature-sunset-trees.jpg"),
                new Uri("http://static.pexels.com/photos/17679/pexels-photo.jpg"),
                new Uri("http://static.pexels.com/photos/7096/people-woman-coffee-meeting.jpg"),
                new Uri("http://static.pexels.com/photos/7919/pexels-photo.jpg"),
                new Uri("http://static.pexels.com/photos/36487/above-adventure-aerial-air.jpg"),
                new Uri("http://static.pexels.com/photos/1848/nature-sunny-red-flowers.jpg"),
                new Uri("http://static.pexels.com/photos/33045/lion-wild-africa-african.jpg"),
                new Uri("http://static.pexels.com/photos/215/road-sky-clouds-cloudy.jpg"),
                new Uri("http://static.pexels.com/photos/7097/people-coffee-tea-meeting.jpg"),
                new Uri("http://static.pexels.com/photos/5358/sea-beach-holiday-vacation.jpg"),
                new Uri("http://static.pexels.com/photos/2422/sky-earth-galaxy-universe.jpg"),
                new Uri("http://static.pexels.com/photos/1984/black-and-white-city-man-people.jpg"),
                new Uri("http://static.pexels.com/photos/1029/landscape-mountains-nature-clouds.jpg"),
                new Uri("http://static.pexels.com/photos/3847/jetty-landing-stage-sea-sky.jpeg"),
                new Uri("http://static.pexels.com/photos/21787/pexels-photo.jpg"),
                new Uri("http://static.pexels.com/photos/55787/pexels-photo-55787.jpeg"),
                new Uri("http://static.pexels.com/photos/24193/pexels-photo.jpg"),
                new Uri("http://static.pexels.com/photos/7075/people-office-group-team.jpg"),
                new Uri("http://static.pexels.com/photos/6471/woman-hand-smartphone-desk.jpg"),
                new Uri("http://static.pexels.com/photos/1139/black-and-white-city-skyline-buildings.jpg"),
                new Uri("http://static.pexels.com/photos/1780/landscape-nature-clouds-cloudy.jpg"),
                //below link - Access is been denied!
                new Uri("http://static.pexels.com/photos/9635/suit-portrait-preparation-wedding.jpg"),
                new Uri("http://static.pexels.com/photos/27406/pexels-photo-27406.jpg"),
                new Uri("http://static.pexels.com/photos/2752/city-sunny-people-street.jpg"),
                new Uri("http://static.pexels.com/photos/7374/startup-photos.jpg"),
                new Uri("http://static.pexels.com/photos/4825/red-love-romantic-flowers.jpg"),
                new Uri("http://static.pexels.com/photos/232/apple-iphone-books-desk.jpg"),
                new Uri("http://static.pexels.com/photos/35550/ipad-tablet-technology-touch.jpg"),
                new Uri("http://static.pexels.com/photos/1380/black-and-white-city-skyline-buildings.jpg"),
                new Uri("http://static.pexels.com/photos/93684/pexels-photo-93684.jpeg"),
                new Uri("http://static.pexels.com/photos/7095/people-coffee-notes-tea.jpg"),
                new Uri("http://static.pexels.com/photos/12567/photo-1444703686981-a3abbc4d4fe3.jpeg"),
                new Uri("http://static.pexels.com/photos/6550/nature-sky-sunset-man.jpeg"),
                new Uri("http://static.pexels.com/photos/909/flowers-garden-colorful-colourful.jpg"),
                new Uri("http://static.pexels.com/photos/1341/blue-abstract-glass-balls.jpg"),
                new Uri("http://static.pexels.com/photos/54278/pexels-photo-54278.jpeg"),
                new Uri("http://static.pexels.com/photos/6224/hands-people-woman-working.jpg"),
                new Uri("http://static.pexels.com/photos/9574/pexels-photo.jpeg"),
                new Uri("http://static.pexels.com/photos/6335/man-coffee-cup-pen.jpg"),
                new Uri("http://static.pexels.com/photos/580/streets-landscape-mountains-nature.jpg"),
                new Uri("http://static.pexels.com/photos/1188/city-landmark-lights-night.jpg"),
                new Uri("http://static.pexels.com/photos/70292/pexels-photo-70292.jpeg"),
                new Uri("http://static.pexels.com/photos/7369/startup-photos.jpg"),
                new Uri("http://static.pexels.com/photos/1440/city-road-street-buildings.jpg"),
                new Uri("http://static.pexels.com/photos/30342/pexels-photo-30342.jpg"),
                new Uri("http://static.pexels.com/photos/932/road-street-desert-industry.jpg"),
                new Uri("http://static.pexels.com/photos/34014/pexels-photo.jpg"),
                new Uri("http://static.pexels.com/photos/413/sunglasses-love-woman-flowers.jpg"),

                new Uri(@"ms-appx:/Images/bigwindows.jpg"),
                new Uri(@"ms-appx:/Images/blurrylights.jpg"),
                new Uri(@"ms-appx:/Images/books.jpg"),
                new Uri(@"ms-appx:/Images/calmwater.jpg"),
                new Uri(@"ms-appx:/Images/charts.jpg"),
                new Uri(@"ms-appx:/Images/chillin.jpg"),
                new Uri(@"ms-appx:/Images/citylife.jpg"),
                new Uri(@"ms-appx:/Images/citylights.jpg"),
                new Uri(@"ms-appx:/Images/coffeeandphone.jpg"),
                new Uri(@"ms-appx:/Images/coins.jpg"),
                new Uri(@"ms-appx:/Images/cows.jpg"),
                new Uri(@"ms-appx:/Images/essentials.jpg"),
                new Uri(@"ms-appx:/Images/fastcar.jpg"),
                new Uri(@"ms-appx:/Images/field.jpg"),
                new Uri(@"ms-appx:/Images/flat.jpg"),
                new Uri(@"ms-appx:/Images/food.jpg"),
                new Uri(@"ms-appx:/Images/frog.jpg"),
                new Uri(@"ms-appx:/Images/girl.jpg"),
                new Uri(@"ms-appx:/Images/heart.jpg"),
                new Uri(@"ms-appx:/Images/inacall.jpg"),
                new Uri(@"ms-appx:/Images/inthenow.jpg"),
                new Uri(@"ms-appx:/Images/jump.jpg"),
                new Uri(@"ms-appx:/Images/laptop.jpg"),
                new Uri(@"ms-appx:/Images/legs.jpg"),
                new Uri(@"ms-appx:/Images/lift.jpg"),
                new Uri(@"ms-appx:/Images/liveconcert.jpg"),
                new Uri(@"ms-appx:/Images/meetingroom.jpg"),
                new Uri(@"ms-appx:/Images/modernoffice.jpg"),
                new Uri(@"ms-appx:/Images/mountains.jpg"),
                new Uri(@"ms-appx:/Images/nebula.jpg"),
                new Uri(@"ms-appx:/Images/niceview.jpg"),
                new Uri(@"ms-appx:/Images/nightcrowd.jpg"),
                new Uri(@"ms-appx:/Images/ontopofthings.jpg"),
                new Uri(@"ms-appx:/Images/palmtrees.jpg"),
                new Uri(@"ms-appx:/Images/pay.jpg"),
                new Uri(@"ms-appx:/Images/planning.jpg"),
                new Uri(@"ms-appx:/Images/river.jpg"),
                new Uri(@"ms-appx:/Images/road.jpg"),
                new Uri(@"ms-appx:/Images/rockinwaves.jpg"),
                new Uri(@"ms-appx:/Images/skyline.jpg"),
                new Uri(@"ms-appx:/Images/snacks.jpg"),
                new Uri(@"ms-appx:/Images/socks.jpg"),
                new Uri(@"ms-appx:/Images/spacewalk.jpg"),
                new Uri(@"ms-appx:/Images/straws.jpg"),
                new Uri(@"ms-appx:/Images/systemdesign.jpg"),
                new Uri(@"ms-appx:/Images/tree.jpg"),
                new Uri(@"ms-appx:/Images/tulips.jpg"),
                new Uri(@"ms-appx:/Images/valley.jpg"),
                new Uri(@"ms-appx:/Images/vulcano.jpg"),
                new Uri(@"ms-appx:/Images/whisper.jpg"),
                new Uri(@"ms-appx:/Images/workdone.jpg")
                
              };
                    List<Uri> SortedList = uris.OrderBy(o => Path.GetFileName(o.AbsolutePath)).ToList();
                    this.DataContext = SortedList;
                  
        }

       
    }
}
