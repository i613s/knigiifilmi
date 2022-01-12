using System;
using System.Collections.Generic;
using System.Text;
using knigiifilmi.display;
using knigiifilmi.GoshoRibata;



namespace knigiifilmi.controller
{
    class Controller
    {
        public Display display;
        

        public void Start()

        {
            display = new Display();
            display.PeshoRibata();
            
           
        }

    }
}

