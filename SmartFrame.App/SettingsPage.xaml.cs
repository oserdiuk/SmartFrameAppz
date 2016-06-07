using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Devices.Perception;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using static Windows.Storage.ApplicationData;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using AutoMapper;
using SmartFrame.App.ImageServiceReference;
using SmartFrame.App.Models;
using SmartFrame.App.PhotoModeServiceReference;
using PhotoModeContract = SmartFrame.App.PhotoModeServiceReference.PhotoModeContract;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SmartFrame.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page, INotifyPropertyChanged
    {
        private const string loginSetting = "test";
        private const int moodId = 1;
        private const double imageHeight = 150;
        private const double imageMargin = 10;
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

            ImageServiceClient imageClient = new ImageServiceClient();
            var images = await imageClient.GetMyImagesAsync(loginSetting);
            ShowImages(images);
            await client.CloseAsync();
        }

        private void ShowImages(ImageServiceReference.ImageContract images)
        {
            Image image = new Image();
            foreach (var item in images.ImageNames)
            {
                image.Height = imageHeight;
                image.Margin = new Thickness(0, 0, 0, imageMargin);
                image.Source = new BitmapImage(new Uri(item));
                Images.Children.Add(image);

                image = new Image();
            }
        }

        private async void UploadImagesTb_Click(object sender, RoutedEventArgs e)
        {
            var picker = new FileOpenPicker();
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");
            picker.FileTypeFilter.Add(".bmp");
            picker.FileTypeFilter.Add(".jpg");
            var selectedImage = await picker.PickSingleFileAsync();
            var imageBytes = await GetBytesAsync(selectedImage);

            ImageServiceClient client = new ImageServiceClient();
            await client.UploadImageAsync(imageBytes, moodId, loginSetting);
            await client.CloseAsync();

            this.Frame.Navigate(typeof(SettingsPage));
        }

        private async Task<byte[]> GetBytesAsync(StorageFile file)
        {
            byte[] fileBytes = null;
            if (file == null) return null;
            using (var stream = await file.OpenReadAsync())
            {
                fileBytes = new byte[stream.Size];
                using (var reader = new DataReader(stream))
                {
                    await reader.LoadAsync((uint)stream.Size);
                    reader.ReadBytes(fileBytes);
                }
            }

            return fileBytes;
        }
    }
}
