using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class c_o2 : MonoBehaviour
{

    #region variables
    public List<GameObject> o;
    public List<GameObject> c;
    public float speed = 2.0f;
    List<Vector3> point;
    bool start = false;
    #endregion
    public GUISkin style;
    public List<GameObject> Text_Objects;
    public string new_element;
    IEnumerator Change_texts()
    {
        for (int i = 0; i < Text_Objects.Count; i++)
            Text_Objects[i].GetComponent<TextMesh>().text = new_element;
        Destroy(Text_Objects[1]);
        yield return new WaitForEndOfFrame();
    }
    void Start()
    {
        point = new List<Vector3>();
        //Synthesis.Init(o, c, point);
        for (int i = 0; i < o.Count; i++)
            point.Add(Global_Functions.get_new_point(o[i], c[0].transform.position));
        point[1] = new Vector3(point[1].x + 4 * Global_Functions.get_radius(c[0]), point[1].y, point[1].z);
    }
    void OnGUI()
    {
        Synthesis.Interface(o, c, point, ref start, ref speed, "O2+C=CO2", style);
        if (start)
            StartCoroutine(Change_texts());
        if (start)
        {
            for (int i = 0; i < o.Count; i++)
                Global_Functions.Start_Anim(start, o[i], point[i], speed);
            
        }
    }
}
