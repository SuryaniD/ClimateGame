using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    Rigidbody2D _object;
    const float _walkspeed = 0.08f;
    private float _acceleration = 1.0f;
    const float Max_accel = (1 / _walkspeed)*1.2f;
    private float Xpos;
    private float Ypos;
    private float Zpos;

    void ReadPos(Rigidbody2D _obj)
    {
        Xpos = _obj.transform.position.x;
        Ypos = _obj.transform.position.y;
        Zpos = _obj.transform.position.z;
    }

    // Use this for initialization
    void Start () {
        _object = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_acceleration <= Max_accel)
        { 
            _acceleration += 0.0005f;
        }

        ReadPos(_object);

        _object.transform.position = new Vector3(Xpos + (_walkspeed * _acceleration), Ypos, Zpos);
    }
}
