using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel_img : MonoBehaviour {

    public Sprite eagle_sprite, durumi_sprite, swan_sprite, owl_sprite;
  
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("eagle")& GameObject.Find("Canvas").transform.Find("Panel"))
        {
            GameObject.Find("Canvas").transform.Find("Panel").GetComponent<Image>().sprite = eagle_sprite;
        }
        else if (GameObject.Find("durumi")& GameObject.Find("Canvas").transform.Find("Panel"))
        {
            GameObject.Find("Canvas").transform.Find("Panel").GetComponent<Image>().sprite = durumi_sprite;
        }
        else if (GameObject.Find("owl")& GameObject.Find("Canvas").transform.Find("Panel"))
        {
            GameObject.Find("Canvas").transform.Find("Panel").GetComponent<Image>().sprite = owl_sprite;
        }
        else if (GameObject.Find("swan")& GameObject.Find("Canvas").transform.Find("Panel"))
        {
            GameObject.Find("Canvas").transform.Find("Panel").GetComponent<Image>().sprite = swan_sprite;
        }
    }
}
