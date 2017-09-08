using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinkinapp2.Cevaplar;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace thinkinapp2.SORULAR
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyMantik : ContentPage
	{
		public MyMantik ()
		{
			InitializeComponent ();
		}

        private void mantikcevap_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyAnswerMan());
        }
    }
}