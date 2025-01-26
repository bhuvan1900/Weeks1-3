using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    public Transform originalpos;
    public Transform newpos;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            t = Time.deltaTime;
            transform.position = Vector3.Lerp(originalpos.position,newpos.position,t);
        }
        
    }
}
