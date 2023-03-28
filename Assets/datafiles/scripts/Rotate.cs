using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
     Vector3 vect;
    public int x, y, z;
    // Start is called before the first frame update

    void Start()
    {
        vect = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vect * Time.deltaTime);
    }
}
