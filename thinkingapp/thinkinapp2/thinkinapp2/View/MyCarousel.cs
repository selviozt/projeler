﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinkinapp2.SORULAR;
using Xamarin.Forms;

namespace thinkinapp2.View
{
    class MyCarousel : CarouselPage
    {
        public MyCarousel()
        {
          
            Children.Add(new MyMantik());
            Children.Add(new DrawerPage());
        }

        
    }
}
