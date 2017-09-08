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
    public partial class MyMaster : ContentPage
    {
        public MyMaster()
        {
            InitializeComponent();

        }

        private void btnMan_Clicked(object sender, EventArgs e)
        {

            Navigation.PushModalAsync(new MyCarousel());


        }

        private void btnMat_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyCarousel2());
        }

        private void btnPara_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyCarousel3());
        }

        private void btnCev_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyAnswer());
        }
    }
}