using PSPUtil.Attribute;
using PSPUtil.StaticUtil;
using UnityEngine;

namespace UnityEditor
{
    [CustomPropertyDrawer(typeof(MyHeadAttribute))]
    public class MyHeadInspector : DecoratorDrawer
    {
        public override void OnGUI(Rect position)
        {
            string descriptionText = ((MyHeadAttribute)attribute).Description;
            MyEnumColor color = ((MyHeadAttribute)attribute).TextColor;
            int offsetX = ((MyHeadAttribute)attribute).OffsetX;
            position.y += 4f;
            position.x += offsetX;
            Color firstColor = GUI.color;
            GUI.color = MyColor.GetColor(color);
            MyGUI.Text(position, descriptionText);
            GUI.color = firstColor;


        }
        public override float GetHeight()
        {
            return 20;
        }

    }

}

