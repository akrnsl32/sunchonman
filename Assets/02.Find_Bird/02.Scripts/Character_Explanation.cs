using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_Explanation : MonoBehaviour {



    void Start () {
        GameObject.Find("Canvas").transform.Find("Panel").gameObject.SetActive(true);

    }

}
