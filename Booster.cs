using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public float walkBooster;
    public float runBooster;


    void OnTriggerEnter (Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed *= walkBooster;
        other.GetComponent<FirstPersonMovement>().runSpeed *= runBooster;
    }
   
    void OnTriggerExit (Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed /= walkBooster;
        other.GetComponent<FirstPersonMovement>().runSpeed /= runBooster;
    }
}
