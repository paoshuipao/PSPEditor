/*
using System;
using PSPEditor.EditorUtil;
using PSPUtil.Exensions;
using PSPUtil.StaticUtil;
using UnityEngine;

namespace UnityEditor
{
    public class Create3DObject : AbstractKuang<Create3DObject>
    {
        protected override void OnEditorGUI()
        {
            CreateButton("Cube", "立方体", CreateCube);
            CreateButton("Sphere", "球", CreateSphere);
            CreateButton("Capsule", "胶囊体", CreateCapsule);
            CreateButton("Cylinder", "圆柱体", CreateCylinder);
            CreateButton("Plane", "平面", CreatePlane);
            CreateButton("Quad", "前显后隐平面", CreateQuad);
            CreateButton("Wind Zone", "风区 轻微变化大风", CreateWindZone1);
            CreateButton("Wind Zone", "风区 直升机通过效果", CreateWindZone2);
        }


        [MenuItem("GameObject/My3D Object/Cube 立方体", priority = 0)]
        static void CreateCube()
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube);

        }

        [MenuItem("GameObject/My3D Object/Sphere 球", priority = 1)]
        static void CreateSphere()
        {
            GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }

        [MenuItem("GameObject/My3D Object/Capsule 胶囊体", priority = 2)]
        static void CreateCapsule()
        {
            GameObject.CreatePrimitive(PrimitiveType.Capsule);
        }

        [MenuItem("GameObject/My3D Object/Cylinder 圆柱体", priority = 3)]
        static void CreateCylinder()
        {
            GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        }

        [MenuItem("GameObject/My3D Object/Plane 平面", priority = 4)]
        static void CreatePlane()
        {
            GameObject.CreatePrimitive(PrimitiveType.Plane);
        }

        [MenuItem("GameObject/My3D Object/Quad 前显后隐平面", priority = 5)]
        static void CreateQuad()
        {
            GameObject.CreatePrimitive(PrimitiveType.Quad);
        }

        [MenuItem("GameObject/My3D Object/Wind Zone 风区/轻微变化大风", priority = 7)]
        static void CreateWindZone1()
        {
            GameObject go = new GameObject("WindZone");
            WindZone wind = go.AddComponent<WindZone>();
            wind.mode = WindZoneMode.Directional;
            wind.windMain = 1;
            wind.windTurbulence = 0.1f;
            wind.windPulseMagnitude = 1f;
            wind.windPulseFrequency = 0.25f;
        }

        [MenuItem("GameObject/My3D Object/Wind Zone 风区/直升机通过效果", priority = 7)]
        static void CreateWindZone2()
        {
            GameObject go = new GameObject("WindZone");
            WindZone wind = go.AddComponent<WindZone>();
            wind.mode = WindZoneMode.Spherical;
            wind.radius = 5;
            wind.windMain = 3;
            wind.windTurbulence = 5f;
            wind.windPulseMagnitude = 0.1f;
            wind.windPulseFrequency = 1f;
        }


        #region 私有




        [MenuItem("Window/Hierarchy 创建面板")]
        public static Create3DObject ShowWindow()
        {
            return CreateWindow("创建面板", 300, 400);
        }


        protected override string Tittle()
        {
            return "Hierarchy 创建面板";
        }



        #endregion


        private void CreateButton(string str1, string str2, Action action)
        {
            int addPad = 10;
            addPad -= str1.Length;
            if (addPad < 0)
            {
                addPad = 0;
            }
            MyCreate.Button("创建 ".PadLeft(5) + str1 + (" (".PadLeft(addPad) + str2 + ")").AddGreen(), action);
            MyCreate.AddSpace(3);
        }

    }
}


*/
