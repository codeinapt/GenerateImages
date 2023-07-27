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
        BindingContext = this;
    }

    private void LoadData()
    {
        Profiles = new ObservableCollection<Profile>
        {
            new Profile()
            {
                Name = "Hector",
                ProfileImage = "palette.svg",
                NoPhotos = 5
            },
            new Profile()
            {
                Name = "Andres",
                ProfileImage = "planet.svg",
                NoPhotos = 5
            },

             new Profile()
            {
                Name = "Pedro",
                ProfileImage = "books.svg",
                NoPhotos = 5
            }
        };

        GeneratedImages = new ObservableCollection<GeneratedImage>
        {
            new GeneratedImage()
            {
                ImagePath = "https://yt3.googleusercontent.com/yU2MZfPsBxFgPsm_T2kODDSsCdL2i77E_ht3RXC7IazIVQQhyasWwbqAGUmmxsv17K_rMbjrN2M=s900-c-k-c0x00ffffff-no-rj",
                MainKeyword = "Castle",
                Keywords = new List<string>
                {
                    "Epic, hill, mountain,  Tree, CoreBluetooth sky"
                }
            },
            new GeneratedImage()
            {
                ImagePath = "https://media.licdn.com/dms/image/C4E03AQGJok9rJovftw/profile-displayphoto-shrink_800_800/0/1516589785525?e=2147483647&v=beta&t=edbjHQh52U-bpw9tE3QQVd1enqkjW0Y0r7vQIxw0jmw",
                MainKeyword = "Mountains",
                Keywords = new List<string>
                {
                    "Epic, hill, mountain, Tree, CoreBluetooth sky"
                }
            },
            new GeneratedImage()
            {
                ImagePath = "https://pbs.twimg.com/profile_images/1471156806948986886/6bBYa3E5_400x400.jpg",
                MainKeyword = "Castle",
                Keywords = new List<string>
                {
                    "Epic, hill, mountain, Tree, CoreBluetooth sky"
                }
            }
        };
    }
}