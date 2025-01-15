using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClockHour : MonoBehaviour
{

  
    float hspeed = 0.1f;
   // float mspeed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += hspeed;
        transform.eulerAngles = rot;

        
        }

}
