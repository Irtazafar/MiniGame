using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartAnim()
    {
        anim.SetTrigger("Active");
    }

    public void PlayGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
