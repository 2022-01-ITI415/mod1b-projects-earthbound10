using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    [Header("Set in Inspector")]
    [Header("Set Dynamically")]
    public float velocityMult = 8f;
    private Rigidbody projecticleRigidbody;
    public GameObject prefabProjectile;
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;
    void Awake(){
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
        launchPos = launchPointTrans.position;
    }
    void OnMouseEnter(){
        print("Slingshot:OnMouseEnter()");
        launchPoint.SetActive(true);
    }
    void OnMouseExit(){
        print("Slingshot:OnMouseExit()");
        launchPoint.SetActive(false);
    }
    void OnMouseDown(){
        aimingMode = true;
        projectile = Instantiate (prefabProjectile) as GameObject;
        projectile.transform.position = launchPos;
        projectile.GetComponent<Rigidbody>().isKinematic = true;
        //projectileRigidbody = projectile.GetComponent<Rigidbody> ();
        //projectileRigidbody.isKinematic = true;
    }
    void Start()
    {
        
    }  
    void Update()
    {
        /*if(!aimingMode){
            return;
        }
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 mouseDelta = mousePos3D-launchPos;
        float maxMagnitude = this.GetComponent<SphereCollider>().radius;
        if (mouseDelta.magnitude > maxMagnitude){
            mouseDelta.Normalize();
            mouseDelta *= maxMagnitude;
        }
        Vector3 projPos = launchPos + mouseDelta;
        projectile.transform.position = projPos;
        if (Input.GetMouseButtonUp(0)){
            aimingMode = false;
            projectileRigidbody.isKinematic = false;
            projectileRigidbody.velocity = -mouseDelta * velocityMult;
            projecticle = null;
        }*/
    }
}
