using System;
using UnityEditor;
using UnityEngine;

public class AndroidCaller : MonoBehaviour
{
    private const float FontSizeMult = 0.04f;
    private string mDebugText = "";
    public GUISkin menuSkin;

    private void debugLog(String log)
    {
        mDebugText += "\n" + log;
        Debug.Log(log);
    }

    void OnGUI()
    {
        GUI.skin = menuSkin;
        GUI.skin.button.fontSize = (int)(FontSizeMult * Screen.height);
        GUI.skin.label.fontSize = (int)(FontSizeMult * Screen.height);

        Rect buttonRect = new Rect(20, 60,
            Screen.width - 40, 120);

        float line = buttonRect.y + buttonRect.height + 20;

        GUI.TextArea(new Rect(20, line, Screen.width - 40, Screen.height - line - 20),
            mDebugText);

        string buttonLabel = "Show Enviroment";

        if (GUI.Button(buttonRect, buttonLabel))
        {
            ShowEnviroment();
        }
    }

    //method that calls our native plugin.
    public void ShowEnviroment()
    {


#if UNITY_ANDROID
        //somew fields and functions used for Android only
        debugLog("Build ANDROID");
        string buildTargetGroup = "";//PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        debugLog("buildTargetGroup: " + buildTargetGroup);
#endif

#if UNITY_IOS
        //somew fields and functions used for Android only
        debugLog("Build IOS");
        string buildTargetGroup = "";//PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.iOS);
        debugLog("buildTargetGroup: " + buildTargetGroup);
#endif

    }
}
