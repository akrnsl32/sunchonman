using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Search_img : MonoBehaviour {

    public Sprite Point_A, Point_B, Point_C, Point_D, Point_E;

    void Update () {

        if (Search_point.Point_A == true)
        {
            GetComponent<Image>().sprite = Point_A;
            Search_point.Point_A = false;
            
        }
        else if(Search_point.Point_B == true)
            {
                GetComponent<Image>().sprite = Point_B;
                Search_point.Point_B = false;
            }
        else if (Search_point.Point_C == true)
        {
            GetComponent<Image>().sprite = Point_C;
            Search_point.Point_C = false;
        }
        else if (Search_point.Point_D == true)
        {
            GetComponent<Image>().sprite = Point_D;
            Search_point.Point_D = false;
        }
        else if (Search_point.Point_E == true)
        {
            GetComponent<Image>().sprite = Point_E;
            Search_point.Point_E = false;
        }
    }
    public void VR_Camera_Button()
    {
        GameObject.Find("VRCam").GetComponent<Camera>().enabled = true;
     
    }


}
