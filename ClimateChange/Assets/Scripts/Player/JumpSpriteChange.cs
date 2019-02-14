using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSpriteChange : MonoBehaviour {
    Animator Runanim;
    private Raycasts ground;
    // Use this for initialization
    void Start () {
        Runanim = GetComponent<Animator>();
        ground = GetComponent<Raycasts>();
        
    }
	
	// Update is called once per frame
	void Update () {
        Runanim.SetBool("Grounded", ground.Grounded);
    }
}
