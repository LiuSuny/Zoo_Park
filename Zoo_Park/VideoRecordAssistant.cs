using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Park
{
    public class VideoRecordAssistant : IWalk, ICamera
    {
        public void Walk()
        {
            Console.WriteLine("Assistant walks through the zoo.");
            Console.WriteLine("   (o)    (o)");
            Console.WriteLine("      \\|/");
            Console.WriteLine("     --|--");
            Console.WriteLine("     / \\");
        }

        public void VideoRecord()
        {
            Console.WriteLine("Assistant recording video surveillance.");
            Console.WriteLine("     _____ ");
            Console.WriteLine("   .`  ,  `.");
            Console.WriteLine("  /  ,' `.  \\");
            Console.WriteLine(" / .`     `.' \\");
            Console.WriteLine(" |  :      :   |");
            Console.WriteLine("  \\  `    ,'  /");
            Console.WriteLine("   `.   ,   ,'");
            Console.WriteLine("     `.___.'");
        }
    }

   
}
