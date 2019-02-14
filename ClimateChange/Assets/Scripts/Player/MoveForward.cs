using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    Rigidbody2D _object;
    const float _walkspeed = 2f;
    private float _acceleration = 1.0f;
    const float Max_accel = 7f;
   

    // Use this for initialization
    void Start () {
        _object = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_acceleration <= Max_accel)
        { 
            _acceleration += 0.005f;
        }

        _object.velocity = new Vector2((_walkspeed * _acceleration), _object.velocity.y);
    }
}
