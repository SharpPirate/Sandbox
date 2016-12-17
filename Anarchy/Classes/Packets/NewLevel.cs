using System;
using System.IO;

namespace Anarchy.Classes.Packets
{
    class NewLevel : n3InfoItemRemote
    {
        public NewLevel() : base("NewLevelIIR_t")
        {
        }

        public override void Activate()
        {
            // TODO: Here we handle the packet after ReadSubClass is done reading the data from stream
        }

        public override bool AllowedBetweenServers() => false;

        public override bool IsAllowedFromClient() => false;

        public override void ReadSubClass(BinaryReader stream)
        {
            // Read the packet from stream and populate packet data
            // Then call Activate()
            Activate();
        }

    }
}
