using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    // Start is called before the first frame update

    [SerializeField]
    Text scoreText;

    public int TotalScore;
    void Start()
    {
        StartCoroutine(spawingFrog());
        
    }

    // Update is called once per frame
    void Update()
    {
        TotalScore = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = "Score: " + TotalScore.ToString();
    }

    IEnumerator spawingFrog()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.8f);
            float posY = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float posX = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
            Vector2 spawnPosition = new Vector2(posX, posY);
            Instantiate(player, spawnPosition, Quaternion.identity);
        }    
    }
}
