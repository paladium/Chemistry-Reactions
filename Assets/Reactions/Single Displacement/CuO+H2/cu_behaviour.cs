using UnityEngine;
using System.Collections;

public class cu_behaviour : MonoBehaviour {

    bool move_body = false;
    bool fly = false;
    float speed;

    void FixedUpdate()
    {
        move_body = main_gui.move_body;
        speed = main_gui.speed;
        if (move_body)
        {
            if (!fly)
            {
                Vector3 force_vector = Quaternion.AngleAxis(Random.Range(25, 45), Vector3.forward) * Vector3.right;

                GetComponent<Rigidbody>().AddForce(speed * force_vector * 100);
                fly = true;
            }
        }
    }
}
