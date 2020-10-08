using UnityEditor;
using System.IO;

class AndroidBuilder
{
    static void ProductionBuild()
    {
        // ... your code here, validations, flag changes, etc.
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"prod");

        PlayerSettings.Android.bundleVersionCode = 1;
        PlayerSettings.Android.keyaliasName = "message";
        PlayerSettings.Android.keyaliasPass = "123456";
        PlayerSettings.Android.keystorePass = "123456";
        PlayerSettings.Android.keystoreName = Path.GetFullPath(@"/Users/marcelokorjenioski/Documents/unity/unityenviroment/Document/keystore.keystore").Replace('\\', '/');

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

        PlayerSettings.Android.bundleVersionCode = 1;
        PlayerSettings.Android.keyaliasName = "message";
        PlayerSettings.Android.keyaliasPass = "123456";
        PlayerSettings.Android.keystorePass = "123456";
        PlayerSettings.Android.keystoreName = Path.GetFullPath(@"/Users/marcelokorjenioski/Documents/unity/unityenviroment/Document/keystore.keystore").Replace('\\', '/');

        // Build the player.\
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "AndroidTestBuild.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
