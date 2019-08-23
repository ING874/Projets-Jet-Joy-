using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int point = 1;
    Rigidbody2D body;
    GameObject Coins;

    
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        transform.position += new Vector3(5f * Time.deltaTime, 0, 0);
        
    }
    void FixedUpdate()
    {


        
        if (Input.GetMouseButton(0)){
            body.AddForce(new Vector3(0, 50, 0), 0);

        }
        else if (Input.GetMouseButtonUp(0))
        {
            body.velocity *= 0.25f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "coin"){
            
        }
        else
        {
        
            SceneManager.LoadScene("GameOver");
        }
    }

   

    

}
