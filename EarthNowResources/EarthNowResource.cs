using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPathLibrary;

namespace EarthNowResources 
{
    public class EarthNowResource : IPath 
    {
        String sourceFolder;
        public EarthNowResource()
        {

        }
        public String getPath()
        {
            // Console.Write(" Path of Type EarthNOw Created,   the path is +> {0} \n", sourceFolder );
            return sourceFolder;
        }

    }
}
