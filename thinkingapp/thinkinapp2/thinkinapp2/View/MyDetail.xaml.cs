using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinkinapp2.SORULAR;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace thinkinapp2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyDetail : ContentPage
    {
        public MyDetail()
        {
            InitializeComponent();
        }

       

        private void btnCevaplar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyAnswer());
        }

        private void btnMantık_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyCarousel());
        }

        private void btnPara_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyCarousel3());
        }

        private void btnMath_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyCarousel2());
        }
    }
}