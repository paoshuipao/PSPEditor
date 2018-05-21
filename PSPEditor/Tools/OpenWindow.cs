using UnityEditor;

namespace PSPEditor.EditorUtil
{
    public class OpenWindow
    {

        /// <summary>
        /// 打开Windows资源管理器，并选择一个文件
        /// </summary>
        /// <returns>如果点击了确定，就返回true</returns>
        public static bool ChooseFile(string shuoMing, string defaultOpenPoint, out string makeSureFilePath)
        {
            string file = EditorUtility.OpenFilePanel(shuoMing, defaultOpenPoint, "");
            if (!string.IsNullOrEmpty(file))
            {
                makeSureFilePath = file;
                return true;
            }
            else
            {
                makeSureFilePath = "";
                return false;
            }
        }
        #region ChooseFile 重载
        public static bool ChooseFile(string defaultOpenPoint, out string makeSureFilePath)
        {
            return ChooseFile("选择一个文件", defaultOpenPoint, out makeSureFilePath);
        }
        #endregion



        /// <summary>
        /// 打开Windows资源管理器，并选择一个文件夹
        /// </summary>
        /// <returns>如果点击了确定，就返回true</returns>
        public static bool ChooseFloder(string shuoMing, string defaultOpenPoint, out string makeSureFloderPath)
        {
            string file = EditorUtility.OpenFolderPanel(shuoMing, defaultOpenPoint, "");
            if (!string.IsNullOrEmpty(file))
            {
                makeSureFloderPath = file;
                return true;
            }
            else
            {
                makeSureFloderPath = "";
                return false;
            }
        }
        #region ChooseFloder 重载
        public static bool ChooseFloder(string defaultOpenPoint, out string makeSureFloderPath)
        {
            return ChooseFloder("选择一个文件夹", defaultOpenPoint, out makeSureFloderPath);
        }

        #endregion

    }

}

