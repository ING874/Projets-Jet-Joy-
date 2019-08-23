using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GMap : MonoBehaviour
{
    public bool gameOver = false;
    
    public GameObject pfloor;
    public GameObject pceil;
    public GameObject Ceilling;
    public GameObject Floor;

    public GameObject Player;

    public GameObject ob1;
    public GameObject ob2;
    public GameObject ob3;
    public GameObject ob4;

    public GameObject obPrefab;

    public float minObY;
    public float maxObY;

    public float minObSpacing;
    public float maxObSpacing;

    public float minObScaleY;
    public float maxObScaleY;
    // Start is called before the first frame update
    void Start()
    {
        ob1 = GenerateOb(Player.transform.position.x + 10);

        ob2 = GenerateOb(ob1.transform.position.x);
        ob3 = GenerateOb(ob2.transform.position.x);
        ob4 = GenerateOb(ob3.transform.position.x);
    }

    GameObject GenerateOb(float referenceX){
        GameObject ob = GameObject.Instantiate(obPrefab);
        SetTransform(ob, referenceX);
        return ob;
    }

    void SetTransform(GameObject ob, float referenceX){
        ob.transform.position = new Vector3(referenceX + Random.Range(minObSpacing, maxObSpacing), Random.Range(minObY, maxObY), 0);
        ob.transform.localScale = new Vector3(ob.transform.localScale.x, Random.Range(minObScaleY, maxObScaleY), ob.transform.localScale.z);
        ob.transform.Rotate(0, 0, Random.Range(0, 360));
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x > Floor.transform.position.x){
            var tempCeilling = pceil;
            var tempFloor = pfloor;
            pceil = Ceilling;
            pfloor = Floor;
            tempCeilling.transform.position += new Vector3(28, 0, 0);
            tempFloor.transform.position += new Vector3(28, 0, 0);

            Ceilling = tempCeilling;
            Floor = tempFloor;

        }

        if (Player.transform.position.x > ob2.transform.position.x){
            var tempOb = ob1;
            ob1 = ob2;
            ob2 = ob3;
            ob3 = ob4;

            SetTransform(tempOb, ob3.transform.position.x);
            ob4 = tempOb;
        }
        

    }

}
