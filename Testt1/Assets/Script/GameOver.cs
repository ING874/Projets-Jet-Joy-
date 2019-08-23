using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public float TimeToLoadMenu = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (LoadMenu());
    }

    IEnumerator LoadMenu(){
        yield return new WaitForSeconds(TimeToLoadMenu);
        SceneManager.LoadScene("menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
