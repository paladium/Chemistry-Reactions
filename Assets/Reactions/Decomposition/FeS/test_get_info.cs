using UnityEngine;
using System.Collections;

public class test_get_info : MonoBehaviour
{
    bool is_show = false;
    public string url;
    public string text = "I get some info from server";
    Vector2 scroll_position;
    public GUISkin style;

    IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;
        text = www.text;
    }
    void OnGUI()
    {
        GUI.skin = style;
        GUILayout.BeginArea(new Rect(Screen.width - 300, 100, 300, Screen.height - 150));

        scroll_position = GUILayout.BeginScrollView(scroll_position, true, true, GUILayout.Width(300));
        //
        GUILayout.Label(text);
        //
        GUILayout.EndScrollView();

        GUILayout.EndArea();
    }
}
