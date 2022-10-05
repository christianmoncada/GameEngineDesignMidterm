using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Player")
        {
            ScoreManager.instance.FinalScore(1);
            Destroy(gameObject);
        }
    }
}
