// S1-05 setup helpers, run from the command line in batch mode.
//   Unity.exe -batchmode -projectPath Game -executeMethod S105Setup.AddPackages -logFile <log>
//   Unity.exe -batchmode -quit -projectPath Game -executeMethod S105Setup.BuildWindows -logFile <log>
using System.Linq;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public static class S105Setup
{
    static readonly string[] Packages =
    {
        "com.unity.cinemachine",
        "com.unity.inputsystem",
        "com.unity.animation.rigging",
        "com.unity.test-framework",
    };

    static AddAndRemoveRequest _add;
    static ListRequest _list;

    // Run WITHOUT -quit: package requests are asynchronous; this exits when done.
    public static void AddPackages()
    {
        _add = Client.AddAndRemove(Packages, null);
        EditorApplication.update += WaitForAdd;
    }

    static void WaitForAdd()
    {
        if (!_add.IsCompleted) return;
        EditorApplication.update -= WaitForAdd;
        if (_add.Status != StatusCode.Success)
        {
            Debug.LogError("S105 PACKAGES FAILED: " + _add.Error?.message);
            EditorApplication.Exit(1);
            return;
        }
        _list = Client.List(true);
        EditorApplication.update += WaitForList;
    }

    static void WaitForList()
    {
        if (!_list.IsCompleted) return;
        EditorApplication.update -= WaitForList;
        foreach (var p in _list.Result.OrderBy(p => p.name))
            Debug.Log($"S105 PACKAGE {p.name} {p.version}");
        EditorApplication.Exit(0);
    }

    public static void BuildWindows()
    {
        var scenes = EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
        Debug.Log("S105 SCENES: " + string.Join(", ", scenes));
        var report = BuildPipeline.BuildPlayer(new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = "Build/Windows/Game.exe",
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.None,
        });
        var s = report.summary;
        Debug.Log($"S105 BUILD {s.result} errors={s.totalErrors} warnings={s.totalWarnings} " +
                  $"size={s.totalSize} time={s.totalTime} unity={Application.unityVersion}");
        EditorApplication.Exit(s.result == BuildResult.Succeeded ? 0 : 1);
    }
}
