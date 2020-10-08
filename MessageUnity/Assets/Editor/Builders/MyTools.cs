using UnityEditor;
using System.Diagnostics;
using UnityEngine;
using System.Linq;
using System.IO;
using System.Collections.Generic;

public class ScriptBatch
{
    [MenuItem("MyBuildTools/Android Build Dev With Postprocess")]
    public static void BuildAndroidGameDev()
    {
        // ... your code here, validations, flag changes, etc.
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "prod");

        PlayerSettings.productName = "BuildAndroidGameDev";
        PlayerSettings.companyName = "Phaneronsoft";

        PlayerSettings.Android.bundleVersionCode = 1;
        PlayerSettings.Android.keyaliasName = "message";
        PlayerSettings.Android.keyaliasPass = "123456";
        PlayerSettings.Android.keystorePass = "123456";
        PlayerSettings.Android.keystoreName = Path.GetFullPath(@"/Users/marcelokorjenioski/Documents/unity/unityenviroment/Document/keystore.keystore").Replace('\\', '/');


        // Build the player.
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "AndroidDevBuild.apk";
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
        buildPlayerOptions.locationPathName = "iOSDevBuild.ipa";
        buildPlayerOptions.target = BuildTarget.iOS;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }

    [MenuItem("MyBuildTools/Android Production Build With Postprocess")]
    public static void BuildAndroidGameProd()
    {
        // ... your code here, validations, flag changes, etc.
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "prod");

        PlayerSettings.Android.bundleVersionCode = 1;
        PlayerSettings.Android.keyaliasName = "message";
        PlayerSettings.Android.keyaliasPass = "123456";
        PlayerSettings.Android.keystorePass = "123456";
        PlayerSettings.Android.keystoreName = Path.GetFullPath(@"/Users/marcelokorjenioski/Documents/unity/unityenviroment/Document/keystore.keystore").Replace('\\', '/');


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
        buildPlayerOptions.locationPathName = "iOSProdBuild.ipa";
        buildPlayerOptions.target = BuildTarget.iOS;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
