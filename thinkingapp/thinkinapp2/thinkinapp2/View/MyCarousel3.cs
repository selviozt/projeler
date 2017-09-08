using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinkinapp2.SORULAR;
using Xamarin.Forms;

namespace thinkinapp2.View
{
    class MyCarousel3 : CarouselPage
    {
        public MyCarousel3()
        {
            Children.Add(new MyPara());
            Children.Add(new DrawerPage());
        }
    }
}
