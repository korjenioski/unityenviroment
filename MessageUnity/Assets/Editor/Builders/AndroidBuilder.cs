using UnityEditor;

class AndroidBuilder
{
    static void ProductionBuild()
    {
        // ... your code here, validations, flag changes, etc.
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"prod");

        // Build the player.\
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "AndroidProdBuild.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }

    static void TestBuild()
    {
        // ... your code here, validations, flag changes, etc.
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "test");

        // Build the player.\
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "AndroidTestBuild.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
