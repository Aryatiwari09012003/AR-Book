using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RESET : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 ogpos;
    void Start()
    {
        ogpos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTrigger(Collider other)
    {
        if(other.gameObject.CompareTag("AEROPLANEWALL"))
        {
            transform.localPosition = ogpos;
        }

        if(other.gameObject.CompareTag("CLOUDWALL"))
        {

        }
    }
}
