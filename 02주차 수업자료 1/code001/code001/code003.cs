using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code003
{
    delegate void SampleDelegate(); ///

    class DelegateClass
    {
        public void DelegateHethod()
        {
            Console.WriteLine("In the DelegateClass DelegateMethod...");
        }

    }
   

    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass delegateclass = new DelegateClass();
            SampleDelegate sampledelegate = new SampleDelegate(delegateclass.DelegateHethod);
            sampledelegate();
        }
    }


}
