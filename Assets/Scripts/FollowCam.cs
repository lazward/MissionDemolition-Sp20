using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    static public FollowCam S ;
    public bool ___ ;

    public GameObject pointOfInterest ;
    public float camZ ;

    public float easing = 0.05f ;
    public Vector2 minXY ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (pointOfInterest == null) {

            return ;

        }

        Vector3 destination = pointOfInterest.transform.position ;
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
