using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBar : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Player")
        {
            ScoreManager.instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}
