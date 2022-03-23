using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace mainPage_v1
{
    internal class Program
    {



        static void Main(string[] args)
        {


            string prompt="Welcome to the Cinema What would you like to do";
            string[] options = { "1", "2"};
            Menu mainMenu = new Menu(prompt, options);
            mainMenu.DisplayOptions();


            WriteLine("press any key to exit");
            ReadKey(true);
         
      
        }
        
    }
}
