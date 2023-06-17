using Images.Models;
using System.Collections.ObjectModel;

namespace Images.Views;

public partial class DashboardView : ContentPage
{
    public ObservableCollection<Profile> Profiles { get; set; }
    public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }


    public DashboardView()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        Profiles = new ObservableCollection<Profile>
        {
            new Profile()
            {
                Name = "Hector",
                ProfileImage = "dotnet_bot.png",
                NoPhotos = 5
            },
            new Profile()
            {
                Name = "Andres",
                ProfileImage = "dotnet_bot.png",
                NoPhotos = 5
            },

             new Profile()
            {
                Name = "Andres",
                ProfileImage = "dotnet_bot.png",
                NoPhotos = 5
            }
        };

        GeneratedImages = new ObservableCollection<GeneratedImage>
        {
            new GeneratedImage()
            {
                ImagePath = "dotnet_bot.svg",
                MainKeyword = "Castle",
                Keywords = new List<string>
                {
                    "Epic, hill, mountain, Tree, CoreBluetooth sky"
                }
            },
            new GeneratedImage()
            {
                ImagePath = "dotnet_bot.svg",
                MainKeyword = "Mountains",
                Keywords = new List<string>
                {
                    "Epic, hill, mountain, Tree, CoreBluetooth sky"
                }
            },
            new GeneratedImage()
            {
                ImagePath = "dotnet_bot.svg",
                MainKeyword = "Castle",
                Keywords = new List<string>
                {
                    "Epic, hill, mountain, Tree, CoreBluetooth sky"
                }
            }
        };
    }
}