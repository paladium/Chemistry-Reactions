using UnityEngine;
using System.Collections;

public class o_behaviour : MonoBehaviour {

    public GameObject h;
    bool connect_object = false;
    float speed = 1;
    bool move_body = false;
    IEnumerator add(GameObject g)
    {
        gameObject.AddComponent<FixedJoint>();
        gameObject.GetComponent<FixedJoint>().connectedBody = g.GetComponent<Rigidbody>();
        g.transform.parent = gameObject.transform;
        yield return 0;
    }
    void FixedUpdate()
    {
        move_body = main_gui.move_body;
        speed = main_gui.speed;
        if (move_body)
        {
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + speed * h.transform.position * Time.deltaTime - 0.02f * new Vector3(0, Global_Functions.get_radius(gameObject), 0));
        }
        if (Input.GetKeyDown(KeyCode.S) && !move_body)
        {
            move_body = true;
        }
        if (Vector3.Distance(h.transform.position, transform.position) <= 1f)
        {
            if (!connect_object)
            {
                StartCoroutine(add(h));
                connect_object = true;
            }
        }
    }
}
