using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Green : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //follows mouse if space key hit
        if (Input.GetKey("space"))
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);  
            transform.position= mouse;
        }
    }
}
