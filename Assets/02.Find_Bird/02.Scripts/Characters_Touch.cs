using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters_Touch : MonoBehaviour {

    Animator touch_ani;

    public static int durumi_Touch_Counter, eagle_Touch_Counter, owl_Touch_Counter, swan_Touch_Counter = 0;


    void Start () {

       
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            

            if (Physics.Raycast(ray, out hit))
                {

                
                if (hit.transform.tag == ("character") && hit.transform.name == ("eagle"))
                {
                    int animation_parameters = Random.RandomRange(1, 3);
                    touch_ani = hit.transform.GetComponent<Animator>();

                    touch_ani.SetInteger("touch", animation_parameters);

                    StartCoroutine("touch_rest");

                    eagle_Touch_Counter++;
             

                }

                else if (hit.transform.tag ==("character")&& hit.transform.name == ("swan"))
                 {
                    int animation_parameters = Random.RandomRange(1, 4);
                    touch_ani = hit.transform.GetComponent<Animator>();

                    touch_ani.SetInteger("touch", animation_parameters);

                    StartCoroutine("touch_rest");
                    swan_Touch_Counter++;
                    Debug.Log("swan" + swan_Touch_Counter);

                }

                else if (hit.transform.tag == ("character") && hit.transform.name == ("durumi"))
                {
                    int animation_parameters = Random.RandomRange(1, 3);
                    touch_ani = hit.transform.GetComponent<Animator>();

                    touch_ani.SetInteger("touch", animation_parameters);

                    StartCoroutine("touch_rest");
                    durumi_Touch_Counter++;
                    Debug.Log(hit.transform.name);

                }
                else if (hit.transform.tag == ("character") && hit.transform.name == ("owl"))
                {
                    int animation_parameters = Random.RandomRange(1, 2);
                    touch_ani = hit.transform.GetComponent<Animator>();

                    touch_ani.SetInteger("touch", animation_parameters);

                    StartCoroutine("touch_rest");
                    owl_Touch_Counter++;
                    Debug.Log(hit.transform.name);

                }


            }

        }

    }

    IEnumerator touch_rest()
    {
        yield return new WaitForSeconds(0.6f);
        touch_ani.SetInteger("touch", 0);



    }

}
