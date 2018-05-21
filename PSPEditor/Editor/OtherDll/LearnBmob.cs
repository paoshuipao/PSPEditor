using PSPEditor.EditorUtil;
using PSPUtil.Exensions;
using PSPUtil.StaticUtil;
using UnityEngine;


namespace UnityEditor
{
    public class LearnBmob : AbstractKuang<LearnBmob>
    {

        protected override void OnEditorGUI()
        {
            m_Tools.GuangFangWenDan(BmobWeb, "网站");
            m_Tools.GuangFangWenDan(BmobJiaoCheng, "文档");
            TheOne();
            TheTwo();
            TheThird();
            TheFour();
            TheFive();
        }

        private void TheOne()                                    //一、准备工作
        {
            m_Tools.Text_B("一、准备工作 ", ref isFrist, () =>
            {
                MyCreate.Box(() =>
                {
                    m_Tools.Text("   1.进入官网创建应用");
                    AddSpace();
                    m_Tools.Text("   2.点击应用 -> 设置 获得应用密钥");
                    AddSpace();
                    MyCreate.Heng(() =>
                    {
                        m_Tools.Text("   3.将Bmob-Unity.dll 放到 libs文件夹");
                        MyCreate.AddSpace(70);
                        MyCreate.SelectText("libs");
                    });
                    m_Tools.Text("   4.把BmobUniy加入到组件上(填写Id和Key)");
                });

            });
            AddSpace();
        }

        private void TheTwo()                                    //二、添加 Ctrl_UseBmobData
        {
            MyCreate.Heng(() =>
            {
                m_Tools.Text_B("二、添加 Ctrl_UseBmobData");
                MyCreate.Button("导入包", () =>
                {
                    Application.OpenURL(BmobPath);
                });

            });
            AddSpace();
        }

        private void TheThird()                                  //三、创建 XXXBean
        {
            m_Tools.Text_B("三、创建 bean 继承 1. 普通" + " BmobTable".AddYellow() + "   2.用户 " + "BmobUser".AddYellow(), ref isThird, () =>
            {
                MyCreate.Box(() =>
                {
                    m_Tools.Text(" 自带的字段", ref isZiDai, () =>
                    {
                        m_BmobType = (BmobType)m_Tools.BiaoTi_O("        [  " + m_BmobType + "  ]", m_BmobType);
                        m_Tools.Text3("objectId", "主键", "string");
                        if (m_BmobType == BmobType.BmobUser)
                        {
                            m_Tools.Text3("username", "用户名", "string");
                            m_Tools.Text3("password", "密码", "string");
                            m_Tools.Text3("phone", "手机号码", "string");
                            m_Tools.Text3("emailVerified", "是否验证了邮箱", "BmobBoolean");
                            m_Tools.Text3("email", "邮箱", "string");
                            m_Tools.Text3("sessionToken", "当前登录的配置信息", "string");
                        }
                        m_Tools.Text3("createdAT", "创建时间", "Data");
                        m_Tools.Text3("updateAt", "更新时间", "Data");
                    });
                    m_Tools.Text(" 添加列的类型", ref isAddType, () =>
                    {
                        m_Tools.TextText_OY("      String  " + "(string)".AddLightBlue(), "");
                        m_Tools.TextText_OY("      Number  " + "(BmobInt)".AddLightBlue(), "int 整数");
                        m_Tools.TextText_OY("      Boolean  " + "(BmobBoolean)".AddLightBlue(), "bool ");
                        m_Tools.TextText_OY("      File  " + "(BmobFile)".AddLightBlue(), "路径  D:\\Game\\1.JPG");
                        m_Tools.TextText_OY("      Date  " + "(BmobDate)".AddLightBlue(), "2018-01-05 13:29:22");
                    });
                    m_Tools.Text(" 继承两个函数  " + "( readFields )  ".AddYellow() + "( write )".AddYellow(), ref isTwoMethod, () =>
                    {
                        m_Tools.Text_G("[ 例子 ]    （ score、name 为数据库列名）");
                        m_Tools.Text_Y("readFields  -> 添加的字段需要补上：");
                        m_Tools.Text_O("       Score = input.getInt(\"score\");");
                        m_Tools.Text_O("       PlayerName = input.getString(\"name\")");
                        MyCreate.FenGeXian();
                        m_Tools.Text_Y("write  -> 添加的字段需要补上：");
                        m_Tools.Text_O("       output.Put(\"score\", Score);");
                        m_Tools.Text_O("       output.Put(\"name\", PlayerName);");
                    });
                    m_Tools.Text(" 关于BmobUser说明", ref isDes, () =>
                    {
                        m_Tools.Text_G("1. username、password 必需 ，email 可选");
                        m_Tools.Text_G("2. email 可用于密码找回");
                        m_Tools.Text_G("3. email 可作为 username");
                        m_Tools.Text_G("4. 如需要在注册时发送一封验证邮件，以确真实性");
                        m_Tools.Text_G("       可在应用设置-->邮件设置，把“邮箱验证”功能打开");


                    });
                });

            });
            AddSpace();
        }

        private void TheFour()                                   //四、Ctrl_UseBmobData的增删改查
        {
            m_Tools.Text_B("四、Ctrl_UseBmobData的增删改查", ref isFour, () =>
            {
                MyCreate.Box(() =>
                {
                    m_DoTestEnum = (DoTestEnum)m_Tools.BiaoTi_O("[  " + m_DoTestEnum + "  ]", m_DoTestEnum);
                    switch (m_DoTestEnum)
                    {
                        case DoTestEnum.增删改:
                            MyCreate.Box(() =>
                            {
                                m_Tools.TextText(" 增加", "Add");
                                m_Tools.TextText(" 删除", "Delete");
                                m_Tools.TextText(" 修改", "UpdateData");
                            });

                            break;
                        case DoTestEnum.用户:
                            MyCreate.Box(() =>
                            {
                                m_Tools.TextText(" 用户注册", "User_Registered");
                                m_Tools.TextText(" 用户登录", "User_Login");
                                m_Tools.TextText(" 更新用户信息", "User_Update");
                                m_Tools.TextText(" 重置用户密码", "User_ResetPassword");
                            });

                            break;
                        case DoTestEnum.查:
                            m_Tools.Text_O("Find_XXX");
                            m_Tools.Text("按约束条件来查询 —" + " Find_ByWhere".AddYellow() + " (BmobQuery的用法)", ref isShowByWhere, null);
                            if (isShowByWhere)
                            {
                                MyCreate.Box(() =>
                                {
                                    m_Tools.BiaoTi_O("比较查询");
                                    DesByWhere(1, " WhereEqualTo(\"Name\", \"Barbie\")", "名字等于Barbie的");
                                    DesByWhere(2, " WhereNotEqualTo(\"Name\", \"Barbie\")", "名字不等于Barbie的");
                                    DesByWhere(3, " WhereGreaterThan(\"score\", 60);", "分数 > 60分");
                                    DesByWhere(4, " WhereLessThan(\"score\", 60);", "分数 < 60分");
                                    DesByWhere_Long(5, " WhereContainedIn(\"Name\", {\"Barbie\", \"Joe\", \"Julia\"})", "查询“Barbie”,“Joe”,“Julia”三个人的成绩");

                                    m_Tools.BiaoTi_O(" 分页查询");
                                    DesByWhere(1, " Limit(20)", "最多返回20条记录");
                                    DesByWhere(2, " Skip(20)", "忽略前20条数据");

                                    m_Tools.BiaoTi_O("结果排序");
                                    DesByWhere(1, " OrderBy(\"score\")", "对分数进行升序排序");
                                    DesByWhere(2, " OrderByDescending(\"score\")", "对分数进行降序排序");
                                    DesByWhere_Long(3, "OrderBy(\"score\").ThenBy(\"score2\")", "两个或者以上的字段进行升序排序");
                                    DesByWhere_Long(3, "OrderByDescending(\"score\").ThenByDescending(\"score2\")", "两个或者以上的字段进行降序排序");

                                    m_Tools.BiaoTi_O("或查询");
                                    m_Tools.Text_W("上面都是and作为连接条件查询的，使用 " + "Or".AddBlue() + "或查询");
                                });

                            }
                            break;
                    }
                });

            });
            AddSpace();

        }

        private void TheFive()                                   //五、数据关联
        {
            m_Tools.Text_B("五、数据关联", ref isData, () =>
            {
                MyCreate.Box(() =>
                {
                    m_Tools.Text_G("传统数据库中的主外键关系一样，如：");
                    m_Tools.Text_Y("       一条微博由一个用户发布，可以有多个用户评论，");
                    m_Tools.Text_Y("       每条评论信息对应一个用户 (详细看官方文档)");
                });

            });
        }


        #region 私有

        private const string BmobPath = @"F:\ZiLiao\使用其它插件的包\使用Bmob.unitypackage";
        private const string BmobWeb = @"www.bmob.cn";
        private const string BmobJiaoCheng = @"http://docs.bmob.cn/unity/developdoc/index.html?menukey=develop_doc&key=develop_unity";




        enum DoTestEnum
        {
            增删改,
            查,
            用户
        }

        enum BmobType
        {
            BmobTable,
            BmobUser
        }

        private bool isTwoMethod, isDes, isZiDai, isThird, isFrist, isFour, isData, isShowByWhere, isAddType;
        private DoTestEnum m_DoTestEnum = DoTestEnum.查;
        private BmobType m_BmobType = BmobType.BmobTable;


        [MenuItem("Tools/其他插件/使用Bmob 云数据库")]
        public static void ShowWindow()
        {
            CreateWindow("学习", 460, 500);
        }


        protected override string Tittle()
        {
            return "Bmob开发";
        }



        private void DesByWhere(int num, string str1, string str2)
        {
            MyCreate.Heng(() =>
            {
                MyCreate.Text((num + ".").AddWhite() + str1.AddBlue(), 250);
                MyCreate.Text(str2.AddWhite());
            });
        }

        private void DesByWhere_Long(int num, string str1, string str2)
        {
            MyCreate.Text((num + ".").AddWhite() + str1.AddBlue());
            MyCreate.Heng(() =>
            {
                MyCreate.AddSpace(100);
                MyCreate.Text(str2.AddWhite());
            });
        }


        #endregion


    }
}

