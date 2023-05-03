using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerObject")
        {
            collision.gameObject.transform.SetParent(transform);
            Debug.Log("On platform");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "PlayerObject")
        {
            collision.gameObject.transform.SetParent(null);
            Debug.Log("Off platform");
        }
    }
}
