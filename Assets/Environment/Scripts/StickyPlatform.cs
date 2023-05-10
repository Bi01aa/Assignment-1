using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerObject")
        {
            other.gameObject.transform.SetParent(transform);
            Debug.Log("On platform");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "PlayerObject")
        {
            other.gameObject.transform.SetParent(null);
            Debug.Log("Off platform");
        }
    }
}
