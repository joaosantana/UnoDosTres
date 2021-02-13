using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoDosTres.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoDosTres.App(), args);
            host.Run();
        }
    }
}
