using UnityEngine;
using System.Collections;

public class h_behaviour : MonoBehaviour {

    public GameObject o;
    bool connect_object = false;
    float speed = 1;
    bool move_body = false;
    IEnumerator add(GameObject g)
    {
        gameObject.GetComponent<FixedJoint>().connectedBody = g.GetComponent<Rigidbody>();
        yield return 0;
    }
    void FixedUpdate()
    {
        move_body = main_gui.move_body;
        speed = main_gui.speed;
        if (move_body)
        {
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + speed * o.transform.position * Time.deltaTime - 0.02f * new Vector3(0, Global_Functions.get_radius(gameObject), 0));
        }
        if (Input.GetKeyDown(KeyCode.S) && !move_body)
        {
            move_body = true;
        }
        if (Vector3.Distance(o.transform.position, transform.position) <= 0.9f)
        {
            if (!connect_object)
            {
                StartCoroutine(add(o));
                connect_object = true;
            }
        }
    }
}
