using UnityEngine;
using System.Collections;

public class c_o2_reaction : MonoBehaviour
{

    public GameObject o1;
    public GameObject o2;
    bool connect_object = false;
    bool move_body = false;
    public GUISkin style;
    float speed = 1;
    IEnumerator add(GameObject g)
    {
        gameObject.AddComponent<FixedJoint>();
        gameObject.GetComponent<FixedJoint>().connectedBody = g.GetComponent<Rigidbody>();
        o1.transform.parent = gameObject.transform;
        o2.transform.parent = gameObject.transform;
        yield return 0;
    }
    void FixedUpdate()
    {
        if (move_body)
        {
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + speed * o1.transform.position * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.S) && !move_body)
        {
            //rigidbody.AddForce(-transform.position, ForceMode.Impulse);
            move_body = true;
        }
        if (Vector3.Distance(o1.transform.position, transform.position) <= 1f)
        {
            if (!connect_object)
            {
                StartCoroutine(add(o1));
                StartCoroutine(add(o2));
                connect_object = true;
            }
        }
    }
    void OnGUI()
    {
        GUI.skin = style;
        Synthesis.Draw_UI("О₂+C=СО₂", ref move_body, ref speed, 1, 5);
    }
}
