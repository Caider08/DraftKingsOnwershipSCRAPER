using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftKingsOnwershipSCRAPER
{
    [ComVisible(true)]
    public class MyScript
    {
        public void CallServerSideCode()
        {
            var doc = ((GetPlayerTags)Application.OpenForms[0]).webBroswer1.Document;

        }
        
        
    }
}
