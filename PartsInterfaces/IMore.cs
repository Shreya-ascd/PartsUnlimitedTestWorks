using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInterfaces
{
    public interface IMore
    {
        string GetTitle();
        int GetPartsCount();

        string GetPartName(int partIndex);
        void OnClickNavigateToPartDescriptionPage(int partIndex);

        void CloseBrowser();

        string GetCurrentUrl();

    }
}
