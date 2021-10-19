using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Builder : MonoBehaviour
{
    private static Dictionary<string, Action<string>> actionsByParameters = new Dictionary<string, Action<string>>
    {
        {"targetPlatform", SetTargetPlatform},
        {"outputDir", SetOutputDir}
    };

    private static string outputDir;
    private static string targetPlatform;

    [MenuItem("Tools/Build")]
    static public void BuildFromEditor()
    {
        SetOutputDir("BUILD/Game.exe");
        SetTargetPlatform("StandaloneWindows");
        Build();
    }
    
    static public void PerformBuild()
    {
        var args = System.Environment.GetCommandLineArgs();
        foreach (var argument in args)
        {
            var nameValueArg = argument.Split(new[]{"="}, StringSplitOptions.RemoveEmptyEntries);

            if (actionsByParameters.ContainsKey(nameValueArg[0]))
            {
                Debug.Log("ARGUMENT: " + argument);
                Debug.Log("PARSING ARGUMENT \"" + nameValueArg[0] + "\" with value \"" + nameValueArg[1] + "\"");
                actionsByParameters[nameValueArg[0]].Invoke(nameValueArg[1]);
            }
        }

        Build();
    }

    static public void Build()
    {
        BuildTarget buildTarget = (BuildTarget)Enum.Parse(typeof(BuildTarget), targetPlatform);
        BuildPipeline.BuildPlayer(new[] {"Assets/Scenes/MenuPrincipal.unity", "Assets/Scenes/Gameplay.unity"}, outputDir, buildTarget, BuildOptions.None);
    }

    static public void SetTargetPlatform(string target)
    {
        targetPlatform = target;
    }
    
    static public void SetOutputDir(string output)
    {
        outputDir = output;
    }
}