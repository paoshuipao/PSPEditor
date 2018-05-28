using System;
using System.Collections.Generic;
using System.Text;
using PSPUtil.Exensions;
using PSPUtil.StaticUtil;
using UnityEngine;

namespace PSPEditor.EditorUtil
{
    public class ZuHeTool
    {
        public Enum TextEnum(Enum value, int changJianGe = 0)
        {
            return TextEnum("[ " + value + " ]", value, changJianGe); ;
        }
        #region TextEnum 重载
        public Enum TextEnum(string textName, Enum value, int changJianGe = 0)
        {
            return MyZuHe.TextEnum(textName, value, m_JianGe + changJianGe, true);
        }

        public int TextEnum(string textName, int value, string[] displayedOptions, int changJianGe = 0)
        {
            return MyZuHe.TextEnum(textName, value, displayedOptions, m_JianGe + changJianGe, true); ;
        }

        public Enum TextEnum(string textStr, Enum value, ref bool isShow, Action showAction, int changJianGe = 0, MyEnumColor color = MyEnumColor.LightBlue)
        {
            return MyZuHe.TextEnum(textStr, value, m_JianGe + changJianGe, ref isShow, showAction, color);
        }

        public int TextEnum(string textStr, int value, string[] displayedOptions, ref bool isShow, Action showAction, int changJianGe = 0, MyEnumColor color = MyEnumColor.LightBlue)
        {
            return MyZuHe.TextEnum(textStr, value, displayedOptions, m_JianGe + changJianGe, ref isShow, showAction, color);
        }

        public int TextEnum2(string textStr, int value, string[] displayedOptions, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return MyZuHe.TextEnum2(textStr, value, displayedOptions, m_JianGe + changJianGe, ref isShow, showAction, true);
        }

        public Enum TextEnum2(string textStr, Enum value, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return MyZuHe.TextEnum2(textStr, value, m_JianGe + changJianGe, ref isShow, showAction, true);
        }


        /*----------------------------------------------------------------------------------*/

        public Enum TextEnum_B(string textName, Enum value, int changJianGe = 0)
        {
            return TextEnum(textName.AddBlue(), value, changJianGe);
        }

        public Enum TextEnum_B(Enum value, int changJianGe = 0)
        {
            return TextEnum("[ " + value + " ]", value, changJianGe);
        }

        public int TextEnum_B(string textName, int value, string[] displayedOptions, int changJianGe = 0)
        {
            return TextEnum(textName.AddBlue(), value, displayedOptions, changJianGe);
        }

        public Enum TextEnum_B(string textStr, Enum value, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextEnum(textStr.AddBlue(), value, ref isShow, showAction, changJianGe, MyEnumColor.Blue);
        }

        public int TextEnum_B(string textStr, int value, string[] displayedOptions, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextEnum(textStr.AddBlue(), value, displayedOptions, ref isShow, showAction, changJianGe, MyEnumColor.Blue); ;
        }

        public int TextEnum2_B(string textStr, int value, string[] displayedOptions, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextEnum2(textStr.AddBlue(), value, displayedOptions, ref isShow, showAction, changJianGe); ;
        }

        public Enum TextEnum2_B(string textStr, Enum value, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextEnum2(textStr.AddBlue(), value, ref isShow, showAction, changJianGe);
        }

        #endregion


        public Vector3 TextVector3(string textName, Vector3 value, int changJianGe = 0)
        {
            return MyZuHe.TextVector3(textName, value, m_JianGe + changJianGe);
        }
        #region TextVector3 重载
        public Vector3 TextVector3_B(string textName, Vector3 value, int changJianGe = 0)
        {
            return TextVector3(textName.AddBlue(), value, changJianGe);
        }


        #endregion


        public string TextString(string textName, string value, int changJianGe = 0, bool isRed = false)
        {
            return MyZuHe.TextString(textName, value, m_JianGe + changJianGe, isRed);
        }
        #region TextString 重载
        public string TextString(string textName, string value, Action action, int changJianGe = 0, bool isRed = false)
        {
            return MyZuHe.TextString(textName, value, m_JianGe + changJianGe, action, isRed);
        }
        public string TextString(string textName, string value, ref bool isShow, Action showAction, MyEnumColor color = MyEnumColor.LightBlue, int changJianGe = 0, bool isRed = false)
        {
            return MyZuHe.TextString(textName, value, m_JianGe + changJianGe, ref isShow, showAction, color, isRed);
        }

        public string TextString2(string textStr, string value, ref bool isShow, Action showAction, int changJianGe = 0, bool isRed = false)
        {
            return MyZuHe.TextString2(textStr, value, m_JianGe + changJianGe, ref isShow, showAction, isRed);
        }

        public string TextString_B(string textName, string value, int changJianGe = 0)
        {
            return TextString(textName.AddBlue(), value, changJianGe);
        }
        public string TextString_B(string textName, string value, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextString(textName.AddBlue(), value, ref isShow, showAction, MyEnumColor.Blue, changJianGe); ;
        }

        public string TextString2_B(string textStr, string value, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextString2(textStr.AddBlue(), value, ref isShow, showAction, changJianGe);
        }

        #endregion

        public void TextEnabledString(string textName, string value, int changJianGe = 0)
        {
            MyZuHe.TextEnabledString(textName, value, m_JianGe + changJianGe);
        }


        public float TextFloat(string textName, float value, float minValue, float maxValue, int changJianGe = 0)
        {
            return MyZuHe.TextFloat(textName, value, minValue, maxValue, m_JianGe + changJianGe);
        }
        #region TextFloat重载
        public float TextFloat(string textStr, float value, float minValue, float maxValue, ref bool isShow, Action showAction, MyEnumColor color = MyEnumColor.LightBlue, int changJianGe = 0)
        {
            return MyZuHe.TextFloat(textStr, value, minValue, maxValue, m_JianGe + changJianGe, ref isShow, showAction, color);
        }

        public float TextFloat2(string textStr, float value, float minValue, float maxValue, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return MyZuHe.TextFloat2(textStr, value, minValue, maxValue, m_JianGe + changJianGe, ref isShow, showAction);
        }

        public float TextFloat_B(string textName, float value, float minValue, float maxValue, int changJianGe = 0)
        {
            return TextFloat(textName.AddBlue(), value, minValue, maxValue, changJianGe); ;
        }


        public float TextFloat_B(string textStr, float value, float minValue, float maxValue, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextFloat(textStr.AddBlue(), value, minValue, maxValue, ref isShow, showAction, MyEnumColor.Blue, changJianGe);
        }


        public float TextFloat2_B(string textStr, float value, float minValue, float maxValue, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextFloat2(textStr.AddBlue(), value, minValue, maxValue, ref isShow, showAction, changJianGe);
        }


        #endregion


        public int TextInt(string textName, int value, int minValue, int maxValue, int changJianGe = 0)
        {
            return MyZuHe.TextInt(textName, value, minValue, maxValue, m_JianGe + changJianGe); ;
        }

        #region TextInt 重载
        public int TextInt(string textStr, int value, int minValue, int maxValue, ref bool isShow, Action showAction, int changJianGe = 0, MyEnumColor color = MyEnumColor.LightBlue)
        {
            return MyZuHe.TextInt(textStr, value, minValue, maxValue, m_JianGe + changJianGe, ref isShow, showAction, color);
        }

        public int TextInt2(string textStr, int value, int minValue, int maxValue, ref bool isShow, Action showAction, int changJianGe = 0, MyEnumColor color = MyEnumColor.LightBlue)
        {
            return MyZuHe.TextInt2(textStr, value, minValue, maxValue, m_JianGe + changJianGe, ref isShow, showAction); ;
        }

        public int TextInt_B(string textName, int value, int minValue, int maxValue, int changJianGe = 0)
        {
            return TextInt(textName.AddBlue(), value, minValue, maxValue, changJianGe); ;
        }


        public int TextInt_B(string textStr, int value, int minValue, int maxValue, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextInt(textStr.AddBlue(), value, minValue, maxValue, ref isShow, showAction, changJianGe, MyEnumColor.Blue);
        }

        public int TextInt2_B(string textStr, int value, int minValue, int maxValue, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextInt2(textStr.AddBlue(), value, minValue, maxValue, ref isShow, showAction, changJianGe, MyEnumColor.Blue); ;
        }

        #endregion


        public bool TextBool(string textStr, bool value, int changJianGe = 0)
        {
            return MyZuHe.TextBool(textStr, value, m_JianGe + changJianGe); ;
        }

        #region TextBool 重载
        public bool TextBool(string textStr, bool value, ref bool isShow, Action showAction, MyEnumColor color = MyEnumColor.LightBlue, int changJianGe = 0)
        {
            return MyZuHe.TextBool(textStr, value, m_JianGe + changJianGe, ref isShow, showAction, color);
        }

        public bool TextBool(string trueStr, string falseStr, bool value, ref bool isShow, Action showAction, int changJianGe = 0, MyEnumColor color = MyEnumColor.LightBlue)
        {
            return MyZuHe.TextBool(trueStr, falseStr, value, m_JianGe + changJianGe, ref isShow, showAction, color);
        }


        public bool TextBool2(string textStr, bool value, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return MyZuHe.TextBool2(textStr, value, m_JianGe + changJianGe, ref isShow, showAction);
        }


        public bool TextBool2(string trueStr, string falseStr, bool value, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return MyZuHe.TextBool2(trueStr, falseStr, value, m_JianGe + changJianGe, ref isShow, showAction);
        }


        public bool TextBool_B(string textStr, bool value, int changJianGe = 0)
        {
            return TextBool(textStr.AddBlue(), value, changJianGe); ;
        }

        public bool TextBool_B(string textStr, bool value, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextBool(textStr.AddBlue(), value, ref isShow, showAction, MyEnumColor.Blue, changJianGe);
        }

        public bool TextBool_B(string trueStr, string falseStr, bool value, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextBool(trueStr.AddBlue(), falseStr.AddBlue(), value, ref isShow, showAction, changJianGe, MyEnumColor.Blue);
        }


        public bool TextBool2_B(string textStr, bool value, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextBool2(textStr.AddBlue(), value, ref isShow, showAction, changJianGe);
        }


        public bool TextBool2_B(string trueStr, string falseStr, bool value, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextBool2(trueStr.AddBlue(), falseStr.AddBlue(), value, ref isShow, showAction, changJianGe);
        }

        #endregion


        public void Text(string str1)
        {
            MyCreate.Text("   " + str1);
        }
        #region Text 重载
        public void Text_L(string str1)
        {
            Text(str1.AddLightBlue());
        }

        public void Text_L(params string[] str)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("   <color=#add8e6ff>");
            foreach (string s in str)
            {
                sb.Append(s);
            }
            sb.Append("</color>");
            MyCreate.Text(sb.ToString());
        }


        public void Text_B(params string[] str)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("   <color=#00ffffff>");
            foreach (string s in str)
            {
                sb.Append(s);
            }
            sb.Append("</color>");
            MyCreate.Text(sb.ToString());
        }



        public void Text_B(string str1)
        {
            Text(str1.AddBlue());
        }
        public void Text_G(string str1)
        {
            Text(str1.AddGreen());
        }

        public void Text_G(params string[] str)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("   <color=#00ff00E5>");
            foreach (string s in str)
            {
                sb.Append(s);
            }
            sb.Append("</color>");
            MyCreate.Text(sb.ToString());
        }

        public void Text_O(params string[] str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("   <color=#FFAB12C8>");
            foreach (string s in str)
            {
                sb.Append(s);
            }
            sb.Append("</color>");
            MyCreate.Text(sb.ToString());
        }
        public void Text_LG(string str1)
        {
            Text(str1.AddLightGreen());
        }
        public void Text_R(string str1)
        {
            Text(str1.AddRed());
        }
        public void Text_W(string str1)
        {
            Text(str1.AddWhite());
        }
        public void Text_H(string str1)
        {
            Text(str1.AddHui());
        }

        public void Text_H(params string[] str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("   <color=#c0c0c0ff>");
            foreach (string s in str)
            {
                sb.Append(s);
            }
            sb.Append("</color>");
            MyCreate.Text(sb.ToString());
        }

        public void Text_O(string str1)
        {
            Text(str1.AddOrange());
        }
        public void Text_Y(string str1)
        {
            Text(str1.AddYellow());
        }

        public void Text_Y(params string[] str)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("   <color=#ffff00ff>");
            foreach (string s in str)
            {
                sb.Append(s);
            }
            sb.Append("</color>");
            MyCreate.Text(sb.ToString());
        }


        public void Text(string str1, ref bool isShow, Action showAction, MyEnumColor color = MyEnumColor.LightBlue)
        {
            MyZuHe.Text(str1, ref isShow, showAction, color);
        }

        public void Text_B(string str1, ref bool isShow, Action showAction)
        {
            Text(str1.AddBlue(), ref isShow, showAction, MyEnumColor.Blue);
        }

        public void Text_L(string str1, ref bool isShow, Action showAction)
        {
            Text(str1.AddLightBlue(), ref isShow, showAction, MyEnumColor.LightBlue);
        }

        public void Text_H(string str1, ref bool isShow, Action showAction)
        {
            Text(str1.AddHui(), ref isShow, showAction, MyEnumColor.Hui);
        }

        public void Text_G(string str1, ref bool isShow, Action showAction)
        {
            Text(str1.AddGreen(), ref isShow, showAction, MyEnumColor.Green);
        }

        public void Text_R(string str1, ref bool isShow, Action showAction)
        {
            Text(str1.AddRed(), ref isShow, showAction, MyEnumColor.Red);
        }

        public void Text_W(string str1, ref bool isShow, Action showAction)
        {
            Text(str1.AddWhite(), ref isShow, showAction, MyEnumColor.White);
        }

        public void Text_O(string str1, ref bool isShow, Action showAction)
        {
            Text(str1.AddOrange(), ref isShow, showAction, MyEnumColor.Orange);
        }

        public void Text_Y(string str1, ref bool isShow, Action showAction)
        {
            Text(str1.AddYellow(), ref isShow, showAction, MyEnumColor.Yellow);
        }

        #endregion


        public void TextText(string str1, string str2, int changJianGe = 0)
        {
            MyZuHe.TextText(str1, str2, m_JianGe + changJianGe);
        }
        #region TextText 重载
        public void TextText_BL(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddBlue(), str2.AddLightBlue(), changJianGe);
        }

        public void TextText_HY(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddHui(), str2.AddYellow(), changJianGe);
        }


        public void TextText_HL(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddHui(), str2.AddLightBlue(), changJianGe);
        }

        public void TextText_HL(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddHui(), str2.AddLightBlue(), ref isShow, showAction, changJianGe, MyEnumColor.Hui);
        }

        public void TextText_BH(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddBlue(), str2.AddHui(), changJianGe);
        }

        public void TextText_LW(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddLightBlue(), str2.AddWhite(), changJianGe);
        }


        public void TextText_YL(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddYellow(), str2.AddLightBlue(), changJianGe);
        }


        public void TextText_BW(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddBlue(), str2.AddWhite(), changJianGe);
        }
        public void TextText_BG(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddBlue(), str2.AddGreen(), changJianGe);
        }


        public void TextText_YR(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddYellow(), str2.AddRed(), changJianGe);
        }

        public void TextText_YG(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddYellow(), str2.AddGreen(), changJianGe);
        }

        public void TextText_YH(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddYellow(), str2.AddHui(), changJianGe);
        }

        public void TextText_WG(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddWhite(), str2.AddGreen(), changJianGe);
        }
        public void TextText_LG(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddLightBlue(), str2.AddGreen(), changJianGe);
        }
        public void TextText_OY(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddOrange(), str2.AddYellow(), changJianGe);
        }
        public void TextText_OL(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddOrange(), str2.AddLightBlue(), changJianGe);
        }

        public void TextText_GY(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddGreen(), str2.AddYellow(), changJianGe);
        }

        public void TextText_HG(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddHui(), str2.AddGreen(), changJianGe);
        }

        public void TextText_RG(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddRed(), str2.AddGreen(), changJianGe);
        }

        public void TextText_OW(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddOrange(), str2.AddWhite(), changJianGe);
        }
        public void TextText_WL(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddWhite(), str2.AddLightBlue(), changJianGe);
        }

        public void TextText_BY(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddBlue(), str2.AddYellow(), changJianGe);
        }
        public void TextText_WY(string str1, string str2, int changJianGe = 0)
        {
            TextText(str1.AddWhite(), str2.AddYellow(), changJianGe);
        }

        public void TextText(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0, MyEnumColor color = MyEnumColor.LightBlue)
        {
            MyZuHe.TextText(str1, str2, m_JianGe + changJianGe, ref isShow, showAction, color);
        }

        public void TextText_BL(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddBlue(), str2.AddLightBlue(), ref isShow, showAction, changJianGe, MyEnumColor.Blue);
        }


        public void TextText_YL(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddYellow(), str2.AddLightBlue(), ref isShow, showAction, changJianGe, MyEnumColor.Yellow);
        }


        public void TextText_B(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddBlue(), str2, ref isShow, showAction, changJianGe, MyEnumColor.Blue);
        }

        public void TextText_LG(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddLightBlue(), str2.AddGreen(), ref isShow, showAction, changJianGe);
        }

        public void TextText_LW(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddLightBlue(), str2.AddWhite(), ref isShow, showAction, changJianGe);
        }

        public void TextText_BW(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddBlue(), str2.AddWhite(), ref isShow, showAction, changJianGe, MyEnumColor.Blue);
        }

        public void TextText_OY(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddOrange(), str2.AddYellow(), ref isShow, showAction, changJianGe, MyEnumColor.Orange);
        }

        public void TextText_OL(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddOrange(), str2.AddLightBlue(), ref isShow, showAction, changJianGe, MyEnumColor.Orange);
        }

        public void TextText_GY(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddGreen(), str2.AddYellow(), ref isShow, showAction, changJianGe, MyEnumColor.Green);
        }

        public void TextText_OW(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddOrange(), str2.AddWhite(), ref isShow, showAction, changJianGe, MyEnumColor.Orange);
        }

        public void TextText_BG(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddBlue(), str2.AddGreen(), ref isShow, showAction, changJianGe, MyEnumColor.Blue);
        }
        public void TextText_WL(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddWhite(), str2.AddLightBlue(), ref isShow, showAction, changJianGe, MyEnumColor.White);
        }


        public void TextText_WY(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddWhite(), str2.AddYellow(), ref isShow, showAction, changJianGe, MyEnumColor.White);
        }


        public void TextText_BY(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextText(str1.AddBlue(), str2.AddYellow(), ref isShow, showAction, changJianGe, MyEnumColor.Blue);
        }


        public void TextText2(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            MyZuHe.TextText2(str1, str2, changJianGe, ref isShow, showAction);
        }





        #endregion



        public void Text3(string str1, string str2, string str3 = "", int changJianGe = 0)
        {
            if (!string.IsNullOrEmpty(str3))
            {
                MyZuHe.Text3(str1, str2, str3.AddHui(), m_JianGe + changJianGe);
            }
            else
            {
                TextText(str1, str2, changJianGe);
            }

        }
        #region Text3 重载
        public void Text3_BL(string str1, string str2, string str3 = "", int changJianGe = 0)
        {
            Text3(str1.AddBlue(), str2.AddLightBlue(), str3, changJianGe);
        }
        public void Text3_OY(string str1, string str2, string str3 = "", int changJianGe = 0)
        {
            Text3(str1.AddOrange(), str2.AddYellow(), str3, changJianGe);
        }



        public void Text3(string str1, string str2, ref bool isShow, Action showAction, string str3 = "", int changJianGe = 0, MyEnumColor color = MyEnumColor.LightBlue)
        {
            if (!string.IsNullOrEmpty(str3))
            {
                MyZuHe.Text3(str1, str2, str3.AddHui(), m_JianGe + changJianGe, ref isShow, showAction, color);
            }
            else
            {
                TextText(str1, str2.AddHui(), ref isShow, showAction, changJianGe, color);
            }

        }
        #endregion



        public void TextSelectText(string str1, string str2, int changJianGe = 0)
        {
            MyZuHe.TextSelectText(str1, str2, m_JianGe + changJianGe);
        }
        #region SelectText 重载
        public void TextSelectText(string str1, string str2, ref bool isShow, Action showAction, MyEnumColor color = MyEnumColor.LightBlue, int changJianGe = 0)
        {
            MyZuHe.TextSelectText(str1, str2, m_JianGe + changJianGe, ref isShow, showAction, color);
        }


        public void SelectTextText(string str1, string str2, int changJianGe = 0)
        {
            MyZuHe.SelectTextText(str1, str2, m_JianGe + changJianGe);
        }


        public void SelectTextText2(string str1, string str2, ref bool isShow, Action showAction, MyEnumColor color, int changJianGe = 0)
        {
            MyZuHe.SelectTextText2(str1, str2, m_JianGe + changJianGe, ref isShow, showAction, color);
        }

        /*----------------------------------------------------------------------------------*/


        public void TextSelectText_Y(string str1, string str2, int changJianGe = 0)
        {
            TextSelectText(str1.AddYellow(), str2, changJianGe);
        }

        public void TextSelectText_B(string str1, string str2, int changJianGe = 0)
        {
            TextSelectText(str1.AddBlue(), str2, changJianGe);
        }

        public void TextSelectText_B(string str1, string str2, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextSelectText(str1.AddBlue(), str2, ref isShow, showAction, MyEnumColor.Blue, changJianGe);
        }


        public void SelectTextText_W(string str1, string str2, int changJianGe = 0)
        {
            SelectTextText(str1, str2.AddWhite(), changJianGe);
        }

        public void SelectTextText_B(string str1, string str2, int changJianGe = 0)
        {
            SelectTextText(str1, str2.AddBlue(), changJianGe);
        }


        #endregion



        public void BiaoTi_B(string biaoTi, bool isKongGe = false)
        {
            MyCreate.FenGeXian_Blue((isKongGe ? "   " : "") + ("[ " + biaoTi + " ]").AddBold());
        }
        #region BiaoTi

        public void BiaoTi_Y(string biaoTi, ref bool isShow, Action action)
        {
            bool tmp = isShow;
            MyCreate.FenGeXian(("[ " + biaoTi + " ]").AddBold().AddYellow(), ref tmp, MyEnumColor.Yellow);
            if (tmp)
            {
                if (null != action)
                {
                    action();
                }
            }
            isShow = tmp;
        }

        public void BiaoTi_Y(string biaoTi, bool isKongGe = false)
        {
            MyCreate.FenGeXian(((isKongGe ? "   " : "") + "[ " + biaoTi + " ]").AddYellowBold());
        }


        public void BiaoTi_R(string biaoTi, bool isKongGe = false)
        {
            MyCreate.FenGeXian(((isKongGe ? "   " : "") + "[ " + biaoTi + " ]").AddRedBold());
        }

        public void BiaoTi_R(string biaoTi, ref bool isShow, Action action)
        {
            bool tmp = isShow;
            MyCreate.FenGeXian(("[ " + biaoTi + " ]").AddBold().AddRed(), ref tmp, MyEnumColor.Red);
            if (tmp)
            {
                if (null != action)
                {
                    action();
                }
            }
            isShow = tmp;
        }

        public void BiaoTi_B(string biaoTi, Action action)
        {
            MyCreate.FenGeXian_Blue(("[ " + biaoTi + " ]").AddBold(), action);
        }

        public void BiaoTi_B(string biaoTi, ref bool isShow, Action action)
        {
            bool tmp = isShow;
            MyCreate.FenGeXian_Blue(("[ " + biaoTi + " ]").AddBold(), ref tmp);
            if (tmp)
            {
                if (null != action)
                {
                    action();
                }
            }
            isShow = tmp;
        }


        public void BiaoTi_B(ref bool isShow, Action action, params string[] desOps)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<color=#00ffffff><b>[ ");
            foreach (string str in desOps)
            {
                sb.Append(str);
            }
            sb.Append(" ]</b></color>");
            bool tmp = isShow;
            MyCreate.FenGeXian_Blue(sb.ToString(), ref tmp);
            if (tmp)
            {
                if (null != action)
                {
                    action();
                }
            }
            isShow = tmp;
        }

        public void BiaoTi_L(string biaoTi, bool isKongGe)
        {
            MyCreate.FenGeXian(((isKongGe ? "   " : "") + "[ " + biaoTi + " ]").AddLightBlueBold());
        }

        public void BiaoTi_L(string biaoTi)
        {
            MyCreate.FenGeXian(("[ " + biaoTi + " ]").AddLightBlueBold());
        }

        public void BiaoTi_L(string biaoTi, ref bool isShow, Action action)
        {
            bool tmp = isShow;
            MyCreate.Heng(() =>
            {
                MyCreate.AddSpace(5);
                MyCreate.FenGeXian(("[ " + biaoTi + " ]").AddBold(), ref tmp, MyEnumColor.LightBlue);
            });
            if (tmp)
            {
                if (null != action)
                {
                    action();
                }
            }
            isShow = tmp;
        }

        public Enum BiaoTi_O(Enum value, int changJianGe = 0)
        {
            return BiaoTi_O("[ " + value + " ]", value, changJianGe); ;
        }

        public Enum BiaoTi_O(Enum value, int index, string[] ops, int changJianGe = 0)
        {
            return MyZuHe.TextEnum(("[ " + ops[index] + " ]").AddOrange(), value, m_JianGe + changJianGe, false);
        }
        public void BiaoTi_O(string biaoTi, bool isKongGe = false)
        {
            MyCreate.FenGeXian(((isKongGe ? "   " : "") + "[ " + biaoTi + " ]").AddOrangeBold());
        }
        public void BiaoTi_G(string biaoTi, bool isKongGe = false)
        {
            MyCreate.FenGeXian(((isKongGe ? "   " : "") + "[ " + biaoTi + " ]").AddOrangeBold());
        }
        public void BiaoTi_O(string biaoTi, Action action)
        {
            MyCreate.FenGeXian(("[ " + biaoTi + " ]").AddOrangeBold(), action);
        }

        public void BiaoTi_O(string biaoTi, ref bool isShow, Action action)
        {
            bool tmp = isShow;
            MyCreate.FenGeXian(("[ " + biaoTi + " ]").AddBold().AddOrange(), ref tmp, MyEnumColor.Orange);
            if (tmp)
            {
                if (null != action)
                {
                    action();
                }
            }
            isShow = tmp;
        }


        public void BiaoTi_G(string biaoTi, ref bool isShow, Action action)
        {
            bool tmp = isShow;
            MyCreate.FenGeXian(("[ " + biaoTi + " ]").AddBold().AddGreen(), ref tmp, MyEnumColor.Green);
            if (tmp)
            {
                if (null != action)
                {
                    action();
                }
            }
            isShow = tmp;
        }

        public Enum BiaoTi_O(string textName, Enum value, int changJianGe = 0)
        {
            return MyZuHe.TextEnum(textName.AddOrange().AddBold(), value, m_JianGe + changJianGe, false);
        }

        public int BiaoTi_O(string textName, int value, string[] displayedOptions, int changJianGe = 0)
        {
            return MyZuHe.TextEnum(textName.AddOrange().AddBold(), value, displayedOptions, m_JianGe + changJianGe, false);
        }

        public Enum BiaoTi2_O(string textName, Enum value, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return TextEnum2(textName.AddOrange(), value, ref isShow, showAction, changJianGe);
        }

        public int BiaoTi2_O(string textStr, int value, string[] displayedOptions, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            return MyZuHe.TextEnum2(textStr.AddOrange(), value, displayedOptions, m_JianGe + changJianGe, ref isShow, showAction, false);
        }

        #endregion


        public void ButtonText(string buttonName, string text, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            MyZuHe.ButtonText(buttonName, text, m_JianGe + changJianGe, ref isShow, showAction);
        }

        public void ButtonText(string buttonName, string text, ref bool isShow, Action showAction, Action action2, int changJianGe = 0)
        {
            MyZuHe.ButtonText(buttonName, text, m_JianGe + changJianGe, ref isShow, showAction, action2);
        }
        #region ButtonText 重载

        public void ButtonText_OY(string buttonName, string text, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            MyZuHe.ButtonText(buttonName.AddOrange(), text.AddYellow(), m_JianGe + changJianGe, ref isShow, showAction);
        }

        public void ButtonText_OY(string buttonName, string text, ref bool isShow, Action showAction, Action action2, int changJianGe = 0)
        {
            MyZuHe.ButtonText(buttonName.AddOrange(), text.AddYellow(), m_JianGe + changJianGe, ref isShow, showAction, action2);
        }

        public void ButtonText_O(string buttonName, string text, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            MyZuHe.ButtonText(buttonName.AddOrange(), text, m_JianGe + changJianGe, ref isShow, showAction);
        }

        public void ButtonText_O(string buttonName, string text, ref bool isShow, Action showAction, Action action2, int changJianGe = 0)
        {
            MyZuHe.ButtonText(buttonName.AddOrange(), text, m_JianGe + changJianGe, ref isShow, showAction, action2);
        }

        public void ButtonText_H(string buttonName, string text, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            MyZuHe.ButtonText(buttonName.AddHui(), text, m_JianGe + changJianGe, ref isShow, showAction);
        }

        public void ButtonText_H(string buttonName, string text, ref bool isShow, Action showAction, Action action2, int changJianGe = 0)
        {
            MyZuHe.ButtonText(buttonName.AddHui(), text, m_JianGe + changJianGe, ref isShow, showAction, action2);
        }


        #endregion


        public void TextButton(string text, string buttonText, Action onClick, int changJianGe = 0)
        {
            MyZuHe.TextButton(text, buttonText, m_JianGe + changJianGe, onClick);
        }
        #region TextButton 重载

        public void TextButton(string text, string buttonText, Action onClick, ref bool isShow, Action showAction, int changJianGe = 0, MyEnumColor color = MyEnumColor.LightBlue)
        {
            MyZuHe.TextButton(text, buttonText, m_JianGe + changJianGe, onClick, ref isShow, showAction, color);
        }


        public void TextButton_B(string text, string buttonText, Action onClick, int changJianGe = 0)
        {
            TextButton(text.AddBlue(), buttonText, onClick, changJianGe);
        }


        public void TextButton_B(string text, string buttonText, Action onClick, ref bool isShow, Action showAction, int changJianGe = 0)
        {
            TextButton(text.AddBlue(), buttonText, onClick, ref isShow, showAction, changJianGe, MyEnumColor.Blue);
        }

        public void TextButton_Open(string text, Action onClick)
        {
            MyCreate.Heng(() =>
            {
                MyCreate.FenGeXian(text);
                MyCreate.AddSpace();
                MyCreate.Button("  打开  ", onClick);

            });
        }

        public void TextButton_Open(string text, string url)
        {
            MyCreate.Heng(() =>
            {
                Text(text);
                MyCreate.AddSpace();
                MyCreate.Button("  打开  ", () =>
                {
                    Application.OpenURL(url);
                });

            });
        }
        #endregion


        public void GuangFangWenDan(string url, string addDes = "")    //官方文档
        {
            MyCreate.Heng(() =>
            {
                MyCreate.AddSpace();
                string des = "官方文档 ".PadLeft(30) + (string.IsNullOrEmpty(addDes) ? "" : "(" + addDes + ")");
                MyCreate.FenGeXian(des, () =>
                {
                    Application.OpenURL(url);

                });
            });
        }
        #region URL
        public void TextUrl(string text, string url)             //URL在前面
        {
            MyCreate.Heng(() =>
            {
                MyCreate.AddSpace(15);
                MyCreate.FenGeXian(text, () =>
                {
                    Application.OpenURL(url);
                });
            });
        }

        public void TextUrl(string text, string str2, string url)
        {
            MyCreate.Heng(() =>
            {
                Text_G(text);
                MyCreate.AddSpace();
                MyCreate.TextButton(("[" + str2 + "]").AddLightGreen(), () =>
                {
                    Application.OpenURL(url);
                });
            });
        }





        public void GuangFangWenDan_Select(                      //可选择 + 官方文档
           string selectStr, string url)
        {
            MyCreate.Heng(() =>
            {
                MyCreate.Shu(() =>
                {
                    MyCreate.AddSpace(12);
                    MyCreate.SelectText(selectStr);
                });
                MyCreate.AddSpace(100);
                MyCreate.FenGeXian("官方文档  ".PadLeft(30), () =>
                {
                    Application.OpenURL(url);
                });
            });
        }



        #endregion


        public void Method(string str1, string caiShu, string des, string re = "", int changJianGe = 0)
        {
            if (!string.IsNullOrEmpty(re))
            {
                re = re.AddSize(11).ToString();
            }
            Text3(str1 + " " + caiShu.AddSize(11), des, re, changJianGe);
            MyCreate.AddSpace(3);
        }
        #region Method 重载

        public void Method(string str1, string caiShu, string des, string re, ref bool isShow, Action action, int changJianGe = 0, MyEnumColor color = MyEnumColor.LightBlue)
        {
            if (!string.IsNullOrEmpty(re))
            {
                re = re.AddSize(11).ToString();
            }
            Text3(str1 + " " + caiShu.AddSize(11), des, ref isShow, action, re, changJianGe, color);
            MyCreate.AddSpace(3);
        }

        public void Method_BY(string str1, string caiShu, string des, string re = "", int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddBlue(), tmp, des.AddYellow(), re, changJianGe);
        }

        public void Method_BY(string str1, string caiShu, string des, string re, ref bool isShow, Action action, int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddBlue(), tmp, des.AddYellow(), re, ref isShow, action, changJianGe, MyEnumColor.Blue);
        }


        public void Method_OY(string str1, string caiShu, string des, string re = "", int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddOrange(), tmp, des.AddYellow(), re, changJianGe);
        }

        public void Method_OY(string str1, string caiShu, string des, string re, ref bool isShow, Action action, int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddOrange(), tmp, des.AddYellow(), re, ref isShow, action, changJianGe, MyEnumColor.Orange);
        }

        public void Method_OW(string str1, string caiShu, string des, string re = "", int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddOrange(), tmp, des.AddWhite(), re.AddLightBlue(), changJianGe);
        }


        public void Method_BW(string str1, string caiShu, string des, string re = "", int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddBlue(), tmp, des.AddWhite(), re.AddGreen(), changJianGe);
        }

        public void Method_BW(string str1, string caiShu, string des, string re, ref bool isShow, Action action, int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddBlue(), tmp, des.AddWhite(), re.AddGreen(), ref isShow, action, changJianGe, MyEnumColor.Blue);
        }

        public void Method_YG(string str1, string caiShu, string des, string re = "", int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddYellow(), tmp, des.AddGreen(), re, changJianGe);
        }

        public void Method_YL(string str1, string caiShu, string des, string re = "", int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddYellow(), tmp, des.AddLightBlue(), re, changJianGe);
        }


        public void Method_YH(string str1, string caiShu, string des, string re = "", int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddYellow(), tmp, des.AddHui(), re, changJianGe);
        }

        public void Method_YW(string str1, string caiShu, string des, string re = "", int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddYellow(), tmp, des.AddWhite(), re, changJianGe);
        }
        public void Method_YG(string str1, string caiShu, string des, string re, ref bool isShow, Action action, int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddYellow(), tmp, des.AddGreen(), re, ref isShow, action, changJianGe, MyEnumColor.Yellow);
        }


        public void Method_YL(string str1, string caiShu, string des, string re, ref bool isShow, Action action, int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddYellow(), tmp, des.AddLightBlue(), re, ref isShow, action, changJianGe, MyEnumColor.Yellow);
        }

        public void Method_YW(string str1, string caiShu, string des, string re, ref bool isShow, Action action, int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddYellow(), tmp, des.AddWhite(), re, ref isShow, action, changJianGe, MyEnumColor.Yellow);
        }


        public void Method_BL(string str1, string caiShu, string des, string re = "", int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddBlue(), tmp, des.AddLightBlue(), re, changJianGe);
        }

        public void Method_BL(string str1, string caiShu, string des, string re, ref bool isShow, Action action, int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddBlue(), tmp, des.AddLightBlue(), re, ref isShow, action, changJianGe, MyEnumColor.Blue);
        }

        public void Method_RG(string str1, string caiShu, string des, string re = "", int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddRed(), tmp, des.AddGreen(), re, changJianGe);
        }

        public void Method_RG(string str1, string caiShu, string des, string re, ref bool isShow, Action action, int changJianGe = 0)
        {
            string tmp = "";
            if (!string.IsNullOrEmpty(caiShu))
            {
                tmp = ("(" + caiShu + ")").AddHui();
            }
            Method(str1.AddRed(), tmp, des.AddGreen(), re, ref isShow, action, changJianGe, MyEnumColor.Red);
        }
        #endregion


        public void TwoButton(string str1, string str2, Action onClick1, Action onClick2)
        {
            MyCreate.Heng(() =>
            {
                int width = Screen.width/2-40;
                MyCreate.Button(str1, width, onClick1);
                MyCreate.AddSpace(3);
                if (!string.IsNullOrEmpty(str2))
                {
                   MyCreate.Button(str2, width, onClick2);
                }
            });
        }



        #region 私有
        private readonly int m_JianGe;
        public ZuHeTool(int mJianGe)
        {
            m_JianGe = mJianGe;
        }


        private void EnglishOneLine(string str1, string str2, string str3, string str4, bool isEng)
        {
            MyCreate.Heng(() =>
            {
                GUILayout.BeginHorizontal(GUILayout.Width(210));
                TextText_HG(str1, isEng ? str2 : "", -90);
                GUILayout.EndHorizontal();
                TextText_HG(str3, isEng ? str4 : "", -90);
            });
        }

        #endregion

        public void TextUnityObject<T>(string str, ref T sc, ref bool isShow, Action showAction, Action noShowAction)
            where T : UnityEngine.Object
        {
            T tmp = sc;
            isShow = MyCreate.TextUnityObject(str, ref tmp, isShow, showAction, noShowAction, m_JianGe);
            sc = tmp;
        }


        public void StringButton(ref string value, string buttonName, Action action, int changJianGe = 0)
        {
            value = MyZuHe.StringButton(value, m_JianGe + changJianGe, buttonName, action);
        }

        // 用于显示特性说明
        public void ShowSelectTextDes(string greedText, string des, string selectText)
        {
            MyCreate.Heng(() =>
            {
                Text_G(greedText);
                MyCreate.AddSpace();
                Text_Y("( ", des, " )");
            });
            MyCreate.SelectText(selectText);

        }

        public void ShowSelectTextDes(string greedText, string des, string selectText, ref bool isShow, Action showAction)
        {
            bool tmp = isShow;
            MyCreate.Heng(() =>
            {
                Text_G(greedText, ref tmp, null);
                MyCreate.AddSpace();
                Text_Y("( ", des, " )");
            });
            MyCreate.SelectText(selectText);
            if (null != showAction && tmp)
            {
                showAction();
            }
            isShow = tmp;
        }



        // 英语学习
        public void ShowEnglish(ref bool biaoTi, ref bool isShowEng, KeyValuePair<string, string>[] englishChinas)
        {
            bool tmp = isShowEng;
            bool tmpBiaoTi = biaoTi;
            BiaoTi_O("英文学习", ref tmpBiaoTi, () =>
            {
                MyCreate.Box_Hei(() =>
                {
                    // 每2个值循环一次
                    englishChinas.ForAdd2((ec1, ec2) =>  
                    {
                        // 有两个的情况
                        EnglishOneLine(ec1.Key, ec1.Value, ec2.Key, ec2.Value, tmp);

                    }, (ec1) =>
                    {
                        // 只剩下一个的情况
                        EnglishOneLine(ec1.Key, ec1.Value, "", "", tmp);

                    });

                });
                MyCreate.TextCenterButton(tmp ? "【 关闭翻译 】" : "【 打开翻译 】", () =>
                {
                    tmp = !tmp;
                });
            });
            isShowEng = tmp;
            biaoTi = tmpBiaoTi;
        }




        public void TextTextOpen_BY(string str1,string str2,Action action,int changJianGe = 0,string btnName= "详情打开")
        {
            MyCreate.Heng(() =>
            {
                MyCreate.Shu(() =>
                {
                    MyCreate.AddSpace(3);
                    TextText_BY(str1, str2, changJianGe);
                });
                MyCreate.AddSpace();
                MyCreate.Button(btnName, action);
            });
        }

    }



}

