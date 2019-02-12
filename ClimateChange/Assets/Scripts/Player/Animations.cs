using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{

    private Animator animate;
    private Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("space"))
        {
            animate.Play("shooting");

        }
}
    }
