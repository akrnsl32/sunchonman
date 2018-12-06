using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination_Button : MonoBehaviour {

	public static int Button_Click = 0;
    public static bool Click_check = false;



    public void Destination_Button_Click()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<Camera>().enabled == true)
        {
            if (Input.GetMouseButtonUp(0))
            {
                Button_Click = 1;
                Click_check = true;
            }
        }
    }
}
