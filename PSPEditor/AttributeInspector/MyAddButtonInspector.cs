/*
using System;
using System.Reflection;
using PSPUtil.Attribute;
using PSPUtil.StaticUtil;
using UnityEditor;

namespace UnityEngine
{

    [CustomPropertyDrawer(typeof(MyAddButtonAttribute))]
    public class MyAddButtonInspector : PropertyDrawer
    {
        private const int m_BtnWidth = 50;                         // 按钮的宽度

        private void DrawButton(Rect position, SerializedProperty prop, Action<Rect> action)
        {
            string methodName = ((MyAddButtonAttribute)attribute).MethodName;
            string buttonName = ((MyAddButtonAttribute)attribute).ButtonName;

            if (string.IsNullOrEmpty(methodName))
            {
                methodName = prop.propertyPath + "Method";
                if (string.IsNullOrEmpty(buttonName))
                {
                    buttonName = prop.propertyPath;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(buttonName))
                {
                    buttonName = methodName;
                }
            }

            Rect valuePosition = position;                       //原来的字段
            valuePosition.width = position.width - m_BtnWidth - 1;
            if (null != action)
            {
                action(valuePosition);
            }
            Rect btnPosition = position;                         //添加的按钮
            btnPosition.x = position.x + position.width - m_BtnWidth;
            btnPosition.width = m_BtnWidth;
            Color fristColor = GUI.color;
            GUI.color = MyColor.GetColor(MyEnumColor.LightBlue);
            if (GUI.Button(btnPosition, buttonName))
            {
                Object obj = prop.serializedObject.targetObject;
                Type type = obj.GetType();
                MethodInfo methodInfo = type.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Default | BindingFlags.Public | BindingFlags.CreateInstance | BindingFlags.Instance | BindingFlags.Static);
                if (null != methodInfo)
                {
                    methodInfo.Invoke(obj, null);
                }
                else
                {
                    MyLog.Orange("没找到方法，在参数那里添加方法名啊 —— " + methodName);
                }

            }
            GUI.color = fristColor;
        }


        public override void OnGUI(Rect position, SerializedProperty prop, GUIContent label)
        {
            switch (prop.propertyType)
            {
                case SerializedPropertyType.String:
                    DrawButton(position, prop, (rect) =>
                    {
                        prop.stringValue = EditorGUI.TextField(rect, label, prop.stringValue);
                    });
                    break;
                case SerializedPropertyType.Boolean:
                    DrawButton(position, prop, (rect) =>
                    {
                        prop.boolValue = EditorGUI.Toggle(rect, label, prop.boolValue);
                    });
                    break;
                case SerializedPropertyType.Float:
                    DrawButton(position, prop, (rect) =>
                    {
                        prop.floatValue = EditorGUI.FloatField(rect, label, prop.floatValue);
                    });
                    break;
                case SerializedPropertyType.Integer:
                    DrawButton(position, prop, (rect) =>
                    {
                        prop.intValue = EditorGUI.IntField(rect, label, prop.intValue);
                    });
                    break;
                case SerializedPropertyType.Enum:
                    MyLog.Orange("不支持枚举");
                    break;
                default:
                    MyLog.Red("还没有定义啊喂 —— " + prop.propertyType);
                    break;
            }


        }
    }

}

*/
