using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHood : MonoBehaviour
{
    public Transform[] limit;
    private Transform tr;
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (/*Input.GetAxisRaw("Horizontal") < 0*/Input.GetKey(KeyCode.J))
        {
            tr.position = Vector3.MoveTowards(tr.position, new Vector3(limit[0].position.x, tr.position.y, limit[0].position.z), 3*Time.deltaTime);
        }
        else if (/*Input.GetAxisRaw("Horizontal") > 0*/ Input.GetKey(KeyCode.L)) {
            tr.position = Vector3.MoveTowards(tr.position, new Vector3(limit[1].position.x, tr.position.y, limit[1].position.z), 3*Time.deltaTime);
        }
    }
}
