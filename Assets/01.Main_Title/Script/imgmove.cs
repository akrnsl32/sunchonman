using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imgmove : MonoBehaviour {
    int a=1;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        

        if (transform.localPosition.x < -50.0f)
        {
            a = -1;
        }
        else if (transform.localPosition.x > 50.0f)
        {
            a = 1;
        }
        transform.Translate(Vector3.left * 5.0f * Time.deltaTime * a);
    }
}
