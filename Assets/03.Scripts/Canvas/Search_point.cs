using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Search_point : MonoBehaviour {

   GameObject Search;
   GameObject MapCamera;
    public static GameObject point_view;
    public Vector3 Point;

    public static bool Point_A, Point_B, Point_C, Point_D, Point_E = false;

     void Start()
    {
        
        point_view = GameObject.Find("point").transform.Find("Search_view_all").gameObject;

        Search =  GameObject.Find("point");
        MapCamera = GameObject.Find("Map_Camera");
        point_view.gameObject.SetActive(false);
    }

    public void ticket_box() // 매표소
    {
        point_view.SetActive(true);
        Point_A = true;
        Vector3 Point = new Vector3(5087.316f, 0.4f, 8863.695f);
        Search.transform.position = Point;
        // Application.OpenURL("https://www.suncheonbay.go.kr/?c=430/433");
        MapCamera.GetComponent<Transform>().position = new Vector3(Point.x + 10, MapCamera.transform.position.y, Point.z + 8);
    }


    public void natural_ecotourism()//자연생태관
    {
        point_view.SetActive(true);
        Point_B = true;
        Vector3 Point = new Vector3(5095.426f, 0.4f, 8855.645f);
        Search.transform.position = Point;
        MapCamera.GetComponent<Transform>().position = new Vector3(Point.x+10, MapCamera.transform.position.y, Point.z+8);
    }
    public void Craft_shop()//공예특산품관
    {
        point_view.SetActive(true);
        Point_C = true;
        Vector3 Point = new Vector3(5092.055f, 0.4f, 8861.815f);
        Search.transform.position = Point;
        MapCamera.GetComponent<Transform>().position = new Vector3(Point.x + 10, MapCamera.transform.position.y, Point.z + 8);
    }
    public void wish_tunnel()//소망 터널
    {
        point_view.SetActive(true);
        Point_D = true;
        Vector3 Point = new Vector3(5102.763f, 0.4f, 8844.182f);
        Search.transform.position = Point;
        MapCamera.GetComponent<Transform>().position = new Vector3(Point.x + 10, MapCamera.transform.position.y, Point.z + 8);
    }
    public void Observatory()//용산전망대
    {
        point_view.SetActive(true);
        Point_E = true;
        Vector3 Point = new Vector3(5192.544f, 0.4f, 8737.825f);
        Search.transform.position = Point;
        MapCamera.GetComponent<Transform>().position = new Vector3(Point.x + 10, MapCamera.transform.position.y, Point.z + 8);


    }
}
