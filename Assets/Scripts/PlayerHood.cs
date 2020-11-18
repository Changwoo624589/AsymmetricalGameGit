using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHood : MonoBehaviour
{
    public Transform[] limit;
  
    private Transform tr;
    private float moveSpeed =2.5f;
    RaycastHit hit;
    public GameObject splashImg;
    public GameObject car;
    public bool vomitable;
    private float timerV;
    // public Transform driver;
     public ParticleSystem vomit;


    void Start()
    {
        vomitable = true;
        timerV = 7f;
        tr = GetComponent<Transform>();
        vomit.emissionRate = 0; 
    }

    
    void Update()
    {
        // transform.LookAt(driver);
        MoveMent();
        Vomiting();
       
    }
    void MoveMent() {
        if (/*Input.GetAxisRaw("Horizontal") < 0*/Input.GetKey(KeyCode.J))
        {
            tr.position = Vector3.MoveTowards(tr.position, new Vector3(limit[0].position.x, tr.position.y, limit[0].position.z), moveSpeed * Time.deltaTime);
        }
        else if (/*Input.GetAxisRaw("Horizontal") > 0*/ Input.GetKey(KeyCode.L))
        {
            tr.position = Vector3.MoveTowards(tr.position, new Vector3(limit[1].position.x, tr.position.y, limit[1].position.z), moveSpeed * Time.deltaTime);
        }
    }
    void Vomiting() {
        Debug.Log(timerV);
        if (Input.GetKeyDown(KeyCode.I) && vomitable)
        {
            var splash = Instantiate(splashImg, new Vector3(tr.position.x, tr.position.y + 0.89f, tr.position.z - 2.07f), Quaternion.Euler(new Vector3(-40, 0, 0)));
            vomitable = false;
            splash.transform.parent = car.transform;

             vomit.Emit(25);
        }
        if (!vomitable)
        {
            timerV -= Time.deltaTime;
        }
        if (timerV <= 0)
        {
            vomitable = true;
            timerV = 7f;
        }
    }
    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, -transform.forward * 3f, out hit,3f))
        {
            if (hit.collider.tag == "Windshield")
            {
                Debug.Log("wind");
                Debug.Log(hit.point);
                //Y from character +0.89
                //Z 2.07
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, transform.forward * 3f);
    }
}
