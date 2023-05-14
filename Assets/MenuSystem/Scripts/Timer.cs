using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public static Timer Instance;
    [SerializeField] TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
        
    }


    void Update()
    {
        
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        if(hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
        {
            currentTime = timerLimit;
            SetTimerText();
            enabled = false;
            SceneManager.LoadScene("Game Over Screen");
        }
        
        SetTimerText();
    }

    private void SetTimerText()
    {
        timerText.text = currentTime.ToString("00.00");
    }

   




}
