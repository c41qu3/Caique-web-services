using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Shopping_Rural
{

    public class Tela_Cadastra_Produto:ContentPage
    {
        Image foto1;
       
   
        public Tela_Cadastra_Produto() {

            Grid grid = new Grid
            {
                BackgroundColor = Color.LightBlue,
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition {Height = GridLength.Auto},
                    new RowDefinition {Height = GridLength.Auto},
                    new RowDefinition {Height = GridLength.Auto},
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { },
                    new ColumnDefinition { },
                    new ColumnDefinition { }
                }    
            };

            foto1 = new Image()
            {
                //Text = "comprar",
                //FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                //Source = "add",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };
            grid.Children.Add(foto1, 0, 0);

            var iconTap = new TapGestureRecognizer();
            iconTap.Tapped += (object sender, EventArgs e) =>
            {
                //foto_Clicked(sender,e);
            };

            foto1.GestureRecognizers.Add(iconTap);
       

            Image foto2 = new Image()
            {
                //Text = "comprar",
                //FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                //Source = "add",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };

            grid.Children.Add(foto2, 1, 0);

            Image foto3 = new Image()
            {
                //Text = "comprar",
                //FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                //Source = "add.jpg",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };
            
            grid.Children.Add(foto3, 2, 0);

            Button btnVender = new Button()
            {
                Text = "vender",
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
            grid.Children.Add(btnVender, 3, 0);
            

            this.Content = grid;
            btnVender.Clicked += TirarFoto;
        }
        private async void TirarFoto(object sender, EventArgs e)
        {
            try
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.Current.IsCameraAvailable)
                {
                    await DisplayAlert("Ops", "Nenhuma câmera detectada.", "OK");

                    return;
                }

                var file = await CrossMedia.Current.TakePhotoAsync(
                    new StoreCameraMediaOptions
                    {
                        SaveToAlbum = true,
                        Directory = "Demo"
                    });

                if (file == null)
                    return;

                foto1.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;

                });
            }
            catch (Exception ex) {
                Console.WriteLine("Exception information: {0}", e);
                String a;
            }
        }
        
    

        public async void EscolherFoto(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Ops", "Galeria de fotos não suportada.", "OK");

                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();

            if (file == null)
                return;

            foto1.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;

            });
        }
    }
}
