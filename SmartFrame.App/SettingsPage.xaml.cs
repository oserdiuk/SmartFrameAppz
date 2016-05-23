using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Perception;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using AutoMapper;
using SmartFrame.App.Models;
using SmartFrame.App.PhotoModeServiceReference;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SmartFrame.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page, INotifyPropertyChanged
    {
        private ObservableCollection<PhotoModeItem> photoModeItems;

        public ObservableCollection<PhotoModeItem> PhotoModeItems
        {
            get { return photoModeItems; }
            set
            {
                if (value != photoModeItems)
                {
                    photoModeItems = value;
                    NotifyPropertyChanged("PhotoModeItems");
                }
            }
        }

        public SettingsPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
            this.Loaded += SettingsPage_Loaded;
            Mapper.CreateMap<PhotoModeContract, PhotoModeItem>().ReverseMap();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        private async void SettingsPage_Loaded(object sender, RoutedEventArgs e)
        {
            PhotoModeServiceClient client = new PhotoModeServiceClient();
            var imageModes = await client.GetAllAsync();
            await client.CloseAsync();
            PhotoModeItems = Mapper.Map<ObservableCollection<PhotoModeItem>>(imageModes);
        }

        private async void UploadImagesTb_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker picker = new FileOpenPicker();
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");
            picker.FileTypeFilter.Add(".bmp");
            picker.FileTypeFilter.Add(".jpg");
            var sf = await picker.PickMultipleFilesAsync();
            
            //var stream = await sf.OpenAsync(FileAccessMode.Read);
            //var bitmapImage = new BitmapImage();
            //bitmapImage.SetSource(stream);
            //SelectedImage.Source = bitmapImage;
        }
    }
}
