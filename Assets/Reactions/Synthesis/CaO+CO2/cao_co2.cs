using UnityEngine;
using System.Collections;

public class cao_co2 : MonoBehaviour {

    public GameObject co2;
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
        if (move_body)
        {
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + speed * co2.transform.position * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.S) && !move_body)
        {
            move_body = true;
        }
        if (Vector3.Distance(co2.transform.position, transform.position) <= 1f)
        {
            if (!connect_object)
            {
                StartCoroutine(add(co2));
                connect_object = true;
            }
        }
    }
}
