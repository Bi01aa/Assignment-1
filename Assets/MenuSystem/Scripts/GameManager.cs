using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    
    public UIManager UIManager { get; private set; }
    public static GameManager Instance { get; private set; }
    

    private static float secondsSinceStart;
    

    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(transform.gameObject);
        secondsSinceStart = 0f;
       
        GameManager.Instance.UIManager = GetComponent<UIManager>();

        
    }


    void Update()
    {
        secondsSinceStart += Time.deltaTime;
        GameManager.Instance.UIManager.UpdateTimeUI(secondsSinceStart);
    }

    

   

    

    

    
}
