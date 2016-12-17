using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anarchy.Classes;
using Anarchy.Classes.Packets;

namespace Anarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do this for each packet we are interested in
            n3InfoItemRemote.Register(new NewLevel());

            // once we registered packets and have any code that wants to read packet, that code will send packet key and stream
            // Then we look up what n3InfoItemRemote handles that specific key and call ReadSubClass on it to populate data:// 
            // Handlers.GetHandler(key)?.ReadSubClass(stream)
            //
            // It would be same as:
            // NewLevel().ReadSubClass(stream);

            //TODO: Rest of the functionality.. or not.. this is just an example
        }
    }
}
