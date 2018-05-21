using System.Collections.Generic;
using System.IO;
using PSPUtil.StaticUtil;
using UnityEditor;
using UnityEngine;

namespace PSPEditor.EditorUtil
{
    public static class LoadRes
    {

        private const string EditorUtil = "_EditorUtil";         // 存放图片、GUISkin的文件夹名

        private static GUISkin m_ResourcesSkin;

        public static GUISkin ResourcesSkin
        {
            get
            {
                if (null == m_ResourcesSkin)
                {
                    m_ResourcesSkin = FindTextureOrGUISkin<GUISkin>("MyGUISkin.guiskin");
                }
                return m_ResourcesSkin;
            }

        }


        public static Texture2D DownImage(string url)                       //下载图片
        {
            if (string.IsNullOrEmpty(url))
            {
                MyLog.Red("图片Url为空");
                return null;
            }
            if (urlK_Texture.ContainsKey(url))
            {
                return urlK_Texture[url];
            }
            else
            {
                Texture2D texture = null;
                WWW www = new WWW(url);
                while (!www.isDone)
                {
                    MyCreate.ShowProgressBar("下载图片", www.progress);
                }
                MyCreate.ProgressBarFinish();
                if (www.error != null)
                {
                    MyLog.Red("图片加载失败！！ —— " + www.error);
                    MyLog.Red("URL —— " + url);
                    urlK_Texture.Add(url, null);
                }
                else
                {
                    texture = www.textureNonReadable;
                    urlK_Texture.Add(url, texture);
                }
                www.Dispose();
                return texture;
            }

        }



        #region 私有


        private static readonly Dictionary<string, Texture2D> urlK_Texture = new Dictionary<string, Texture2D>();
        private static string[] m_EidtorUtilPaths;


        #endregion


        /// <summary>
        /// 在 _EditorUtil 文件夹下找图片或者GUISkin
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName">文件名 如：</param>
        /// <returns></returns>
        public static T FindTextureOrGUISkin<T>(string fileName)
            where T: Object
        {
            if (null== m_EidtorUtilPaths)
            {
                m_EidtorUtilPaths = Directory.GetDirectories(Application.dataPath, EditorUtil, SearchOption.AllDirectories);
            }

            if (m_EidtorUtilPaths.Length == 0)                   // 还是为空的情况
            {
                MyLog.Red("没有找到 _EditorUtil 的文件夹");
                return null;
            }
            string fileFullPath = "";
            foreach (string editorUtilPath in m_EidtorUtilPaths)
            {
                string[] fileFullPaths= Directory.GetFiles(editorUtilPath, fileName, SearchOption.AllDirectories);
                if (fileFullPaths.Length == 1)
                {
                    fileFullPath = fileFullPaths[0];
                    break;
                }
                if (fileFullPaths.Length > 1)
                {
                    MyLog.Yellow("有多个相同名字的文件 —— " + fileName);
                }
            }

            if (string.IsNullOrEmpty(fileFullPath))
            {
                MyLog.Red("没有找到这个文件 —— " + fileName);
                return null;
            }
            string assetPath = MyAssetUtil.GetAssetsBackPath(fileFullPath);
            return AssetDatabase.LoadMainAssetAtPath(assetPath) as T;
        }




    }

}

