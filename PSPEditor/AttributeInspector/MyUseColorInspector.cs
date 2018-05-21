/*
using PSPUtil.Attribute;
using PSPUtil.StaticUtil;
using UnityEngine;

namespace UnityEditor
{
    [CustomPropertyDrawer(typeof(MyUseColorAttribute))]
    public class MyUseColorInspector : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            Color firstColor = GUI.color;
            MyEnumColor color = ((MyUseColorAttribute)attribute).TextColor;
            int minValue = ((MyUseColorAttribute)attribute).Min;
            int maxValue = ((MyUseColorAttribute)attribute).Max;
            GUI.color = MyColor.GetColor(color);
            switch (property.propertyType)
            {
                case SerializedPropertyType.Float:
                    if (minValue < 0 || minValue >= maxValue)
                    {
                        property.floatValue = EditorGUI.FloatField(position, label, property.floatValue);
                    }
                    else
                    {
                        property.floatValue = EditorGUI.Slider(position, label, property.floatValue, minValue, maxValue);

                    }
                    break;
                case SerializedPropertyType.Integer:
                    if (minValue < 0 || minValue >= maxValue)
                    {
                        property.intValue = EditorGUI.IntField(position, label, property.intValue);
                    }
                    else
                    {
                        property.intValue = (int)EditorGUI.Slider(position, label, property.intValue, minValue, maxValue);
                    }
                    break;
                case SerializedPropertyType.Boolean:
                    property.boolValue = EditorGUI.Toggle(position, label, property.boolValue);
                    break;
                default:
                    GUI.Label(position, "未实现");
                    break;

            }

            GUI.color = firstColor;
        }


    }


}


*/
