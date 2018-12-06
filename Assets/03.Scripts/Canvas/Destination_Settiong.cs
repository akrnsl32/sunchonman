using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination_Settiong : MonoBehaviour
{

    public GameObject Destination;
    public Camera Map_Camera;

    public static GameObject target;

    public void Update()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<Camera>().enabled)
        {
            if (Input.GetMouseButtonDown(0))
            {
                target = GetClickedObject();
                if (GameObject.Find("Search_view_all"))
                {
                    if (target == GameObject.Find("VR_360View"))

                    {
                        GameObject.Find("VRCam").GetComponent<Camera>().enabled = true;
                        GameObject.Find("Canvas").transform.Find("VR_view_close").gameObject.SetActive(true);
                        GameObject.FindWithTag("MainCamera").GetComponent<Camera>().enabled = false;
                    }

                    if (target == GameObject.Find("View_Close"))
                    {
                        GameObject.Find("Search_view_all").gameObject.SetActive(false);
                    }
                }
            }
        }

        if (Destination_Button.Click_check == true)
        {

            if (Input.GetMouseButtonUp(0))
            {
                Destination_Button.Button_Click++;

            }

            if (Destination_Button.Button_Click == 3)
            {

                if (Input.GetMouseButtonUp(0))
                {

                    Ray ray = Map_Camera.ScreenPointToRay(Input.mousePosition);

                    RaycastHit move;


                    if (Physics.Raycast(ray, out move, Mathf.Infinity))
                    {

                        Vector3 point = new Vector3(move.point.x, 0.1f, move.point.z);
                        Destination.transform.position = point;
                        Destination_Button.Click_check = false;

                    }

                }
            }


        }
    }


    private GameObject GetClickedObject()
    {
        RaycastHit hit;
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //마우스 포인트 근처 좌표를 만든다. 

        if (true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit)))   //마우스 근처에 오브젝트가 있는지 확인
        {
            //있으면 오브젝트를 저장한다.
            target = hit.collider.gameObject;
        }
        return target;

    }
}
