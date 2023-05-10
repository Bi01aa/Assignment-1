using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformColour : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Platform")
        {
            other.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("On platform");
        }
    }

}
