using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Flyweight
{
    class ImageFactory
    {
        private Dictionary<string, BaseImage> flyweights = new Dictionary<string, BaseImage>();

        public BaseImage GetFlyweight(string filename)
        {
            BaseImage flyweight = null;
            Console.WriteLine();

            //check for cached shared flywhell
            if(flyweights.ContainsKey(filename))
            {
                flyweight = flyweights[filename] as BaseImage;
                Console.WriteLine("Returning cachec image {0}", filename);
            }
            else
            {
                //create new flyweight and add to cache
                flyweight = new Image(filename);
                flyweights.Add(filename, flyweight);
                Console.WriteLine("Instantioning new Image {0}", filename);
            }
            return flyweight;
        }
    }
}
