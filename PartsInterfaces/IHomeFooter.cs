using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInterfaces
{
    public interface IHomeFooter
    {

        void Navigate(string text);
        string getUrl();

        void CloseBrowser();
        void Login(string v, string v1);
        void Login();
    }
}
