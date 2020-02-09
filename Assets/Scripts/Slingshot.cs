using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{

    public GameObject launchPoint ;

    public GameObject prefabProjectile ;
    public bool ______ ;

    public Vector3 launchPos ;
    public GameObject projectile ;
    public bool aimingMode ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter() {

        launchPoint.SetActive(true) ;

    }

    void OnMouseExit() {

        launchPoint.SetActive(false) ;

    }

    void Awake() {

        Transform launchPointTrans = transform.Find("LaunchPoint") ;
        launchPoint = launchPointTrans.gameObject ;
        launchPoint.SetActive(false) ;
        launchPos = launchPointTrans.position ;

    }
    
    void OnMouseDown() {

        aimingMode = true ;
        projectile = Instantiate(prefabProjectile)as GameObject ;
        projectile.transform.position = launchPos ;
        projectile.GetComponent<Rigidbody>().isKinematic = true ;

    }

}
