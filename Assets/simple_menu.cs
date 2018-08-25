using UnityEngine;
using System.Collections;

public class simple_menu : MonoBehaviour {

    public GUISkin style;
    void OnGUI()
    {
        GUI.skin = style;
        GUILayout.BeginArea(new Rect(Screen.width / 2, Screen.height / 2, 200, 200));
        GUILayout.BeginVertical();
        if (GUILayout.Button("Cl2+H2"))
        {
            Application.LoadLevel(1);
        }
        if (GUILayout.Button("C+O2"))
        {
            Application.LoadLevel(2);
        }
        if (GUILayout.Button("CaO+CO2"))
        {
            Application.LoadLevel(3);
        }
        GUILayout.EndVertical();
        GUILayout.EndArea();
    }
}
