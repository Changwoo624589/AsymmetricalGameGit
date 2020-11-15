using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHood : MonoBehaviour
{
    public Transform[] limit;
    public Transform driver;
    private Transform tr;
    public ParticleSystem vomit;
    
    
    void Start()
    {
        
        tr = GetComponent<Transform>();
        vomit.emissionRate = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(driver);

        if (Input.GetKey(KeyCode.I))
        {
            vomit.Emit(15);
        }
        
        if (/*Input.GetAxisRaw("Horizontal") < 0*/Input.GetKey(KeyCode.J))
        {
            tr.position = Vector3.MoveTowards(tr.position, new Vector3(limit[0].position.x, tr.position.y, limit[0].position.z), 3*Time.deltaTime);
        }
        else if (/*Input.GetAxisRaw("Horizontal") > 0*/ Input.GetKey(KeyCode.L)) {
            tr.position = Vector3.MoveTowards(tr.position, new Vector3(limit[1].position.x, tr.position.y, limit[1].position.z), 3*Time.deltaTime);
        }
    }
}
