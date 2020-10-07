using CommsHack;
using HarmonyLib;
using Respawning.NamingRules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMTFEnter
{
    //[HarmonyPatch(typeof(NineTailedFoxNamingRule), nameof(NineTailedFoxNamingRule.PlayEntranceAnnouncement))]
    public class Class2
    {
        public static bool Prefix(NineTailedFoxNamingRule __instance)
        {
            if (!File.Exists(Class1.class1.Config.FileName))
                return true;
            if (Class1.class1.Config.FileName.ToLower().EndsWith(".raw"))
            {
                AudioAPI.API.PlayFileRaw(Class1.class1.Config.FileName, Class1.class1.Config.Volume);
            }
            else
            {
                AudioAPI.API.PlayFile(Class1.class1.Config.FileName, Class1.class1.Config.Volume);
            }
            return false;
        }
    }
}
