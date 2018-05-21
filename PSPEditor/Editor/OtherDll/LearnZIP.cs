using PSPEditor.EditorUtil;

namespace UnityEditor
{
    public class LearnZIP : AbstractKuang<LearnZIP>
    {
        protected override void OnEditorGUI()
        {
            m_Tools.TextButton_Open("打开文件夹导入dll和工具类", "F:/ZiLiao/使用其它插件的包/使用压缩包");

            MyCreate.AddSpace(15);
            MyCreate.Window("MyZipUtil 的 Static 方法", () =>
            {
                MyCreate.Box_Hei(() =>
                {
                    m_Tools.Method_BY("Zip", "string[],string,string=null", "压缩文件和文件夹");
                    m_Tools.TextText_HG("string[]", "文件夹路径或者文件名的集合", -50);
                    m_Tools.TextText_HG("string", "输出压缩包的全路径", -50);
                    m_Tools.TextText_HG("string", "压缩密码，默认不添加", -50);
                });
                AddSpace();
                MyCreate.Box_Hei(() =>
                {
                    m_Tools.Method_BY("UnzipFile", "string/byte[]/Stream,string,string=null", "解压Zip包");
                    m_Tools.TextText_HG("string/byte[]/Stream", "Zip文件路径/字节数组输入流", -50);
                    m_Tools.TextText_HG("string", "解压压缩包的出来路径", -50);
                    m_Tools.TextText_HG("string", "压缩密码，默认没有", -50);
                });
            });

        }


        #region 私有

        [MenuItem("Tools/其他插件/使用Zip压缩包")]
        public static void ShowWindow()
        {
            CreateWindow("学习", 420, 450);
        }


        protected override string Tittle()
        {
            return "使用Zip 压缩包";
        }



        #endregion

    }

}

