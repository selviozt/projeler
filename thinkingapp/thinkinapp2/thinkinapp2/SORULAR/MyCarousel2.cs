using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinkinapp2.View;
using Xamarin.Forms;

namespace thinkinapp2.SORULAR
{
    class MyCarousel2: CarouselPage

    {
        public MyCarousel2()
        {
            Children.Add(new MyMath());
            Children.Add(new DrawerPage());
        }
    }
}
