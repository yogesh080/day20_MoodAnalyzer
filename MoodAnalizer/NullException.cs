using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalizer
{
    internal class NullException
    {
        public void shownullException(string message)
        {
            if(message == null)
            {
                throw (new MoodAnalizersException("Entered Invalid Input"));
            }
        }
    }
}
