using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    float scale = 0f;

    // Update is called once per frame
    void Update()
    {
        if(scale < 1f)
        {
            scale += Time.deltaTime * 4;
            if (scale > 1f) scale = 1f;
            transform.localScale = new Vector3(scale, scale, scale);
        }
        
        transform.position += Time.deltaTime * transform.forward * 4;
    }
}
