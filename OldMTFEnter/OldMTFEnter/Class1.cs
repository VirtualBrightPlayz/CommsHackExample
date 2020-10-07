using CommsHack;
using Exiled.API.Features;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMTFEnter
{
    public class Class1 : Plugin<Config>
    {
        public static Class1 class1;
        public static Harmony inst;

        public override string Name => "Class1";

        public override void OnEnabled()
        {
            base.OnEnabled();
            inst = new Harmony("class1");
            inst.PatchAll();
            class1 = this;
            Exiled.Events.Handlers.Server.RoundStarted += Server_RoundStarted;
        }

        public override void OnDisabled()
        {
            inst.UnpatchAll();
            inst = null;
            class1 = null;
            base.OnDisabled();
            Exiled.Events.Handlers.Server.RoundStarted -= Server_RoundStarted;
        }

        private void Server_RoundStarted()
        {
            if (Config.FileName.ToLower().EndsWith(".raw"))
            {
                AudioAPI.API.PlayFileRaw(Config.FileName, Config.Volume);
            }
            else
            {
                AudioAPI.API.PlayFile(Config.FileName, Config.Volume);
            }
        }
    }
}
