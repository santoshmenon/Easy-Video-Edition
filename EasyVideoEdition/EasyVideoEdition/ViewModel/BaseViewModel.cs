using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyVideoEdition.ViewModel
{
    /// <summary>
    /// Base interface needed to be implemented by all of the ViewModel to allow them to bve show in the button list.
    /// </summary>
    interface BaseViewModel
    {
        String name { get; }
    }
}
