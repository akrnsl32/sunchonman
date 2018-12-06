using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Camera_Change : MonoBehaviour
{

    GameObject Map_Camera, AR_Camera, Cam_Change_Button,map, myPosition;
    public Sprite Map_img, AR_img;

    // Use this for initialization
    void Start()
    {

        Map_Camera = GameObject.FindWithTag("MainCamera");
        AR_Camera = GameObject.Find("Camera");
        Cam_Change_Button = GameObject.Find("Cam_Change");
        map = GameObject.Find("map");
        myPosition = GameObject.Find("myPosition");

    }

    public void Cam_Change()
    {

        if (Map_Camera.GetComponent<Camera>().enabled == false)
        {
            Map_Camera.GetComponent<Camera>().enabled = true;
            AR_Camera.GetComponent<Camera>().enabled = false;
            Cam_Change_Button.GetComponent<Image>().sprite = AR_img;
            map.SetActive(true);
            myPosition.SetActive(true);
        }

        else
        {
            AR_Camera.GetComponent<Camera>().enabled = true;
            Map_Camera.GetComponent<Camera>().enabled = false;
            
            Cam_Change_Button.GetComponent<Image>().sprite = Map_img;
            GameObject.Find("map").SetActive(false);
            myPosition.SetActive(false);
        }
    }


}
