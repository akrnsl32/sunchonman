using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple_Instant : MonoBehaviour {

    public GameObject Apple;
	void Start () {
        
	}

    public void apple_button()
    {

        if (GameObject.Find("eagle") || GameObject.Find("durumi") || GameObject.Find("owl") || GameObject.Find("swan"))
        {
            if (!GameObject.FindWithTag("Apple"))
            {
                Instantiate(Apple);
            }
        }
    }

}
