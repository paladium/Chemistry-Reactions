using UnityEngine;
using System.Collections;

public class main_gui : MonoBehaviour {

    static public bool move_body = false;
    public GUISkin style;
    static public float speed = 1;
    public string reaction;
	void Start()
	{
		move_body = false;
	}
    void OnGUI()
    {
        GUI.skin = style;
        Synthesis.Draw_UI(reaction, ref move_body, ref speed, 0.01f, 3.0f);
    }
}
