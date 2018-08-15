using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    /// <summary>
    /// main client class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Runner m_runner = new Runner();
            m_runner.Main();    
        }
    }

    //we go back all the way back...
    class Runner
    {
        string m_name;
        int m_birthYear;
        public void Main()
        {
            Console.WriteLine("???: How do you do? Press Enter to proceed");
            Console.ReadLine();
            Console.WriteLine("Zodia: My name is Zodia! What's yours?");
            Console.WriteLine("please enter your name: ");
            m_name = Console.ReadLine();
            Console.WriteLine("Zodia: Hel lo " + m_name);
            Console.ReadLine(); 
        }
    }
}
