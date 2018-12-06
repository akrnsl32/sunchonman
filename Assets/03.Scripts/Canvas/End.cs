using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class End : MonoBehaviour {

    GameObject MessageBox;

    public void End_Button()
    {

        GameObject.Find("Canvas").transform.Find("MessageBox").gameObject.SetActive(true);

    }

    public void Message_Yes()
    {

        SceneManager.LoadScene("menu");
        //Application.Quit();

    }

    public void Message_No()
    {
        GameObject.Find("Canvas").transform.Find("MessageBox").gameObject.SetActive(false);

    }
}
