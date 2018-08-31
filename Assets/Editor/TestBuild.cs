using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TestBuild {

    static void PerformBuild ()
    {

        Debug.Log ("PerformBuild 2");
       
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions ();
        buildPlayerOptions.scenes = new [] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "LinuxBuild";
        buildPlayerOptions.target = BuildTarget.StandaloneLinux64;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer (buildPlayerOptions);

    }
}
