using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATER : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,90,0) * Time.deltaTime);
    }
}
