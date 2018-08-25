using UnityEngine;
using System.Collections;

public class Element{
    string name;
    GameObject body;
    public void set_name(string _name)
    {
        name = _name;
    }
    public string get_name()
    {
        return this.name;
    }
}
