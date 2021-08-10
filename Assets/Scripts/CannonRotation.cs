using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotation : MonoBehaviour
{
    public GameObject cannons;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            cannons.transform.Rotate(new Vector3(0, 0, -90));
        }
 

        if (Input.GetKeyDown(KeyCode.E))
        {
            cannons.transform.Rotate(new Vector3(0, 0, 90));
        }
    }
}
