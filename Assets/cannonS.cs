using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonS : MonoBehaviour
{
    public GameObject refer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = new Vector3(
            gameObject.transform.localRotation.eulerAngles.x,
            refer.transform.localRotation.eulerAngles.y,
            gameObject.transform.localRotation.eulerAngles.z
            );
        transform.rotation = Quaternion.Euler(rot);
    }
}
