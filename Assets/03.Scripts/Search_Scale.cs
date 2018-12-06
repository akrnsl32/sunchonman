using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Search_Scale : MonoBehaviour {


    Transform MAIN_CAM;
    GameObject Search_contents;

	void Start () {

        MAIN_CAM = GameObject.Find("Map_Camera").GetComponent<Transform>();
        Search_contents = GameObject.Find("Search_contents");
    }


    void Update()
    {

        if (Search_contents)
        {

            if (MAIN_CAM.position.y < 25)
            {
                Search_contents.GetComponent<Transform>().localScale = new Vector3(20, 10, 2);
            }
            else if (MAIN_CAM.position.y > 26)
            {
                Search_contents.GetComponent<Transform>().localScale = new Vector3(40, 20, 2);
            }
        }
        else {
            Search_contents = GameObject.Find("Search_contents");
        }
    }
}
