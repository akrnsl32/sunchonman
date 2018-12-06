using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    GameObject Menu_button;
    GameObject Search_list;
   
    // Use this for initialization
    void Start () {

        Menu_button = GameObject.Find("touch").transform.Find("Button").gameObject;
        Search_list = GameObject.Find("touch").transform.Find("Search_point").gameObject;

        Menu_button.SetActive(false);
        Search_list.SetActive(false);

        GameObject.Find("Canvas").transform.Find("VR_view_close").gameObject.SetActive(false);

    }

    public void menu_button()
    {
        
        if (GameObject.Find("Button"))
        {
            Menu_button.SetActive(false);
            Search_list.SetActive(false);
        }

        else
        {
            Menu_button.SetActive(true);
        }
    }

    public void VR_Close_Button()
    {
        if (GameObject.Find("VRCam").GetComponent<Camera>().enabled)
        {
            GameObject.FindWithTag("MainCamera").GetComponent<Camera>().enabled = true;
            GameObject.Find("VRCam").GetComponent<Camera>().enabled = false;
            GameObject.Find("Canvas").transform.Find("VR_view_close").gameObject.SetActive(false);
        }

    }

	
}
