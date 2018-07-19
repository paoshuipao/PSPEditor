using System;
using PSPUtil.Exensions;
using PSPUtil.StaticUtil;
using UnityEngine;

namespace PSPEditor.EditorUtil
{
    public static class MyZuHe
    {
        public static void Text(string str1, ref bool isShow, Action showAction, MyEnumColor color)
        {
            JianTuoText(str1, 0, ref isShow, color, showAction, null);
        }

        public static void TextText(string str1, string str2, int jianGe,bool isKongGe=true)
        {
            MyCreate.Heng(() =>
            {
                if (isKongGe)
                {
                    MyCreate.Text("   " + str1, jianGe);
                }
                else
                {
                    MyCreate.Text(str1, jianGe);
                }
                MyCreate.Text(str2);
            });
        }
        #region TextText 重载
        public static void TextText(string str1, string str2, int jianGe, ref bool isShow, Action showAction, MyEnumColor color)
        {
            JianTuoText(str1, jianGe, ref isShow, color, showAction, () =>
            {
                MyCreate.Text(str2);
            });
        }


        public static void TextText2(string str1, string str2, int jianGe, ref bool isShow, Action showAction,MyEnumColor color =MyEnumColor.LightBlue)
        {
            JianTuoText2(str1, jianGe, ref isShow, showAction, () =>
            {
                MyCreate.Text(str2);
            },false, color);
        }

        #endregion


        public static void Text3(string str1, string str2, string str3, int jianGe,bool isKongGe=true)
        {
            MyCreate.Heng(() =>
            {
                if (isKongGe)
                {
                    MyCreate.Text("   " + str1, jianGe);
                }
                else
                {
                    MyCreate.Text(str1, jianGe);
                }
                MyCreate.Text(str2);
                MyCreate.AddSpace();
                MyCreate.Text(str3);
            });

        }
        #region Text3 重载
        public static void Text3(string str1, string str2, string str3, int jianGe, ref bool isShow, Action showAction, MyEnumColor color)
        {
            bool tmp = isShow;
            MyCreate.Heng(() =>
            {
                string des = (tmp ? "▼ ".AddSize(10) + str1 : "▶ ".AddSize(10) + str1).AddColor(color,false);
                MyCreate.ButtonLabel(des, jianGe, () =>
                {
                    tmp = !tmp;
                });
                MyCreate.Text(str2);
                MyCreate.AddSpace();
                MyCreate.Text(str3);
            });
            if (tmp && null != showAction)
            {
                showAction();
            }
            isShow = tmp;
        }
        #endregion

        public static void TextSelectText(string str1, string str2, int jianGe)
        {
            MyCreate.Heng(() =>
            {
                MyCreate.Text("   " + str1, jianGe);
                MyCreate.SelectText(str2);
            });
        }
        #region TextSelectText 重载
        public static void TextSelectText(string str1, string str2, int jianGe, ref bool isShow, Action showAction, MyEnumColor color)
        {
            JianTuoText(str1, jianGe, ref isShow, color, showAction, () =>
            {
                MyCreate.SelectText(str2);
            });
        }
        #endregion


        public static void SelectTextText(string str1, string str2, int jianGe)
        {
            MyCreate.Heng(() =>
            {
                MyCreate.SelectText(str1, jianGe);
                MyCreate.Text(str2);
            });
        }
        #region TextSelectText 重载
        public static void SelectTextText2(string str1, string str2, int jianGe, ref bool isShow, Action showAction, MyEnumColor color)
        {
            bool tmp = isShow;
            string des = isShow ? "▼ ".AddColorAndSize(color,10,false) + str2 : "▶ ".AddColorAndSize(color, 10,false) + str2;
            MyCreate.Heng(() =>
            {
                MyCreate.SelectText(str1, jianGe - 13);
                MyCreate.Heng(() =>
                {
                    MyCreate.ButtonLabel(des, 0, () =>
                    {
                        tmp = !tmp;
                    });
                });

            });
            if (tmp && null != showAction)
            {
                showAction();
            }
            isShow = tmp;
        }


        #endregion



        /*-------------------------------Text---------------------------------------------------*/

        public static Vector3 TextVector3(string str1, Vector3 position, int jianGe)
        {
            Vector3 tmp = position;
            MyCreate.Heng(() =>
            {
                MyCreate.Text("   " + str1, jianGe);
                tmp = MyCreate.InputVector3(tmp);
            });
            return tmp;
        }
        #region TextVector3 重载
        public static Vector3 TextVector3(string str1, Vector3 value, int jianGe, ref bool isShow, Action showAction, MyEnumColor color)
        {
            Vector3 tmp = value;
            JianTuoText(str1, jianGe, ref isShow, color, showAction, () =>
            {
                tmp = MyCreate.InputVector3(tmp);
            });
            return tmp;
        }

        public static Vector3 TextVector32(string str1, Vector3 value, int jianGe, ref bool isShow, Action showAction)
        {
            Vector3 tmp = value;
            JianTuoText2("   " + str1, jianGe, ref isShow, showAction, () =>
            {
                tmp = MyCreate.InputVector3(tmp);
            });
            return tmp;
        }

        #endregion



        public static string TextString(string str1, string inputStr, int jianGe, bool isNeedRed = false)
        {
            string des = str1;
            string tmp = inputStr;
            if (isNeedRed && string.IsNullOrEmpty(tmp))
            {
                des = des.AddRed();
            }
            MyCreate.Heng(() =>
            {
                MyCreate.Text("   " + des, jianGe);
                MyCreate.Shu(() =>
                {
                    MyCreate.AddSpace(5);
                    tmp = MyCreate.InputString(tmp);
                });
            });
            return tmp;
        }
        #region TextString 重载
        public static string TextString(string str1, string inputStr, int jianGe, Action action, bool isNeedRed = false)
        {
            string des = str1;
            string tmp = inputStr;
            if (isNeedRed && string.IsNullOrEmpty(tmp))
            {
                des = des.AddRed();
            }
            MyCreate.Heng(() =>
            {
                MyCreate.ButtonLabel("   " + des, jianGe, action);
                tmp = MyCreate.InputString(tmp);
            });
            return tmp;
        }
        public static string TextString(string str1, string value, int jianGe, ref bool isShow, Action showAction, MyEnumColor color, bool isNeedRed = false)
        {
            string des = str1;
            string tmp = value;
            if (isNeedRed && string.IsNullOrEmpty(tmp))
            {
                des = des.AddRed();
            }
            JianTuoText(des, jianGe, ref isShow, color, showAction, () =>
            {
                tmp = MyCreate.InputString(tmp);
            });
            return tmp;
        }

        public static string TextString2(string str1, string value, int jianGe, ref bool isShow, Action showAction, bool isNeedRed = false)
        {
            string des = str1;
            string tmp = value;
            if (isNeedRed && string.IsNullOrEmpty(tmp))
            {
                des = des.AddRed();
            }
            JianTuoText2("   " + des, jianGe, ref isShow, showAction, () =>
            {
                tmp = MyCreate.InputString(tmp);
            });
            return tmp;
        }

        #endregion


        public static void TextEnabledString(string str1, string inputStr, int jianGe)
        {
            MyCreate.Heng(() =>
            {
                MyCreate.Text("   " + str1, jianGe);
                MyCreate.Shu(() =>
                {
                    MyCreate.AddSpace(5);
                    GUI.enabled = false;
                    MyCreate.InputString(inputStr);
                    GUI.enabled = true;

                });
            });
        }


        public static float TextFloat(string str1, float value, float minValue, float maxValue, int jianGe)
        {
            float tmp = value;
            MyCreate.Heng(() =>
            {
                MyCreate.Text("   " + str1, jianGe);
                tmp = MyCreate.InputFloat(minValue, maxValue, value);
            });
            return tmp;
        }
        #region TextFloat 重载
        public static float TextFloat(string str1, float value, float minValue, float maxValue, int jianGe, ref bool isShow, Action showAction, MyEnumColor color)
        {
            float tmp = value;
            JianTuoText(str1, jianGe, ref isShow, color, showAction, () =>
            {
                tmp = MyCreate.InputFloat(minValue, maxValue, tmp);
            });
            return tmp;
        }

        public static float TextFloat2(string str1, float value, float minValue, float maxValue, int jianGe, ref bool isShow, Action showAction)
        {
            float tmp = value;
            JianTuoText2("   " + str1, jianGe, ref isShow, showAction, () =>
            {
                tmp = MyCreate.InputFloat(minValue, maxValue, tmp);
            });
            return tmp;
        }

        #endregion



        public static int TextInt(string str1, int value, int minValue, int maxValue, int jianGe)
        {
            int tmp = value;
            MyCreate.Heng(() =>
            {
                MyCreate.Text("   " + str1, jianGe);
                tmp = MyCreate.InputInt(minValue, maxValue, value);
            });
            return tmp;
        }
        #region TextInt 重载
        public static int TextInt(string str1, int value, int minValue, int maxValue, int jianGe, ref bool isShow, Action showAction, MyEnumColor color)
        {
            int tmp = value;
            JianTuoText(str1, jianGe, ref isShow, color, showAction, () =>
            {
                tmp = MyCreate.InputInt(minValue, maxValue, tmp);
            });
            return tmp;
        }

        public static int TextInt2(string str1, int value, int minValue, int maxValue, int jianGe, ref bool isShow, Action showAction)
        {
            int tmp = value;
            JianTuoText2("   " + str1, jianGe, ref isShow, showAction, () =>
            {
                tmp = MyCreate.InputInt(minValue, maxValue, tmp);
            });
            return tmp;
        }

        #endregion



        public static Enum TextEnum(string str1, Enum myEnum, int jianGe, bool isNeedKongGe)
        {
            Enum tmp = myEnum;
            string des = isNeedKongGe ? "   " + str1 : str1;
            MyCreate.Heng(() =>
            {
                MyCreate.Text(des, jianGe);
                tmp = MyCreate.Enum(tmp);
            });
            return tmp;
        }
        #region TextEnum 重载
        public static Enum TextEnum(string str1, Enum value, int jianGe, ref bool isShow, Action showAction, MyEnumColor color)
        {
            Enum tmp = value;
            JianTuoText(str1, jianGe, ref isShow, color, showAction, () =>
            {
                tmp = MyCreate.Enum(tmp);
            }, false);
            return tmp;
        }

        public static Enum TextEnum2(string str1, Enum value, int jianGe, ref bool isShow, Action showAction, bool isNeedKongGe)
        {
            Enum tmp = value;
            string des = isNeedKongGe ? "   " + str1 : str1;
            JianTuoText2(des, jianGe, ref isShow, showAction, () =>
            {
                tmp = MyCreate.Enum(tmp);
            }, false);
            return tmp;
        }


        public static int TextEnum(string str1, int value, string[] displayedOptions, int jianGe, bool isNeedKongGe)
        {
            int tmp = value;
            string des = isNeedKongGe ? "   " + str1 : str1;
            MyCreate.Heng(() =>
            {
                MyCreate.Text(des, jianGe);
                tmp = MyCreate.Enum(tmp, displayedOptions);
            });
            return tmp;
        }


        public static int TextEnum(string str1, int value, string[] displayedOptions, int jianGe, ref bool isShow, Action showAction, MyEnumColor color)
        {
            int tmp = value;
            JianTuoText(str1, jianGe, ref isShow, color, showAction, () =>
            {
                tmp = MyCreate.Enum(tmp, displayedOptions);
            }, false);
            return tmp;
        }

        public static int TextEnum2(string str1, int value, string[] displayedOptions, int jianGe, ref bool isShow, Action showAction, bool isNeedKongGe)
        {
            int tmp = value;
            string des = isNeedKongGe ? "   " + str1 : str1;
            JianTuoText2(des, jianGe, ref isShow, showAction, () =>
            {
                tmp = MyCreate.Enum(tmp, displayedOptions);
            }, false);
            return tmp;
        }


        #endregion



        public static bool TextBool(string str1, bool value, int jianGe)
        {
            bool tmp = value;
            MyCreate.Heng(() =>
            {
                MyCreate.Text("   " + str1, jianGe);
                tmp = MyCreate.InputBool(tmp);
            });
            return tmp;
        }
        #region TextBool 重载


        public static bool TextBool(string str1, bool value, int jianGe, ref bool isShow, Action showAction, MyEnumColor color)
        {
            bool tmp = value;
            JianTuoText(str1, jianGe, ref isShow, color, showAction, () =>
            {
                tmp = MyCreate.InputBool(tmp);
            });
            return tmp;
        }

        public static bool TextBool2(string str1, bool value, int jianGe, ref bool isShow, Action showAction)
        {
            bool tmp = value;
            JianTuoText2("   " + str1, jianGe, ref isShow, showAction, () =>
            {
                tmp = MyCreate.InputBool(tmp);
            });
            return tmp;
        }


        public static bool TextBool(string trueStirng, string falseString, bool value, int jianGe)
        {
            bool tmp = value;
            MyCreate.Heng(() =>
            {
                MyCreate.Text(tmp ? trueStirng : falseString, jianGe);
                tmp = MyCreate.InputBool(tmp);
            });
            return tmp;
        }


        public static bool TextBool(string trueStirng, string falseString, bool value, int jianGe, ref bool isShow, Action showAction, MyEnumColor color)
        {
            bool tmp = value;
            JianTuoText(tmp ? trueStirng : falseString, jianGe, ref isShow, color, showAction, () =>
            {
                tmp = MyCreate.InputBool(tmp);
            });
            return tmp;
        }

        public static bool TextBool2(string trueStirng, string falseString, bool value, int jianGe, ref bool isShow, Action showAction)
        {
            bool tmp = value;
            JianTuoText2("   " + (tmp ? trueStirng : falseString), jianGe, ref isShow, showAction, () =>
            {
                tmp = MyCreate.InputBool(tmp);
            });
            return tmp;
        }


        #endregion


        public static string StringButton(string value, int jianGe, string buutonName, Action action)
        {
            string tmp = value;
            MyCreate.Heng(() =>
            {
                MyCreate.Shu(() =>
                {
                    MyCreate.AddSpace(4);
                    tmp = MyCreate.InputString(tmp, jianGe);
                });
                if (!string.IsNullOrEmpty(tmp))
                {
                    MyCreate.Button("   " + buutonName + "   ", action);
                }
                MyCreate.AddSpace();
            });
            return tmp;
        }




        /*-------------------------------输入---------------------------------------------------*/


        public static void ButtonText(string buttonName, string text, int jianGe, ref bool isShow, Action action,Action action2=null)
        {
            bool tmp = isShow;
            MyCreate.Box(() =>
            {
                MyCreate.Heng(() =>
                {
                    MyCreate.Button(buttonName, jianGe - 10, () =>
                    {
                        tmp = !tmp;
                    });
                    MyCreate.AddSpace(10);
                    MyCreate.Shu(() =>
                    {
                        MyCreate.AddSpace(6);
                        MyCreate.TextButton(text, () =>
                        {
                            tmp = !tmp;
                        });
                    });

                });
                if (tmp && null != action)
                {
                    action();
                }
                if (null != action2)
                {
                    action2();
                }

            });
            isShow = tmp;
        }


        public static void TextButton(string str1, string buttonText, int jianGe, Action onClick)
        {
            MyCreate.Heng(() =>
            {
                MyCreate.Text("   " + str1, jianGe);
                MyCreate.Button(buttonText, onClick);
            });

        }
        #region TextButton 重载
        public static void TextButton(string str1, string buttonText, int jianGe, Action onClick, ref bool isShow, Action showAction, MyEnumColor color)
        {
            JianTuoText(str1, jianGe, ref isShow, color, showAction, () =>
            {
                MyCreate.Button(buttonText, onClick);
            });
        }

        public static void TextButton2(string str1, string buttonText, int jianGe, Action onClick, ref bool isShow, Action showAction)
        {
            JianTuoText2("   " + str1, jianGe, ref isShow, showAction, () =>
            {
                MyCreate.Button(buttonText, onClick);
            });
        }

        #endregion


        /*-------------------------------Button---------------------------------------------------*/


        #region 私有 箭头
        private static void JianTuoText(string text, int width,
           ref bool isShow, MyEnumColor color, Action showAction, Action action, bool isNeedSpace = true)
        {
            bool tmp = isShow;
            MyCreate.Heng(() =>
            {
                string jianTuo = tmp ? "▼ ".AddSize(10).ToString(): "▶ ".AddSize(10).ToString();
                jianTuo += text;
                string des = jianTuo.AddColor(color,false);
                MyCreate.Heng(() =>
                {
                    MyCreate.ButtonLabel(des, width, () =>
                    {
                        tmp = !tmp;
                    });
                    if (null != action)
                    {
                        action();
                        if (isNeedSpace)
                        {
                            MyCreate.AddSpace();
                        }
                    }

                });

            });
            if (tmp && null != showAction)
            {
                showAction();
            }
            isShow = tmp;
        }

        private static void JianTuoText2(string text, int width,
            ref bool isShow, Action showAction, Action action, bool isNeedSpace = true,MyEnumColor color =MyEnumColor.LightBlue)
        {
            bool tmp = isShow;
            string des = isShow ? "▼".AddColorAndSize(color,10,false) : "▶".AddColorAndSize(color, 10, false);
            MyCreate.Heng(() =>
            {
                MyCreate.ButtonLabel(text, width, () =>
                {
                    tmp = !tmp;
                });
                MyCreate.AddSpace();
                MyCreate.Heng(() =>
                {
                    MyCreate.ButtonLabel(des, 0, () =>
                    {
                        tmp = !tmp;
                    });
                    MyCreate.Shu(() =>
                    {
                        MyCreate.AddSpace(5);
                        if (null != action)
                        {
                            action();
                            if (isNeedSpace)
                            {
                                MyCreate.AddSpace();
                            }
                        }
                    });

                });

            });
            if (tmp && null != showAction)
            {
                showAction();
            }
            isShow = tmp;
        }

        #endregion


    }

}

