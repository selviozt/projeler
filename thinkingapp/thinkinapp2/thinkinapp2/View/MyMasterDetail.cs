using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace thinkinapp2.View
{
    public class MyMasterDetail: MasterDetailPage
    {
        public MyMasterDetail()
        {   
            NavigationPage Page = new NavigationPage(new MyDetail());
            Page.BarBackgroundColor = Color.FromHex("#65A8E3");
            Detail = Page;
            Master = new MyMaster();

        }
        


    }
}
