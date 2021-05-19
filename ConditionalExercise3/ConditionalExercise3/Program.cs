using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise3
{
    class Program
    {
        // Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        static void Main(string[] args)
        {
            Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);

        }
        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
    }
}
