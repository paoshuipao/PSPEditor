/*
using System.Diagnostics;
using System.IO;
using PSPUtil.StaticUtil;
using UnityEngine;

namespace UnityEditor
{
    internal sealed class AutoBuilderWindow
    {
        [MenuItem("File/自动Builder/只有Windows")]
        static void PerformWin64Build()
        {
            string buildStr = "Builds/Win64/";
            EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.StandaloneWindows);
            BuildPipeline.BuildPlayer(GetScenePaths(), buildStr + GetProjectName() + ".exe", BuildTarget.StandaloneWindows64, BuildOptions.None);
            OpenFloder(buildStr);

        }


        #region 私有
        private static string GetProjectName()
        {
            string[] s = Application.dataPath.Split('/');
            return s[s.Length - 2];
        }

        private static string[] GetScenePaths()
        {
            string[] scenes = new string[EditorBuildSettings.scenes.Length];

            for (int i = 0; i < scenes.Length; i++)
            {
                scenes[i] = EditorBuildSettings.scenes[i].path;
            }

            return scenes;
        }

        private static void OpenFloder(string buildStr)
        {
            string path = MyAssetUtil.GetAssetsProPath(Application.dataPath) + buildStr;
            if (Directory.Exists(path))
            {
                Process.Start(path); //双击

            }
        }

        #endregion

    }
}


*/
