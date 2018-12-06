using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guider_Rotation : MonoBehaviour {

    GameObject Guider,AR_Guider;


	void Start () {

        if (GameObject.Find("Guider"))
        {
            Guider = GameObject.Find("Guider");
            AR_Guider = GameObject.Find("AR_Guider");
        }
	}
	
	void Update () {

        if (Guider == null)
        {

            if (GameObject.Find("Guider"))
            {
                Guider = GameObject.Find("Guider");
                AR_Guider = GameObject.Find("AR_Guider");
            }

        }

        else {

            transform.rotation = Guider.transform.rotation;

        }



	}
}
