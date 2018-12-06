using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select_Controller : MonoBehaviour {

    public Sprite durumi_img, eagle_img, owl_img, swan_img;
    public Sprite NSdurumi_img, NSeagle_img, NSowl_img, NSswan_img;
    public Sprite ORdurumi_img, OReagle_img, ORowl_img, ORswan_img;
    public Sprite NSORdurumi_img, NSOReagle_img, NSORowl_img, NSORswan_img;

    Sprite durumi,eagle,owl,swan;

    public static bool Game_eagle, Game_durumi, Game_owl, Game_swan;

 

    public void Start()
    {
        int fddurumi = PlayerPrefs.GetInt("Friend_durumi");
        int fdeagle = PlayerPrefs.GetInt("Friend_eagle");
        int fdowl = PlayerPrefs.GetInt("Friend_owl");
        int fdswan = PlayerPrefs.GetInt("Friend_swan");

        if (fddurumi == 1)
        {
            GameObject.Find("durumi").GetComponent<Image>().sprite = NSORdurumi_img;
        }
      

        if (fdeagle == 1)
        {
            GameObject.Find("eagle").GetComponent<Image>().sprite = NSOReagle_img;
        }
       

        if (fdowl == 1)
        {
            GameObject.Find("owl").GetComponent<Image>().sprite = NSORowl_img;
        }
       

        if (fdswan == 1)
        {
            GameObject.Find("swan").GetComponent<Image>().sprite = NSORswan_img;
        }
       

    }


    void Update () {


       int fddurumi = PlayerPrefs.GetInt("Friend_durumi");
       int fdeagle = PlayerPrefs.GetInt("Friend_eagle");
       int fdowl = PlayerPrefs.GetInt("Friend_owl");
       int fdswan = PlayerPrefs.GetInt("Friend_swan");

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            int animation_parameters = Random.RandomRange(1, 3);
            
            if (Physics.Raycast(ray, out hit))
            {
                

                if (hit.transform.name == ("durumi_check"))
                {
                    Game_durumi = true;
                    Game_eagle = false;
                    Game_owl = false;
                    Game_swan = false;


                    if (fddurumi == 1)
                    {
                        GameObject.Find("durumi").GetComponent<Image>().sprite = ORdurumi_img;
                    }
                    else
                    {
                        GameObject.Find("durumi").GetComponent<Image>().sprite = durumi_img;
                    }

                    if (fdeagle == 1)
                    {
                        GameObject.Find("eagle").GetComponent<Image>().sprite = NSOReagle_img;
                    }
                    else
                    {
                        GameObject.Find("eagle").GetComponent<Image>().sprite = NSeagle_img;
                    }

                    if (fdowl == 1)
                    {
                        GameObject.Find("owl").GetComponent<Image>().sprite = NSORowl_img;
                    }
                    else
                    {
                        GameObject.Find("owl").GetComponent<Image>().sprite = NSowl_img;
                    }

                    if (fdswan == 1)
                    {
                        GameObject.Find("swan").GetComponent<Image>().sprite = NSORswan_img;
                    }
                    else
                    {
                        GameObject.Find("swan").GetComponent<Image>().sprite = NSswan_img;
                    }

                }

                else if (hit.transform.name == ("eagle_check"))
                {
                    Game_durumi = false;
                    Game_eagle = true;
                    Game_owl = false;
                    Game_swan = false;


                    if (fddurumi == 1)
                    {
                        GameObject.Find("durumi").GetComponent<Image>().sprite = NSORdurumi_img;
                    }
                    else
                    {
                        GameObject.Find("durumi").GetComponent<Image>().sprite = NSdurumi_img;
                    }

                    if (fdeagle == 1)
                    {
                        GameObject.Find("eagle").GetComponent<Image>().sprite = OReagle_img;
                    }
                    else
                    {
                        GameObject.Find("eagle").GetComponent<Image>().sprite = eagle_img;
                    }

                    if (fdowl == 1)
                    {
                        GameObject.Find("owl").GetComponent<Image>().sprite = NSORowl_img;
                    }
                    else
                    {
                        GameObject.Find("owl").GetComponent<Image>().sprite = NSowl_img;
                    }

                    if (fdswan == 1)
                    {
                        GameObject.Find("swan").GetComponent<Image>().sprite = NSORswan_img;
                    }
                    else
                    {
                        GameObject.Find("swan").GetComponent<Image>().sprite = NSswan_img;
                    }
                }

                else if (hit.transform.name == ("owl_check"))
                {
                    Game_durumi = false;
                    Game_eagle = false;
                    Game_owl = true;
                    Game_swan = false;


                    if (fddurumi == 1)
                    {
                        GameObject.Find("durumi").GetComponent<Image>().sprite = NSORdurumi_img;
                    }
                    else
                    {
                        GameObject.Find("durumi").GetComponent<Image>().sprite = NSdurumi_img;
                    }

                    if (fdeagle == 1)
                    {
                        GameObject.Find("eagle").GetComponent<Image>().sprite = NSOReagle_img;
                    }
                    else
                    {
                        GameObject.Find("eagle").GetComponent<Image>().sprite = NSeagle_img;
                    }

                    if (fdowl == 1)
                    {
                        GameObject.Find("owl").GetComponent<Image>().sprite = ORowl_img;
                    }
                    else
                    {
                        GameObject.Find("owl").GetComponent<Image>().sprite = owl_img;
                    }

                    if (fdswan == 1)
                    {
                        GameObject.Find("swan").GetComponent<Image>().sprite = NSORswan_img;
                    }
                    else
                    {
                        GameObject.Find("swan").GetComponent<Image>().sprite = NSswan_img;
                    }

                }
                else if (hit.transform.name == ("swan_check"))
                {

                    Game_durumi = false;
                    Game_eagle = false;
                    Game_owl = false;
                    Game_swan = true;


                    if (fddurumi == 1)
                    {
                        GameObject.Find("durumi").GetComponent<Image>().sprite = NSORdurumi_img;
                    }
                    else
                    {
                        GameObject.Find("durumi").GetComponent<Image>().sprite = NSdurumi_img;
                    }

                    if (fdeagle == 1)
                    {
                        GameObject.Find("eagle").GetComponent<Image>().sprite = NSOReagle_img;
                    }
                    else
                    {
                        GameObject.Find("eagle").GetComponent<Image>().sprite = NSeagle_img;
                    }

                    if (fdowl == 1)
                    {
                        GameObject.Find("owl").GetComponent<Image>().sprite = NSORowl_img;
                    }
                    else
                    {
                        GameObject.Find("owl").GetComponent<Image>().sprite = NSowl_img;
                    }

                    if (fdswan == 1)
                    {
                        GameObject.Find("swan").GetComponent<Image>().sprite = ORswan_img;
                    }
                    else
                    {
                        GameObject.Find("swan").GetComponent<Image>().sprite = swan_img;
                    }

                }
            }



        }

}
}
