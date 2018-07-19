using System;
using System.Text;
using PSPUtil.Exensions;
using PSPUtil.StaticUtil;
using UnityEditor;
using UnityEngine;

namespace PSPEditor.EditorUtil
{
    public static class MyCreate
    {

        #region Text

        public static void Text(string text)
        {
            GUILayout.Label(text);
        }


        public static void Tests(params string[] texts)
        {
            StringBuilder sb =new StringBuilder();
            foreach (string text in texts)
            {
                sb.Append(text);
            }
            GUILayout.Label(sb.ToString());
        }

        public static void Text(string text, int width)
        {
            Heng(width, () =>
            {
                GUILayout.Label(text);
            });
        }
        public static void TextCenter(string text)
        {
            GUILayout.Label(text, "TextCenter");
        }

        public static void SelectText(string text)
        {
            EditorGUILayout.SelectableLabel(text);
        }
        public static void SelectText(string text, int width)
        {
            Heng(width, () =>
            {
                EditorGUILayout.SelectableLabel(text);
            });

        }
        #endregion

        #region Button

        private static double clickTime = 0f;

        public static void DoubleButton(string text,Action onClick)
        {
            if (GUILayout.Button(text))
            {
                if (EditorApplication.timeSinceStartup - clickTime < 0.3f && null != onClick)
                {
                    onClick();
                }
                clickTime = EditorApplication.timeSinceStartup;
       
            }
        }


        public static void Button(string text, Action onClick)
        {
            if (GUILayout.Button(text))
            {
                if (null != onClick)
                {
                    onClick();
                }
            }
        }

        public static void Button(string text, int width, Action onClick)
        {
            Heng(width, () =>
            {
                if (GUILayout.Button(text))
                {
                    if (null != onClick)
                    {
                        onClick();
                    }
                }
            });
        }

        public static void TextCenterButton(string text, Action onClick)
        {
            if (GUILayout.Button(text, "TextCenter"))
            {
                if (null != onClick)
                {
                    onClick();
                }
            }
        }

        public static void TextButton(string text, Action onClick)
        {
            if (GUILayout.Button(text, "Label"))
            {
                if (null != onClick)
                {
                    onClick();
                }
            }
        }


        public static void ButtonLabel(string text, int width, Action onClick)
        {
            Heng(width, () =>
            {
                if (GUILayout.Button(text, "Label", GUILayout.ExpandWidth(false), GUILayout.ExpandHeight(false)))
                {
                    if (null != onClick)
                    {
                        onClick();
                    }
                };
            });

        }

        #endregion

        #region 输入
        public static void Image(Texture2D texture)
        {
            GUILayout.Button(texture, GUILayout.Width(texture.width + 5));
        }

        public static float InputFloat(float min, float max, float value)
        {
            return EditorGUILayout.Slider(value, min, max);
        }
        public static int InputInt(int min, int max, int value)
        {
            return EditorGUILayout.IntSlider(value, min, max);
        }
        public static bool InputBool(bool value)
        {
            return EditorGUILayout.Toggle(value);
        }
        public static string InputString(string input)
        {
            return EditorGUILayout.TextField(input);
        }
        public static string InputString(string input, int width)
        {
            string tmp = input;
            Heng(width, () =>
            {
                tmp = EditorGUILayout.TextField(tmp);
            });
            return tmp;
        }


        public static Vector2 InputVector2(Vector2 input)
        {
            return EditorGUILayout.Vector2Field("", input);
        }
        public static Vector3 InputVector3(Vector3 input)
        {
            return EditorGUILayout.Vector3Field("", input);
        }
        public static Enum Enum(Enum e)
        {
            return EditorGUILayout.EnumPopup(e);
        }
        public static int Enum(int index, string[] displayedOptions)
        {
            return EditorGUILayout.Popup(index, displayedOptions);
        }

        public static T InputObject<T>(T obj)                    //输入Object
            where T : UnityEngine.Object
        {
            return (T)EditorGUILayout.ObjectField(obj, typeof(T), true);
        }
        public static Texture InputTexture(Texture texture,      //输入Texture
            int width = 80, int height = 80)
        {
            return (Texture)EditorGUILayout.ObjectField(texture, typeof(Texture2D), false, GUILayout.Width(width), GUILayout.Height(height));
        }
        public static Sprite InputSprite(Sprite sprite,          //输入Sprite
            int width = 100, int heigh = 100)
        {
            return (Sprite)EditorGUILayout.ObjectField(sprite, typeof(Sprite), false, GUILayout.Width(width), GUILayout.Height(heigh));
        }

        public static string Tag(string tagStr)                  //Tag
        {
            return EditorGUILayout.TagField(tagStr);
        }


        public static string TODO = "TODO".AddRedBold();

        #endregion

        #region 分隔线
        public static void FenGeXian()
        {
            GUILayout.Label("————————————————————————————".AddGreen());
        }
        public static void FenGeXian(string text)                //带文字
        {
            GUILayout.Label(text, "BottomLine");
        }

        public static void FenGeXian(string text, Action onClick)  //带文字 + 点击
        {
            if (GUILayout.Button(text, "BottomLine"))
            {
                if (null != onClick)
                {
                    onClick();
                }
            }
        }


        public static void FenGeXian(string text,                //能点击展示下边的Action
            ref bool isShow, MyEnumColor color = MyEnumColor.Green)
        {
            bool tmp = isShow;
            string des = isShow ? "▼ ".AddSize(10) + text : "▶ ".AddSize(10) + text;
            if (GUILayout.Button(des.AddColor(color,false), "BottomLine"))
            {
                tmp = !tmp;
            };
            isShow = tmp;
        }


        public static void FenGeXian_Blue(string text)                //带文字 蓝色
        {
            GUILayout.Label(text, "BlueBottom");
        }

        public static void FenGeXian_Blue(string text, Action onClick)  //带文字 + 点击 蓝色
        {
            if (GUILayout.Button(text, "BlueBottom"))
            {
                if (null != onClick)
                {
                    onClick();
                }
            }
        }


        public static void FenGeXian_Blue(string text,                //能点击展示下边的Action 蓝色
            ref bool isShow)
        {
            bool tmp = isShow;
            string des = isShow ? "▼ ".AddSize(10) + text : "▶ ".AddSize(10) + text;
            if (GUILayout.Button(des, "BlueBottom"))
            {
                tmp = !tmp;
            };
            isShow = tmp;
        }





        #endregion

        #region 布局
        public static Vector2 ScrollView(Vector2 position, Action action)
        {
            Vector2 newPosition = GUILayout.BeginScrollView(position, false, false);
            if (null != action)
            {
                action();
            }
            GUILayout.EndScrollView();
            return newPosition;
        }

        public static void Heng(Action action)
        {
            GUILayout.BeginHorizontal();
            if (null != action)
            {
                action();
            }
            GUILayout.EndHorizontal();
        }

        private static void Heng(int width, Action action)
        {
            if (width <= 0)
            {
                Heng(action);
            }
            else
            {
                GUILayout.BeginHorizontal(GUILayout.Width(width));
                if (null != action)
                {
                    action();
                }
                GUILayout.EndHorizontal();
            }
        }

        public static void Shu(Action action)
        {
            GUILayout.BeginVertical();
            if (null != action)
            {
                action();
            }
            GUILayout.EndVertical();
        }

        public static void Box(Action action)
        {
            GUILayout.BeginVertical("window", GUILayout.ExpandWidth(false), GUILayout.ExpandHeight(false));
            if (null != action)
            {
                action();
            }
            GUILayout.EndVertical();
        }

        public static void Box(Action action, int with)
        {
            Heng(() =>
            {
                GUILayout.BeginVertical("window");
                if (null != action)
                {
                    action();
                }
                GUILayout.EndVertical();
                AddSpace(with);
            });
        }

        public static void Box_Hei(Action action)
        {
            GUILayout.BeginVertical("box");
            if (null != action)
            {
                action();
            }
            GUILayout.EndVertical();
        }

        public static void Window(string biaoTi, Action action)
        {
            GUILayout.BeginVertical(biaoTi, "window");
            if (null != action)
            {
                action();
            }
            GUILayout.EndVertical();
        }


        public static void Window_Heng(string biaoTi, Action action)
        {
            AddSpace(15);
            GUILayout.BeginHorizontal(biaoTi, "window");
            if (null != action)
            {
                action();
            }
            GUILayout.EndHorizontal();
        }

        public static void AddSpace(int juLi)
        {
            if (juLi > 0)
            {
                GUILayout.Space(juLi);
            }
        }

        public static void AddSpace()
        {
            GUILayout.FlexibleSpace();
        }


        public static void StaticPropertiesWindow(Action action)
        {
            AddSpace(15);
            Window("【" + " Static".AddBold() + " Properties 】", action);
        }


        public static void GouZaoWindow(Action action)
        {
            AddSpace(15);
            Window("【 构造函数 】", action);
        }


        public static void PropertiesWindow(Action action)
        {
            AddSpace(15);
            Window("【 Properties 】", action);
        }

        public static void StaticMethodWindow(Action action)
        {
            AddSpace(15);
            Window("【" + " Static".AddBold() + " Methods 】", action);
        }
        public static void MethodWindow(Action action)
        {
            AddSpace(15);
            Window("【 Methods 】", action);
        }
        public static void StaticEventsWindow(Action action)
        {
            AddSpace(15);
            Window("【" + " Static".AddBold() + " Events 】", action);
        }

        public static void EventsWindow(Action action)
        {
            AddSpace(15);
            Window("【 Events 】", action);
        }
        public static void GetSetWindow(Action action)
        {
            AddSpace(15);
            Window("【 Get/Set 属性 】", action);
        }

        #endregion

        #region 系统的功能

        public static void ShowProgressBar(string info,          //展示一个进度条框框
            float value)
        {
            EditorUtility.DisplayProgressBar("进度", info, value);
        }

        public static void ProgressBarFinish()                   //关闭上面的进度条框框
        {
            EditorUtility.ClearProgressBar();
        }

        public static void Log(string log)
        {
            EditorGUILayout.HelpBox(log, MessageType.Info);
        }
        public static void LogWarning(string log)
        {
            EditorGUILayout.HelpBox(log, MessageType.Warning);
        }
        public static void LogError(string log)
        {
            EditorGUILayout.HelpBox(log, MessageType.Error);
        }

        public static void AssetShuaXin()                        //Asset文件刷新
        {
            AssetDatabase.Refresh();
        }
        public static AnimationCurve AnimCurve(                  //动画曲线
            AnimationCurve animCurve)
        {
            return EditorGUILayout.CurveField(animCurve);
        }


        public static bool JianTuo_System(string str, bool isShow)
        {
            return EditorGUILayout.Foldout(isShow, str);
        }

        public static void JianTuo_System(string str, ref bool isShow, Action shoAction)
        {
            isShow = EditorGUILayout.Foldout(isShow, str);
            if (isShow && shoAction != null)
            {
                shoAction();
            }
        }
        #endregion
        public static bool TextUnityObject<T>(string str,        //文本 Object（Null ->noShowAction ）showAction
            ref T sc, bool isShow, Action showAction,
            Action noShowAction, int jianGe)
            where T : UnityEngine.Object
        {
            T tmpT = sc;
            bool tmp = isShow;
            try
            {
                Heng(() =>
                {
                    Text(str, jianGe);
                    tmpT = (T)EditorGUILayout.ObjectField(tmpT, typeof(T), true);
                });
                if (null != tmpT)
                {
                    AddSpace(5);
                    tmp = EditorGUILayout.InspectorTitlebar(tmp, tmpT, true);
                    if (null != showAction && tmp)
                    {
                        showAction();
                    }
                    if (null != noShowAction && !tmp)
                    {
                        noShowAction();
                    }
                }
            }
            catch
            {
                // ignored
            }
            sc = tmpT;
            return tmp;
        }

    }


}


