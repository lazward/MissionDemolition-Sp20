using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    static public FollowCam S ;
    public bool ___ ;

    static public GameObject pointOfInterest ;
    public float camZ ;

    public float easing = 0.05f ;
    public Vector2 minXY ;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate()
    {

        Vector3 destination ;
        if (pointOfInterest == null) {

            destination = Vector3.zero ;

        } else {

            destination = pointOfInterest.transform.position ;

            if (pointOfInterest.tag == "Projectile") {

                if (pointOfInterest.GetComponent<Rigidbody>().IsSleeping()) {

                    pointOfInterest = null ;
                    return ;

                }

            }

        }

        destination.x = Mathf.Max(minXY.x, destination.x) ;
        destination.y = Mathf.Max(minXY.y, destination.y) ;
        destination = Vector3.Lerp(transform.position, destination, easing) ;
        destination.z = camZ ;
        transform.position = destination ;
        this.GetComponent<Camera>().orthographicSize = destination.y + 10 ;
        
    }

    void Awake() {

        S = this ;
        camZ = this.transform.position.z ;

    }
}
