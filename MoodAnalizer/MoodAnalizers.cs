using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalizer
{
    public class MoodAnalizers
    {
        private string message;

        public MoodAnalizers(string message)
        {
            this.message = message;
           
        }
        public string AnalizeMood()
        {
            if (this.message.Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }

        }
        
    }
}
