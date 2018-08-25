using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
static public class Synthesis
{

    static public void Init(List<GameObject> X, List<GameObject> Y, List<Vector3> point)
    {

        //point = new List<Vector3>();
        /*for (int i = 0; i < X.Count; i++)
            point.Add(X[i].transform.position + Y[i].transform.position);
        /*for (int i = 0; i < point.Count; i++)
        {
            int k = Random.Range(min_r, max_r);
            point[i] = new Vector3(point[i].x * Random.Range(min_r, max_r), point[i].y + Random.Range(min_r / k, max_r * Mathf.Sqrt(k)), point[i].z * Random.Range(min_r, -max_r));
        }*/
        for (int i = 0; i < X.Count; i++)
            point.Add(new Vector3(UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(0, 10)));
    }
    static public void Interface(List<GameObject> X, List<GameObject> Y, List<Vector3> point, ref bool state, ref float speed, string formula, GUISkin style)
    {
        GUILayout.BeginArea(new Rect(0, Screen.height - 50, Screen.width, 100));
        GUILayout.BeginHorizontal();
        GUI.skin = style;
        if (state && X.Count == Y.Count)
        {
            for (int i = 0; i < X.Count; i++)
                Global_Functions.Start_Anim(state, X[i], Y[i], point[i], speed);
        }
        if (GUILayout.Button("Start", GUILayout.Height(50)))
        {
            state = true;
        }
        if (GUILayout.Button("Pause", GUILayout.Height(50)))
        {
            state = false;
        }
        if (GUILayout.Button("Stop", GUILayout.Height(50)))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        speed = GUILayout.HorizontalSlider(speed, 0.01f, 3.0f);
        GUILayout.Label("Current speed " + String.Format("{0:F2}", speed));

        GUILayout.EndHorizontal();
        GUILayout.EndArea();

        #region top_panel
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, 100));
        GUILayout.BeginHorizontal();

        if (GUILayout.Button(formula, GUILayout.Height(100), GUILayout.Width(Screen.width)))
        {

        }
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
        #endregion
    }
    static public void Draw_UI(string reaction, ref bool state,ref float speed, float min, float max)
    {
        GUILayout.BeginArea(new Rect(0, Screen.height - 50, Screen.width, 100));
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Начать", GUILayout.Height(50)))
        {
            state = true;
        }
        if (GUILayout.Button("Стоп", GUILayout.Height(50)))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        speed = GUILayout.HorizontalSlider(speed, min, max);
        GUILayout.Label("Скорость " + String.Format("{0:F2}", speed));
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
        #region top_panel
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, 100));
        GUILayout.BeginHorizontal();
        GUILayout.Box(reaction, GUILayout.Height(100), GUILayout.Width(Screen.width));
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
        #endregion
        
    }
}
