/*using PSPUtil.Attribute;
using PSPUtil.StaticUtil;
using UnityEngine;
using UnityEditor;


[CustomPropertyDrawer(typeof(MyHideAttribute))]
public class MyHideInspector : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        MyHideAttribute condHAtt = (MyHideAttribute) attribute;

        bool enabled = GetConditionalHideAttributeResult(condHAtt, property);
        bool wasEnabled = GUI.enabled;
        GUI.enabled = enabled;
        if (enabled)
        {
            EditorGUI.PropertyField(position, property, label, true);
        }

        GUI.enabled = wasEnabled;
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        MyHideAttribute condHAtt = (MyHideAttribute) attribute;
        bool enabled = GetConditionalHideAttributeResult(condHAtt, property);

        if (enabled)
        {
            return EditorGUI.GetPropertyHeight(property, label);
        }
        else
        {
            return -EditorGUIUtility.standardVerticalSpacing;
        }
    }


    private bool GetConditionalHideAttributeResult(MyHideAttribute condHAtt, SerializedProperty property)
    {
        bool enabled = true;
        SerializedProperty sourcePropertyValue =
            property.serializedObject.FindProperty(condHAtt.ConditionalSourceField);
        if (sourcePropertyValue != null)
        {
            switch (sourcePropertyValue.propertyType)
            {
                case SerializedPropertyType.Boolean:
                    return sourcePropertyValue.boolValue;
                case SerializedPropertyType.ObjectReference:
                    return sourcePropertyValue.objectReferenceValue != null;
                default:
                    MyLog.Red("[" + sourcePropertyValue.propertyType + "]" + "这个类型不支持");
                    return true;
            }
        }
        return enabled;
    }
}*/