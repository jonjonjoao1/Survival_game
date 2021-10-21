using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Item : MonoBehaviour
{
    public GameController gc;
    public Text tDescription;


    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();





    }











    private void OnTriggerStay(Collider collision)
    {



        if (collision.gameObject.tag == "Player")
        {

            //Mensagem na tela como pegar o item


            tDescription.enabled = true;
            tDescription.text = "Press E to collect " + gameObject.name;


            if(Input.GetKeyDown(KeyCode.E))
            {
                gc.totalColetado++;

               
                
                tDescription.enabled = false;

                Destroy(this.gameObject);
                
                if(gameObject.tag == "Coletavel1")
                {
                    gc.objOvelha = true;
                    gc.imgOvelha.color = new Color(1, 1, 1, 1);
                }

                else if (gameObject.tag == "Coletavel2")
                {
                    gc.imgPorco.color = new Color(1, 1, 1, 1);
                }

                else if (gameObject.tag == "Coletavel3")
                {
                    gc.imgPinguim.color = new Color(1, 1, 1, 1);
                }

                else if (gameObject.tag == "Coletavel4")
                {
                    gc.imgMacaco.color = new Color(1, 1, 1, 1);
                }

                else if (gameObject.tag == "Coletavel5")
                {
                    gc.imgCoelho.color = new Color(1, 1, 1, 1);
            
                }

                else if (gameObject.tag == "Coletavel6")
                {
                    gc.imgUrso.color = new Color(1, 1, 1, 1);
                }

            }


        }



    }


    private void OnTriggerExit(Collider collision)
    {

        tDescription.enabled = false;
    }


  
}
