using System;
using System.Collections.Generic;
using PSPEditor.EditorUtil;
using PSPUtil.Exensions;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UnityEditor
{

    public abstract class AbstractComponent<T, R> : AbstractKuang<T>
        where T : EditorWindow
        where R : Object
    {

        #region 继承

        protected override void OnEditorGUI()
        {
            m_Tools.TextUnityObject<R>(m_Script == null ? m_ScriptName.AddRed() : m_ScriptName.AddGreen(), ref m_Script, ref m_IsShow, () =>
            {
                MyCreate.AddSpace(6);
                OnDrawScriptGUI(m_Script);
            }, OnScriptCloseGUI);
            if (null == m_Script)
            {
                if (l_Rs.Count > 0)
                {
                    for (int i = 0; i < l_Rs.Count; i++)
                    {
                        R r = l_Rs[i];
                        MyCreate.Button("GameObject 名：".AddGreen() + r.name, () =>
                        {
                            m_Script = r;
                        });
                    }
                    MyCreate.AddSpace(20);
                }
                OnNoScriptGUI();
            }
        }

        protected override void OnInit()
        {
            base.OnInit();
            m_ScriptName = typeof(R).Name;
            InitList();
        }


        protected override void OnHierarchyChange()              //Hierarchy面板有任何操作都调用
        {
            base.OnHierarchyChange();
            InitList();
        }



        #endregion


        protected void AddCreateButton<T1>(ref string value)     //加个创建按钮
            where T1 : Component
        {
            string tmp = value;
            if (l_Rs.Count == 0)
            {
                m_Tools.StringButton(ref tmp, "创建一个在场景上", () =>
                {
                    if (!string.IsNullOrEmpty(tmp))
                    {
                        GameObject go = new GameObject(tmp);
                        go.AddComponent<T1>();
                    }
                });
                MyCreate.AddSpace(20);
            }
            value = tmp;
        }



        #region 私有

        private string m_ScriptName;
        private R m_Script;
        private bool m_IsShow = true;
        private readonly List<R> l_Rs = new List<R>();
        private const int AddJianGe = 10;

        private void InitList()
        {
            l_Rs.Clear();
            R[] rs = FindObjectsOfType<R>();
            foreach (R r in rs)
            {
                if (!string.IsNullOrEmpty(r.name))
                {
                    l_Rs.Add(r);
                }
            }
        }


        protected abstract void OnDrawScriptGUI(R bean);



        private string GetArrayStr(string[] arr, int index)
        {
            if (arr.Length == 0)
            {
                return "没数据";
            }
            if (index < 0 || index >= arr.Length)
            {
                return index + ",数组：" + arr.Length;
            }
            else
            {
                return arr[index];
            }
        }


        #endregion`

        //给继承的----------------------------------------------------------------------------------
        protected override int OnChangeJianGe()
        {
            return 190;
        }

        protected virtual void OnScriptCloseGUI() { }                //脚本缩起来时的OnGUI

        protected virtual void OnNoScriptGUI() { }                   //没有脚本时候的OnGUI



        //方法----------------------------------------------------------------------------------
        protected void SelectMethod(                                   //可选择方法 + 说明 + 返回值
            string str1, string str2, string str3)
        {
            MyCreate.Heng(() =>
            {
                m_Tools.SelectTextText_B(str1, str2);
                MyCreate.AddSpace();
                MyCreate.Text(str3.AddOrange());
            });
        }


        protected void Method(string str1,                             //方法（caiShu）  + 说明 + 返回值 +Action
            string caiShu, string str2, string str3,
            ref bool isShow, Action action)
        {
            bool tmp = isShow;
            MyCreate.Heng(() =>
            {
                m_Tools.TextText_LW(str1.AddYellow() + " " + caiShu, str2, ref tmp, null);
                MyCreate.AddSpace();
                if (!string.IsNullOrEmpty(str3))
                {
                    MyCreate.Text(str3.AddYellow());
                }
            });
            if (tmp && action != null)
            {
                MyCreate.Box(action);
            }
            MyCreate.AddSpace(4);
            isShow = tmp;
        }


        protected void Method(string str1, string caiShu,              //方法（caiShu）  + 说明 + 返回值
            string str2, string str3)
        {
            MyCreate.Heng(() =>
            {
                if (string.IsNullOrEmpty(caiShu))
                {
                    m_Tools.TextText_LW(str1.AddYellow(), str2);
                }
                else
                {
                    m_Tools.TextText_LW(str1.AddYellow() + " " + caiShu, str2);
                }
                MyCreate.AddSpace();
                if (!string.IsNullOrEmpty(str3))
                {
                    MyCreate.Text(str3.AddYellow());
                }

            });
            MyCreate.AddSpace(4);
        }



        protected void MethodDes(string str1, string str2)             //str1 换行->str2
        {
            MyCreate.Text(str1.AddYellow());
            if (!string.IsNullOrEmpty(str2))
            {
                MyCreate.Heng(() =>
                {
                    MyCreate.AddSpace(20);
                    MyCreate.Text(str2);
                });


            }

        }



        //重新写过方法----------------------------------------------------------------------------------
        protected Enum TextEnum(string str1, string str2, Enum value, int changeJianGe = AddJianGe)
        {
            Enum tmp = m_Tools.TextEnum_B(str1 + (" (" + str2 + ")").AddLightBlue(), value, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }

        protected int TextEnum(string str2, int value, string[] ops, ref bool isShow, Action ShowAction, int changeJianGe = AddJianGe)
        {
            int tmp = m_Tools.TextEnum_B(GetArrayStr(ops, value) + (" (" + str2 + ")").AddLightBlue(), value, ops, ref isShow, () =>
            {
                if (null != ShowAction)
                {
                    MyCreate.Box(ShowAction);
                }
            }, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }


        protected int TextEnum(string str2, int value, string[] ops, int changeJianGe = AddJianGe)
        {
            int tmp = m_Tools.TextEnum_B(GetArrayStr(ops, value) + (" (" + str2 + ")").AddLightBlue(), value, ops, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }

        protected Enum TextEnum(string str1, string str2, Enum value, ref bool isShow, Action ShowAction, int changeJianGe = AddJianGe)
        {
            Enum tmp = m_Tools.TextEnum_B(str1 + (" (" + str2 + ")").AddLightBlue(), value, ref isShow, () =>
            {
                MyCreate.Box(ShowAction);
            }, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }

        protected int TextEnum2(string str2, int value, string[] ops, ref bool isShow, Action ShowAction, int changeJianGe = AddJianGe)
        {
            int tmp = m_Tools.TextEnum2_B(GetArrayStr(ops, value) + (" (" + str2 + ")").AddLightBlue(), value, ops, ref isShow, () =>
            {
                if (null != ShowAction)
                {
                    MyCreate.Box(ShowAction);
                }
            }, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }

        protected float TextFloat(string str1, string str2, float value, int max, int changeJianGe = AddJianGe, int minValue = 0)
        {
            float tmp = m_Tools.TextFloat_B(str1 + (" (" + str2 + ")").AddLightBlue(), value, minValue, max, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }

        protected float TextFloat(string str1, string str2, float value, float max, ref bool isShow, Action ShowAction, int changeJianGe = AddJianGe, int minValue = 0)
        {
            float tmp = m_Tools.TextFloat_B(str1 + (" (" + str2 + ")").AddLightBlue(), value, minValue, max, ref isShow, () =>
            {
                if (null != ShowAction)
                {
                    MyCreate.Box(ShowAction);
                }

            }, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }

        protected int TextInt(string str1, string str2, int value, int max, int changeJianGe = AddJianGe, int minValue = 0)
        {
            int tmp = m_Tools.TextInt_B(str1 + (" (" + str2 + ")").AddLightBlue(), value, minValue, max, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }

        protected void TextText1(string str1, string str2, string str3, int changeJianGe = AddJianGe)
        {
            m_Tools.TextText_BW(str1 + (" (" + str2 + ")").AddLightBlue(), str3, changeJianGe);
            MyCreate.AddSpace(4);
        }

        protected void TextText1(string str1, string str2, string str3, ref bool isShow, Action ShowAction, int changeJianGe = AddJianGe)
        {
            m_Tools.TextText_BW(str1 + (" (" + str2 + ")").AddLightBlue(), str3, ref isShow, () =>
            {
                MyCreate.Box(ShowAction);
            }, changeJianGe);
            MyCreate.AddSpace(4);
        }


        protected Vector3 TextVector3(string str1, string str2, Vector3 value, int changeJianGe = AddJianGe)
        {
            Vector3 tmp = m_Tools.TextVector3_B(str1 + (" (" + str2 + ")").AddLightBlue(), value, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }

        protected bool TextBool(string str1, string str2, bool value, int changeJianGe = AddJianGe)
        {
            bool tmp = m_Tools.TextBool_B(str1 + (" (" + str2 + ")").AddLightBlue(), value, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }

        protected bool TextBool(string str1, string str2, bool value, ref bool isShow, Action ShowAction, int changeJianGe = AddJianGe)
        {
            bool tmp = m_Tools.TextBool_B(str1 + (" (" + str2 + ")").AddLightBlue(), value, ref isShow, () =>
            {
                MyCreate.Box(ShowAction);
            }, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }


        protected bool TextBool(string trueStr1, string falseStr1, string str2, bool value, int changeJianGe = AddJianGe)
        {
            bool tmp = m_Tools.TextBool_B((value ? trueStr1 : falseStr1) + (" (" + str2 + ")").AddLightBlue(), value, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }

        protected bool TextBool(string trueStr1, string falseStr1, string str2, bool value, ref bool isShow, Action ShowAction, int changeJianGe = AddJianGe)
        {
            bool tmp = m_Tools.TextBool_B(trueStr1 + (" (" + str2 + ")").AddLightBlue(), falseStr1 + (" (" + str2 + ")").AddLightBlue(), value, ref isShow, () =>
            {
                MyCreate.Box(ShowAction);
            }, changeJianGe);
            MyCreate.AddSpace(4);
            return tmp;
        }





    }


}

