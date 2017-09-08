using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinkinapp2.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace thinkinapp2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrawerPage : ContentPage
    {
        private Dictionary<string, Color> ColorPallete;
        private ImageWithTouch DrawingImage;

        public DrawerPage Children { get; internal set; }

        public DrawerPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.PrepareData();
        }

        void PrepareData()
        {
            BuildColorPallete();

            DrawingImage = new ImageWithTouch
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                CurrentLineColor = Color.Black
        };

            DrawingImage.SetBinding(ImageWithTouch.CurrentLineColorProperty, "CurrentLineColor");
            myFrame.Content = DrawingImage;
            foreach (var button in ColorPallete.Select(color => new Button
            {
                Text = color.Key,
                TextColor = GetTextColor(color.Value),
                BackgroundColor = color.Value,
                HeightRequest = 40,
                WidthRequest = 100,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            }))
            {
                button.Clicked += Button_Clicked;
                listColors.Children.Add(button);
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            DrawingImage.CurrentLineColor = button.BackgroundColor;
        }

        private static Color GetTextColor(Color backgroundColor)
        {
            var backgroundColorDelta = ((backgroundColor.R * 0.3) + (backgroundColor.G * 0.6) + (backgroundColor.B * 0.1));
             return (backgroundColorDelta > 0.4f) ? Color.Black : Color.White;
           
        }

        private void StackLayout_SizeChanged(object sender, EventArgs e)
        {
            var stackLayout = (StackLayout)sender;

            var width = stackLayout.Width;
            var height = stackLayout.Height;

            if (width <= 0 || height <= 0)
            {
                return;
            }

            var stackChildSize = height / stackLayout.Children.Count;
            var font = Font.BoldSystemFontOfSize(1 * stackChildSize);
         

            foreach (var button in stackLayout.Children.Cast<Button>())
            {
                button.Font = font;

                button.HeightRequest = stackChildSize - 3;
            }
        }

        private void BuildColorPallete()
        {
            ColorPallete = new Dictionary<string, Color>
            {
                { "Silgi", Color.White },
                { "Gümüş", Color.Silver },
                { "Gri", Color.Gray },
                { "Sarı", Color.Yellow },
                { "Pembe", Color.Pink},
                { "Mavi", Color.Blue },
                { "Haki", Color.DarkKhaki },
                { "Mor", Color.Purple },
                { "Yeşil", Color.Green },
                { "Kırmızı", Color.Red },
                { "Turuncu", Color.Orange },
                { "Fuşya", Color.Fuschia },
                { "Black", Color.Black },
            };

           

        }

        
    }
}