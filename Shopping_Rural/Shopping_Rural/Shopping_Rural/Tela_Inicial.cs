using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Shopping_Rural
{
    public class Tela_Inicial : ContentPage
    {
        public Tela_Inicial() {
            /*
            Label l = new Label
             {
                 Text = "teste",
                 FontSize = 25,
                 HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center
             };

            var imagem3 = new Image
            {
                Source = "trator.png",
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
             };
             */
             /*
           
                // Number to manipulate.
                double number = 1;
                // Create the Label for display.
                Label label = new Label
                {
                    Text = number.ToString(),
                    FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                // Create the first Button and attach Clicked handler.
                Button timesButton = new Button
                {
                    Text = "Cadastrar-se",
                    FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Button)),
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                timesButton.Clicked += (sender, args) =>
                {
                    number *= 2;
                    label.Text = number.ToString();
                };
            */
            // Create the second Button and attach Clicked handler.

            // Create the second Button and attach Clicked handler.

            Grid grid = new Grid
            {
                BackgroundColor =Color.LightBlue,
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition {  },
                    new RowDefinition { Height = GridLength.Auto },
                   
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { },
                    new ColumnDefinition { },
                   
                }
            };

            grid.Children.Add(new Label
            {
                Text = "",
                TextColor = Color.White,
                BackgroundColor = Color.Red
            }, 0, 0);

            grid.Children.Add(new Label
            {
                Text = "",
                TextColor = Color.White,
                BackgroundColor = Color.Red
            }, 1, 0);


        

            grid.Children.Add(new Image
            {
                Source ="trator.png",
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center


            },0,2,1,2);

            Button comprar = new Button()
            {
                Text = "comprar",
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                HorizontalOptions = LayoutOptions.Fill,
                BackgroundColor = Color.FromHex("#4169E1"),
                TextColor = Color.White
            };
            grid.Children.Add(comprar, 0, 2);


            Button vender  = new Button()
            {
                Text = "vender",
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                HorizontalOptions = LayoutOptions.Fill,
                BackgroundColor = Color.FromHex("#4169E1"),
                
                TextColor = Color.White
            };
            grid.Children.Add(vender, 1, 2);




            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            this.BackgroundColor = Color.LightBlue;
            // Build the page.
            this.Content = grid;

            // this.Content = grid;
            
            
            //cadastrar.Clicked += btn_OnButtonClicked;
            vender.Clicked += Go_vender;
            comprar.Clicked += Go_comprar;
        }
               private async void Go_vender(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tela_Cadastra_Produto());
        }
        private async void Go_comprar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tela_comprar());
        }
    }
}
  

