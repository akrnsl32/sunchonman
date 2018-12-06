using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onff : MonoBehaviour {

    public void off()
    {
        this.gameObject.SetActive(false);
    }
    public void on()
    {
        this.gameObject.SetActive(true);
    }
}
