using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_move : MonoBehaviour {

    public void Bird_Find_move()
    {
        SceneManager.LoadScene("Friend_View");
    }


    public void navi_move()
    {
        SceneManager.LoadScene("SunCheonman_Demo");
    }
}
