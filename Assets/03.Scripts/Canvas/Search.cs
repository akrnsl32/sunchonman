using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Search : MonoBehaviour {

    GameObject Search_list;

	// Use this for initialization
	void Start () {

        Search_list = GameObject.Find("touch").transform.Find("Search_point").gameObject;
      
	}
	
public void Search_list_view()
    {

        if (GameObject.Find("Search_point"))
        {
            Search_list.SetActive(false);
        }

        else
        {
            Search_list.SetActive(true);
        }

        
    }
}
