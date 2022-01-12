

using System;
using knigiifilmi.controller;

namespace knigiifilmi
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100000; i++)
            {
                Controller CatalogueController = new Controller();
                CatalogueController.Start();



            }
        }
    }
}
