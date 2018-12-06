using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Friend_check : MonoBehaviour {

    int Fddurumi, Fdeagle, Fdowl, Fdswan = 0;
    float add, sub;
    bool emoticon = true;

    void Start () {

        add = 0;
        sub = 1;
	}
	
	// Update is called once per frame
	void Update () {

        if (Characters_Touch.durumi_Touch_Counter > 6 && GameObject.Find("durumi"))
        {
            Fddurumi = 1;
            PlayerPrefs.SetInt("Friend_durumi", Fddurumi);

            if (add < 3)
            {
                add += 0.03f;
                GameObject.Find("emotion_Image").GetComponent<Image>().color = new Color(255, 255, 255, add);

            }
            else if(add >3 & sub >0.1)
            {
                sub -= 0.03f;
                GameObject.Find("emotion_Image").GetComponent<Image>().color = new Color(255, 255, 255, sub);

            }
            
        }
        else if (Characters_Touch.eagle_Touch_Counter > 6 && GameObject.Find("eagle"))
        {
            Fdeagle = 1;
            PlayerPrefs.SetInt("Friend_eagle", Fdeagle);

            if (add < 3)
            {
                add += 0.03f;
                GameObject.Find("emotion_Image").GetComponent<Image>().color = new Color(255, 255, 255, add);

            }
            else if (add > 3 & sub > 0.1)
            {
                sub -= 0.03f;
                GameObject.Find("emotion_Image").GetComponent<Image>().color = new Color(255, 255, 255, sub);

            }
        }
        else if (Characters_Touch.owl_Touch_Counter > 6 && GameObject.Find("owl"))
        {
            Fdowl = 1;
            PlayerPrefs.SetInt("Friend_owl", Fdowl);
            if (add < 3)
            {
                add += 0.03f;
                GameObject.Find("emotion_Image").GetComponent<Image>().color = new Color(255, 255, 255, add);

            }
            else if (add > 3 & sub > 0.1)
            {
                sub -= 0.03f;
                GameObject.Find("emotion_Image").GetComponent<Image>().color = new Color(255, 255, 255, sub);

            }

        }
        else if (Characters_Touch.swan_Touch_Counter > 6 && GameObject.Find("swan"))
        {
            Fdswan = 1;
            PlayerPrefs.SetInt("Friend_swan", Fdswan);

            if (add < 3)
            {
                add += 0.03f;
                GameObject.Find("emotion_Image").GetComponent<Image>().color = new Color(255, 255, 255, add);

            }
            else if (add > 3 & sub > 0.1)
            {
                sub -= 0.03f;
                GameObject.Find("emotion_Image").GetComponent<Image>().color = new Color(255, 255, 255, sub);

            }
        }
        else
        {
            add = 0;
            sub = 1;
        }

    }

   

    
}
