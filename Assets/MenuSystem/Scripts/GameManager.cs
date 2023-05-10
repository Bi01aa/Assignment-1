using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
        secondsSinceStart = 0f;

        DontDestroyOnLoad(transform.gameObject);

       
        Instance.UIManager = GetComponent<UIManager>();

        
    }


    void Update()
    {
        secondsSinceStart += Time.deltaTime;
        UIManager.UpdateTimeUI(secondsSinceStart);
    }

    

   

    

    

    
}
