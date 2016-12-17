using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Anarchy.Classes
{
    internal class n3InfoItemRemote
    {
        private bool toBePassedOn;
        private int pktKey;
        private int sendPolicy;
        public string className;

        public n3InfoItemRemote(string classname)
        {
            SetKey(MapToKey(classname));
            className = classname;
        }

        public virtual int PollStatus() => 0;

        public virtual void Activate() { }

        public virtual bool ToBePassedOn() => toBePassedOn;

        public virtual bool AllowedBetweenServers() => false;

        public virtual bool IsAllowedFromClient() => false;

        public virtual void DebugDumpData() => Console.WriteLine("ERROR: base DebugDumpData() should be overridden");

        public virtual void ReadSubClass(BinaryReader stream) { }

        public virtual void WriteSubClass(BinaryWriter stream) { }

        public void ClearToBePassedOn() => toBePassedOn = false;

        public void EnablePassOn() => toBePassedOn = true;

        public int GetKey() => pktKey;

        public void SetKey(int key) => pktKey = key;

        public int GetSendPolicy() => sendPolicy;

        public void SetSendPolicy(int policy) => sendPolicy = policy;

        public static int MapToKey(string className)
        {
            // TODO: Implement this
            // Hash the className
            // Return hash
            return 0;
        }

        public static string KeyToString(int key)
        {
            // TODO: Implement this
            // search list of hash lookups and return result or "unknown"
            return "unknown";
        }

        public static void Register(n3InfoItemRemote c)
        {
            // TODO: Implement this
            var tmpKey = MapToKey(c.className);
            // add hash and packet class to list
            Console.WriteLine("Registered IIR: {0:X8} : {1}", tmpKey, c.className);
        }
    }
}
