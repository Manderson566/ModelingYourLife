using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingYourLife
{
    class Objects
    {
        public string rndObject;
        public string objectName;

        public Objects(string _objectName )
        {
            objectName = _objectName;
            string[] pulledWordArray = File.ReadAllLines(@"..\..\RandomObjects.txt");
            List<string> pulledWordList = pulledWordArray.ToList<string>();
            var rng = new Random();
            int randomThing = rng.Next(pulledWordList.Count);
            string randomObject = pulledWordList[randomThing];
            rndObject = randomObject;

        }
        public override string ToString()
        {
            return $"{rndObject}";
        }
    }
}
