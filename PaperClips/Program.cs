/*
 * PaperClips 
 * Pawelski
 * 9/10/2023
 * Developing Desktop Applications
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClips
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass, paperClips;
            paperClips = Math.Ceiling(mass / 1.5);
            Console.WriteLine("A mass of " + mass + " grams is about"
                + paperClips + " paper clips.");
        }
    }
}
