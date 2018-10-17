using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AlexaSettings
{
    public class AlexaSettings
    {
        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }

        public string Greet()
        {
            if (string.IsNullOrEmpty(GreetingMessage))
                return "";
            return GreetingMessage.Replace($"{{{nameof(OwnerName)}}}", OwnerName);
        }
    }
}
