using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AlexaSettings
{
    public class Alexa
    {
        public AlexaSettings settings;

        public Alexa()
        {
            settings = new AlexaSettings()
            {
                GreetingMessage = $"hello, i am Alexa"
            };
        }

        public string Talk()
        {
            return settings.Greet();
        }

        public void Configure(Action<AlexaSettings> setAlexaSettings)
        {
            setAlexaSettings(settings);
        }

    }
}
