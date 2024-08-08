using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPWA.Client.Pages
{
    public class XSMultiSelectFinder1<T>: XSFinder1<T>
    {
        public XSMultiSelectFinder1()  :base()
        { base.IsMultiSelectFinder = true; }
    }
}
