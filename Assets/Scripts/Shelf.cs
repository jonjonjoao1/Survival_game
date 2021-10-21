using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{

    public GameObject ovelha;
    public Transform spawn;
    public GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();


    }



    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Player"))
        {
            if (gc.objOvelha)
            {
                ovelha.SetActive(true);
                //Instantiate(ovelha, spawn);
                gc.objOvelha = false;




            }

        }
        
        
     }


















}
