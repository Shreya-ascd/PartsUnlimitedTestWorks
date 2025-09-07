using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInterfaces
{
    public interface IManageAccount
    {
        void Navigate(string text);
        string getUrl();
        void CloseBrowser();
        void Login(string p);
        void ChangePassword(string v, string v1);
        void Logout();
    }
}
