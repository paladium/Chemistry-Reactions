using UnityEngine;
using System.Collections;

public class test_gui : MonoBehaviour
{

    public GUISkin style;
    string current_element = "Нажмите на любой обьект";


    void OnGUI()
    {
        GUI.skin = style;
        GUILayout.BeginArea(new Rect(0, 100, 200, 200));
        GUILayout.BeginVertical();
        GUILayout.Box(current_element == "Нажмите на любой обьект" ? current_element : "Это " + current_element + " элемент", GUILayout.Height(100), GUILayout.Width(200));
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Atom")
                {
                    current_element = hit.collider.gameObject.GetComponent<Atom>().name;
                }
            }
        }
        if (GUILayout.Button("Вернуться в меню", GUILayout.Height(100), GUILayout.Width(200)))
        {
            Application.LoadLevel(0);
        }
        GUILayout.EndVertical();
        GUILayout.EndArea();

    }
}
