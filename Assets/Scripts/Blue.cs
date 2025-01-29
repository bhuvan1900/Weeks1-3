using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Blue : MonoBehaviour
{

    private float paul = -3f;
    private float ringo = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
           //puts blue circle in a semi random x and y position
            Vector3 pop = transform.position;
            pop = new Vector3(Random.Range(paul, ringo), (Random.Range(paul, ringo)));
           transform.position = pop;   
        }
    }
}

