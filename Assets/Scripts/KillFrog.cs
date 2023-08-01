using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFrog : MonoBehaviour
{
    public int TotalScore=0;
    [SerializeField]
    GameObject smokeEffect;

    [SerializeField]
    GameObject particleEffect;

    private void Start()
    {
        TotalScore = 0;
    }

    private void OnMouseDown()
    {
        TotalScore = PlayerPrefs.GetInt("Score", 0);
        TotalScore++;
        PlayerPrefs.SetInt("Score", TotalScore);
        PlayerPrefs.Save();

        Destroy(gameObject);
        Instantiate(smokeEffect, transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)

    {
        if(collision.gameObject.CompareTag("Dessert"))
        {
            Destroy(gameObject);
            Instantiate(particleEffect, transform.position, Quaternion.identity);
        }
        
    }
}
