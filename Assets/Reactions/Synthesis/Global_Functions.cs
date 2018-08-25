using UnityEngine;
using System.Collections;

static public class Global_Functions
{
    static public void Move_To_Point(GameObject body, Vector3 point, float speed)
    {
        float step = speed * Time.deltaTime;
        body.transform.position = Vector3.MoveTowards(body.transform.position, point, step);
    }
    static public Vector3 get_new_point(GameObject g, Vector3 p)
    {
        return new Vector3(p.x - g.transform.GetComponent<SphereCollider>().radius, p.y, p.z);
    }
    static public float get_radius(GameObject g)
    {
        return g.transform.GetComponent<SphereCollider>().radius;
    }
    static public void Start_Anim(bool currect_state, GameObject x, GameObject y, Vector3 point, float speed)
    {
        if (currect_state)
        {
            Move_To_Point(x, get_new_point(x, point), speed);
            Move_To_Point(y, point, speed);
        }
    }
    static public void Start_Anim(bool currect_state, GameObject x, Vector3 point, float speed)
    {
        if (currect_state)
        {
            Move_To_Point(x, get_new_point(x, point), speed);
        }
    }
    static public void set_new_parent(GameObject p, GameObject ob)
    {
        ob.transform.parent = null;
        ob.transform.parent = p.transform;
    }
}
