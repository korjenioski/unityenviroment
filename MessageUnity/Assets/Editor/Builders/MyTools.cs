using UnityEditor;
using System.Diagnostics;
using UnityEngine;

public class ScriptBatch
{
    [MenuItem("MyBuildTools/Android Build Dev With Postprocess")]
    public static void BuildAndroidGameDev()
    {
        // ... your code here, validations, flag changes, etc.
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "prod");

        // Build the player.
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "AndroidProdBuild.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }

    [MenuItem("MyBuildTools/iOS Build Dev With Postprocess")]
    public static void BuildiOSGameDev()
    {
        // ... your code here, validations, flag changes, etc.
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iOS, "dev");

        // Build the player.
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "iOSBuild";
        buildPlayerOptions.target = BuildTarget.iOS;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }

    [MenuItem("MyBuildTools/Android Production Build With Postprocess")]
    public static void BuildAndroidGameProd()
    {
        // ... your code here, validations, flag changes, etc.
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "prod");

        // Build the player.
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "AndroidProdBuild.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }

    [MenuItem("MyBuildTools/iOS Build Production With Postprocess")]
    public static void BuildiOSGameProd()
    {
        // ... your code here, validations, flag changes, etc.
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iOS, "dev");

        // Build the player.
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "iOSBuild";
        buildPlayerOptions.target = BuildTarget.iOS;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
