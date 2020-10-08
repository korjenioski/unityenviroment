using UnityEditor;

class iOSBuilder
{

    static void ProductionBuild()
    {
        // ... your code here, validations, flag changes, etc.
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iOS, "prod");

        PlayerSettings.productName = "iOSProductionBuild";
        PlayerSettings.companyName = "Phaneronsoft";

        // Build the player.
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "iOSProdBuild.ipa";
        buildPlayerOptions.target = BuildTarget.iOS;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }

    static void TestBuild()
    {
        // ... your code here, validations, flag changes, etc.
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iOS, "test");

        PlayerSettings.productName = "iOSTestBuild";
        PlayerSettings.companyName = "Phaneronsoft";

        // Build the player.
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "iOSTestBuild.ipa";
        buildPlayerOptions.target = BuildTarget.iOS;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
