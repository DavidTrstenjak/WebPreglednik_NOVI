using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webPreglednik
{
    public partial class Class1 : TitleBarTabs
    {
        public Class1(){

            

        AeroPeekEnabled = true;

        TabRenderer = new ChromeTabRenderer(this);   }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1
                {
                    Text = "New Tab"
                }
            };
        }

    }
}
