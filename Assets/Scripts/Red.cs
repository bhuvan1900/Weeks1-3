using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    public Transform originalpos;
    public Transform newpos;
    public float t;
    public Vector3 startPos = new Vector3(-0.008f, 0.464f,0);

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            t += 0.5f*Time.deltaTime;
            //transform.position = Vector3.Lerp(originalpos.position,newpos.position,t);
            transform.position = Vector3.Lerp(startPos, newpos.position, t);
            //needs animation curve

        }
    }
}
