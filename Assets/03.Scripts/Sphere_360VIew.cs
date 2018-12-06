using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere_360VIew : MonoBehaviour {

    public Material Point_A, Point_B, Point_C, Point_D, Point_E;
	

	void Update () {

        if (Search_point.Point_A == true)
        {
            gameObject.GetComponent<MeshRenderer>().material = Point_A;
        }
        else if (Search_point.Point_B == true)
        {
            gameObject.GetComponent<MeshRenderer>().material = Point_B;
        }
        else if (Search_point.Point_C == true)
        {
            gameObject.GetComponent<MeshRenderer>().material = Point_C;
        }
        else if (Search_point.Point_D == true)
        {
            gameObject.GetComponent<MeshRenderer>().material = Point_D;
        }
        else if (Search_point.Point_E == true)
        {
            gameObject.GetComponent<MeshRenderer>().material = Point_E;
        }

    }
}
