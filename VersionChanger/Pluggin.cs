using BepInEx;
using System;
using System.Reflection;

[BepInPlugin("theniklev.VersionChangerClient", "VersionChangerClient", "1.2.4.1")]
public class VersionChanger : BaseUnityPlugin
{
    public const string PluginGUID = "theniklev.VersionChangerClient";

    // nik9 is the original creator of this stuff
    // tho their mod didn't work and yielded "NullReferenceException: Object reference not set to an instance of an object" cause like ahaahahha he quite messed up with Logger
    // so i decided to rewrite this mess
    // also their original code didn't compile for me, cause they were somehow directly changing the value of RoR2Application's "private static buildId" from this class, and VisualStudio just said "no lol, that's illegal"
    public const string PluginAuthor = "TheNikLev&nik9";

    //basically VersionSwapper 2.0
    public const string PluginName = "VersionChangerClient";

    public const string PluginVersion = "1.2.4.1";

    private void OnEnable()
    {
        On.RoR2.RoR2Application.AssignBuildId += OnAssignBuildId;
    }

    private void OnDisable()
    {
        On.RoR2.RoR2Application.AssignBuildId -= OnAssignBuildId;
    }

    private static void OnAssignBuildId(On.RoR2.RoR2Application.orig_AssignBuildId orig)
    {
        Type ror2AppType = typeof(RoR2.RoR2Application);

        FieldInfo field = ror2AppType.GetField("buildId", BindingFlags.NonPublic | BindingFlags.Static);

        if (field != null)
        {
            field.SetValue(null, "1.2.4.1");
        }

        // hey! 
        // sooo if you're here, you might be wondering, how that fucker came up with Reflections
        // my dude, i just asked Chat GPT how to change private static field from another class
        // love him so much...
    }
}