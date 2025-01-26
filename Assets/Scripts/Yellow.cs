using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : MonoBehaviour
{
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if space key hit, choose a random x pos for yellow within the given range
        if (Input.GetKey("space")){
            Vector3 yellowpos = transform.position;
            yellowpos = new Vector3(Random.Range(1f, 8f), 0);
            transform.position = yellowpos;
        }
    }
}
