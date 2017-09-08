using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using thinkinapp2.SORULAR;
using thinkinapp2.View;
using Xamarin.Forms;

namespace thinkinapp2
{
    public partial class App : Application
    {

        public App()
        {
            MainPage = new MyMasterDetail();
        }
       
    }
}

