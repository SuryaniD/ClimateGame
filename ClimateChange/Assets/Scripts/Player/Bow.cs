using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public GameObject projectile;
    public Transform bulletSpawn;
   // public Animator anim;
    private float Range = 4f;

    private void Start()
    {
      //  anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   //Schiet de pijl
        if (Input.GetKeyDown(KeyCode.X))
        {
            //anim.SetTrigger("shoot");
            ShootAnArrow();
        }

        
    }

    void ShootAnArrow()
    {
        var bullet = (GameObject)Instantiate(
            projectile,
            bulletSpawn.position,
            bulletSpawn.rotation);

        //Snelheid en richting van de pijl
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right * 40;
        //Vernietiged de pijl na een bepaalde tijd
        Destroy(bullet, Range);
    }


}
