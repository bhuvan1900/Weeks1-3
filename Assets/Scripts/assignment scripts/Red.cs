
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    public Transform newpos;
    public float t;
    public Vector3 startPos = new Vector3(-0.008f, 0.464f,0);
    public AnimationCurve RedCurve;

    void Update()
    {
        if (Input.GetKey("space"))
        {
            //lerping from starting position to the square using the Ani curve to control speed when space is held
            t += 0.5f*Time.deltaTime;
            transform.position = Vector3.Lerp(startPos, newpos.position, RedCurve.Evaluate(t)); 
        }
    }
}
