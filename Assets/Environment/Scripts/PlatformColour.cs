using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformColour : MonoBehaviour
{


    void OnTriggerEnter(Collider other)

    {
        print(other.name);
        if (other.name == "Player")

        {
            GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("touched");
        }
    }
}
