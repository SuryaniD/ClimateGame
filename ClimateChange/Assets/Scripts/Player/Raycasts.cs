using UnityEngine;

public class Raycasts : MonoBehaviour
{
    private LayerMask groundMask;
    private LayerMask wallMask;
    private Renderer rend;

    public bool Grounded {   get { return DoGroundCheck(); }   }

    void Awake()
    {
        rend = GetComponent<Renderer>();
        groundMask = LayerMask.GetMask("Ground");
    }

    public bool DoGroundCheck()
    {
        float rayCastLength = 1f;
        // ground check

        Debug.DrawRay(new Vector3(rend.bounds.min.x, transform.position.y, 0), -transform.up, Color.green ,rayCastLength);
        Debug.DrawRay(new Vector3(rend.bounds.max.x, transform.position.y, 0), -transform.up, Color.green, rayCastLength);

        if (Physics2D.Raycast(new Vector3(rend.bounds.min.x, transform.position.y, 0), -transform.up, rayCastLength, groundMask))
        { return true; }
        if (Physics2D.Raycast(new Vector3(rend.bounds.max.x, transform.position.y, 0), -transform.up, rayCastLength, groundMask))
        { return true; }
        else { return false; }
    }

}
