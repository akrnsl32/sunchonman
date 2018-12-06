using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Control : MonoBehaviour {

    GameObject Guid,Destination;


	void Start () {

        Guid = GameObject.Find("Guider");
        Destination = GameObject.FindWithTag("destination");

        Guid.gameObject.SetActive(false);
        Destination.gameObject.SetActive(false);

        if (GameObject.Find("Camera").GetComponent<Camera>().enabled == true)
        {
            GameObject.FindWithTag("MainCamera").GetComponent<Camera>().enabled = true;
            GameObject.Find("Camera").GetComponent<Camera>().enabled = false;
        }

    }
	

	void Update () {

        if (Destination_Button.Button_Click == 3)
        {
            Guid.gameObject.SetActive(true);
            Destination.gameObject.SetActive(true);

        }
        if (GameObject.Find("Search_view_all"))
        {
            if (Destination_Settiong.target == GameObject.Find("Search_Guiding"))
            {
                Guid.gameObject.SetActive(true);
                Destination.gameObject.SetActive(true);
                GameObject.Find("Destination").GetComponent<Transform>().position = GameObject.Find("point").GetComponent<Transform>().position;
                Search_point.point_view.gameObject.SetActive(false);

            }
        }

    }

}
