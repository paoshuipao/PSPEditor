using System;
using System.Collections.Generic;
using PSPEditor.EditorUtil;
using PSPUtil.Exensions;
using PSPUtil.StaticUtil;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UnityEditor
{
    public abstract class AbstractKuang<T> : EditorWindow where T : EditorWindow
    {

        #region 系统函数
        void OnEnable()
        {
            m_Tools = new ZuHeTool(OnChangeJianGe());
            OnInit();
        }

        void OnGUI()
        {
            GUISkin skin = LoadRes.ResourcesSkin;
            if (null == skin)
            {
                MyLog.Red("未能加载 GUISkin");
                return;
            }
            GUI.skin = skin;
            string tittle = Tittle();
            bool isNeedWindow = OnIsWindow();
            if (isNeedWindow)
            {
                MyCreate.Window("", () =>
                {
                    MiddleGUI(tittle);
                });
            }
            else
            {
                MiddleGUI(tittle);
            }

            OnEditorGUILast();
        }
        void Update()
        {
            OnUpdate();
        }

        void OnSelectionChange()
        {
            OnSelectObjs(Selection.objects);
        }

        private void MiddleGUI(string tittle)
        {
            m_ScrollPosition = MyCreate.ScrollView(m_ScrollPosition, () =>
            {
                if (!string.IsNullOrEmpty(tittle))
                {
                    MyCreate.TextCenter(tittle);
                }
                OnEditorGUI();
            });
        }

        #endregion


        #region 私有

        protected ZuHeTool m_Tools;

        private Vector2 m_ScrollPosition;
        protected abstract void OnEditorGUI();
        protected abstract string Tittle();

        #endregion


        protected static T CreateWindow(string biaoTi)           //一开始调用这 创建窗口
        {
            T t = (T)GetWindow(typeof(T), false, biaoTi);
            t.Show();
            Resources.UnloadUnusedAssets();
            GC.Collect();
            return t;
        }

        protected static T CreateWindow(string biaoTi, int width, int height)
        {
            T window = (T)GetWindow(typeof(T), false, biaoTi);
            window.position = new Rect(window.position.xMin + 100f, window.position.yMin + 100f, width, height);
            window.Show();
            Resources.UnloadUnusedAssets();
            GC.Collect();
            return window;
        }



        //方法----------------------------------------------------------------------------------
        protected void AddSpace()
        {
            MyCreate.AddSpace(8);
        }

        protected void AddSpace_3()
        {
            MyCreate.AddSpace(3);
        }


        protected void AddSearch(ref string input,               //加个搜索框,搜索第一个Text，不关下面GUI逻辑事
            List<SearchText> allText, Action action)
        {
            input = m_Tools.TextString("【 搜索 】".AddGreenBold(), input, () =>
            {
                if (null != action)
                {
                    action();
                }
            }, -50);
            bool tmpIsNone = true;
            if (!string.IsNullOrEmpty(input))
            {
                if (null != action)
                {
                    action();
                }
                for (int i = 0; i < allText.Count; i++)
                {
                    if (allText[i].Text1.ToLower().Contains(input.ToLower()))
                    {
                        tmpIsNone = false;
                        break;
                    }
                }
            }
            else
            {
                tmpIsNone = false;
            }
            if (tmpIsNone)
            {
                m_Tools.Text_G("没有这个  " + input);
            }
            MyCreate.AddSpace(10);
        }

        protected static void ShowImage(string path)
        {
            Texture2D texture = LoadRes.DownImage(path);
            if (null != texture)
            {
                MyCreate.Image(texture);
            }
            else
            {

                MyCreate.Image(Texture2D.whiteTexture);
            }
        }


        protected void ShowImprotOrNot(ref bool isImprot)
        {
            bool tmp = isImprot;
            MyCreate.TextCenterButton(tmp ? "隐藏不需要" : "显示所有", () =>
            {
                tmp = !tmp;
            });
            isImprot = tmp;
        }
        protected void StaticProperties()
        {
            MyCreate.Text("Static ".AddBold() + "Properties");
        }
        protected void Properties()
        {
            MyCreate.Text("Properties");
        }
        protected void Methods()
        {
            MyCreate.Text("Methods");
        }
        protected void StaticMethods()
        {
            MyCreate.Text("Static".AddBold() + " Methods");
        }
        protected void Operators()
        {
            MyCreate.Text("Operators");
        }
        protected void StaticEvent()
        {
            MyCreate.Text("Static".AddBold() + " Event");
        }
        protected void Event()
        {
            MyCreate.Text("Event");
        }



        //给继承----------------------------------------------------------------------------------
        protected virtual void OnInit() { }

        protected virtual void OnEditorGUILast() { }             //在OnEditorGUI的后面 

        protected virtual int OnChangeJianGe()                   //改变间隔
        {
            return 200;
        }

        protected virtual bool OnIsWindow()
        {
            return true;
        }

        //系统给的继承----------------------------------------------------------------------------------
        protected virtual void OnUpdate() { }                     //每秒100次
        protected virtual void OnInspectorUpdate() { }            //每秒4次
        protected virtual void OnDestroy() { }                    //关闭框的时候
        protected virtual void OnSelectObjs(Object[] objs) { }    //选择1个或n个对象（包含GameObject或者Asset）
        protected virtual void OnFocus() { }                      //获取到焦点
        protected virtual void OnLostFocus() { }                  //失去焦点
        protected virtual void OnHierarchyChange() { }            //Hierarchy面板有任何拖拽修改删除等操作都调用
        protected virtual void OnProjectChange() { }              //Project面板有任何拖拽修改删除等操作都调用
    }

}
