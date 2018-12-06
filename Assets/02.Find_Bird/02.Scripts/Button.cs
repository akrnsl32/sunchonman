using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Button : MonoBehaviour {

    float add = 0;

    public void Message_Close()
    {
        GameObject.Find("Canvas").transform.Find("Panel").gameObject.SetActive(false);
    }

    public void Friend_Find_Button()
    {
        SceneManager.LoadScene("AR_Bird_Module");
    }

    public void Friend_List_Button()
    {
        SceneManager.LoadScene("Friend_View");
    }

    public void Game_Play()
    {/*
        if(Select_Controller.Game_durumi==true &&)
        {


        }
        */

        SceneManager.LoadScene("Title");
    }

    public void Game_Title_back()
    {
        SceneManager.LoadScene("Title");
    }

    public void Title_back()
    {
        SceneManager.LoadScene("menu");
    }
}
