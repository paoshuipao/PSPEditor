using System;
using System.Collections.Generic;
using System.IO;
using PSPUtil.StaticUtil;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace PSPEditor.EditorUtil
{
    public static class MyClick
    {
        /*-------------------------------点击GameObject---------------------------------------------------*/

        //点击GameObject，获得所有的Transform（包含自己以及子对象）,并循环对其做操作
        public static void GameObjectAndAllSub2Do(Action<Transform> action)
        {
            Transform[] ts = Selection.GetTransforms(SelectionMode.Deep);
            foreach (Transform t in ts)
            {
                if (null != action)
                {
                    action(t);
                }
            }
        }

        //点击GameObject,只对点击的GameObject作操作
        public static void GameObject2Do(Action<Transform> action)
        {
            Transform[] ts = Selection.GetTransforms(SelectionMode.TopLevel);
            if (null != action)
            {
                action(ts[0]);
            }
        }


        public static Transform GameObject2Do()
        {
            Transform[] ts = Selection.GetTransforms(SelectionMode.TopLevel);
            return ts[0];
        }



        /*-------------------------------点击任何东西---------------------------------------------------*/

        //点击一个判断类型是否T
        public static T OneGetType<T>() where T : Object
        {
            Object[] selectObs = Selection.objects;
            if (selectObs.Length != 1)
            {
                MyLog.Orange("不是点击一个");
                return default(T);
            }
            else
            {
                return (selectObs[0] is T) ? (T)selectObs[0] : default(T);
            }
        }



        /*-------------------------------点击Asset---------------------------------------------------*/

        // 点击一个Asset文件夹 获得其路径
        public static string OneAssetFolderGetPath()
        {
            DefaultAsset folder = OneGetType<DefaultAsset>();
            if (null == folder)
            {
                MyLog.Orange("点击Asset文件夹");
                return null;
            }
            string assetPath = Application.dataPath + AssetDatabase.GetAssetPath(folder).Remove(0, 6);
            return Directory.Exists(assetPath) ? assetPath : null;
        }

        // 点击任意Asset 获得其路径
        public static string OneAssetGetPath()
        {
            Object[] selectObs = Selection.objects;
            if (selectObs.Length != 1)
            {
                MyLog.Orange("点击一个Asset");
                return null;
            }
            if ((selectObs[0] is GameObject))
            {
                MyLog.Orange("点击一个Asset");
                return null;
            }
            return Application.dataPath + AssetDatabase.GetAssetPath(selectObs[0]).Remove(0, 6);
        }



        //点击一个脚本，返回它的全路径
        public static string OneScript()
        {
            TextAsset script = OneGetType<TextAsset>();
            if (null == script)
            {
                MyLog.Orange("点击一个脚本");
                return null;
            }
            string assetPath = Application.dataPath + AssetDatabase.GetAssetPath(script).Remove(0, 6);

            return File.Exists(assetPath) ? assetPath : null;
        }


        //点击一个脚本，返回它的全路径(脚本返回为TextAsset)
        public static string OneScript(out TextAsset asset)
        {
            asset = OneGetType<TextAsset>();
            if (null == asset)
            {
                MyLog.Orange("点击一个脚本");
                return null;
            }
            string assetPath = Application.dataPath + AssetDatabase.GetAssetPath(asset).Remove(0, 6);

            return File.Exists(assetPath) ? assetPath : null;
        }


        // 点击许多的Asset文件或者文件夹 要做什么
        public static void ManyAssetGetPath2Do(Action<string> action)
        {
            Object[] selectObs = Selection.objects;

            for (int i = 0; i < selectObs.Length; i++)
            {
                string assetPath = AssetDatabase.GetAssetPath(selectObs[i]);
                if (!string.IsNullOrEmpty(assetPath))
                {
                    if (null != action)
                    {
                        action(Application.dataPath + "/" + assetPath);
                    }
                }
                else
                {
                    MyLog.Orange("点击的不是Asset文件");
                }
            }
        }




        /*-------------------------------点击图片---------------------------------------------------*/

        public static void Texture(ref List<Texture2D> list)
        {

            if (Selection.objects != null && Selection.objects.Length > 0)
            {
                Object[] objects = EditorUtility.CollectDependencies(Selection.objects);
                foreach (Object o in objects)
                {
                    //Get selected object as texture
                    Texture2D tex = o as Texture2D;
                    //Is texture asset?
                    if (tex != null)
                    {
                        //Add to list
                        list.Add(tex);
                    }
                }
            }


        }


    }

}

