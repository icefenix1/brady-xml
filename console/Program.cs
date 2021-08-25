using Microsoft.Extensions.Configuration;
using console.Models;
using console.Helpers;

namespace console
{
    //TODO: Need to add logging.
    class Program
    {
        static void Main(string[] args)
        {

            var config = new ConfigurationBuilder()
                .AddXmlFile($"app.config",true,true)

                /*
                  TODO: Should loop back and figure this out
                        Was getting wierdness when running this. 
                        The app.config should just copy but it 
                        was being renamed when it was copied.
                */
                .AddXmlFile($"console.dll.config",true,true)
                .Build();
             
            var cfg = config.Get<AppConfig>();

            var fp = new FileProcessor(cfg);

            //while(true)
            //{
                fp.ProcessInput();
            //}
        }

    }
}
