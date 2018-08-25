using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cl2_h2 : MonoBehaviour
{
    #region variables
    public List<GameObject> cl;
    public List<GameObject> h;
    public float speed = 2.0f;
    List<Vector3> point;
    bool start = false;
    #endregion
    public GUISkin style;
    public List<TextMesh> Text_Objects;
    public string new_element;
    IEnumerator Change_texts()
    {
        for (int i = 0; i < Text_Objects.Count; i++)
            Text_Objects[i].text = new_element;
        yield return new WaitForEndOfFrame();
    }
    void Start()
    {
        point = new List<Vector3>();
        Synthesis.Init(cl, h, point);
    }
    void OnGUI()
    {
        Synthesis.Interface(cl, h, point, ref start, ref speed, "H2+Cl2=2HCL", style);
        if (start)
            StartCoroutine(Change_texts());
    }

}
