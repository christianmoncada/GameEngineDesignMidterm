using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    private int score = 0;

    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int coinValue)
    {
        score += coinValue;
    }
    public void FinalScore(int coinValue)
    {
        Debug.Log("Congratulations, you beat the level. Your final score is: " +score);
    }
}
