using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GPS_get : MonoBehaviour {

    LocationInfo currentGPSPosition; // GPS값을 담을 currentGPSPosition 생성 

    double detailed_num = 1.0; //좌표값을 받을떄 float형으로 변하기떄문에 
    double x; //좌표값 변환을 위해
    double z; //좌표값 변환을 위해

    public static Vector3 GPS;

    Transform swan, eagle, durumi, owl;

    void Start () {
        Input.location.Start(0.5f); //GPS 사용선언

        swan = GameObject.Find("Character_collection").transform.Find("swan");
        eagle = GameObject.Find("Character_collection").transform.Find("eagle");
        durumi = GameObject.Find("Character_collection").transform.Find("durumi");
        owl = GameObject.Find("Character_collection").transform.Find("owl");


    }
	

	void Update () {

        if (Input.location.isEnabledByUser)//GPS사용가능할경우
        {

            currentGPSPosition = Input.location.lastData;//gps를 데이터를 받습니다.
            z = (currentGPSPosition.latitude * detailed_num); // 위도
            x = (currentGPSPosition.longitude * detailed_num); // 경도
            GPS = new Vector3((float)x, 0, (float)z); // Y축 제거

   
        }

        else
        {

            Debug.Log("GPS 수신 상태를 확인하여 주십시요.");

        }

        if (z < 34.8866 && z > 34.8852 && x < 127.5094 && x > 126.508)
        // 독수리 z < 34.970 && z > 34.968 && x < 127.477 && x > 126.475
        {
            //34.886487, 127.508125 34.885296, 127.508089
            //34.885192, 127.509325 34.886636, 127.509442
            swan.gameObject.SetActive(false);
            eagle.gameObject.SetActive(true);
            durumi.gameObject.SetActive(false);
            owl.gameObject.SetActive(false);


        }
        else if (z < 34.8867 && z > 34.883 && x < 127.513 && x > 127.511)
        //오리 34.970 && z > 34.968 && x < 127.4785 && x > 127.477
        {
            //34.886872, 127.512239 34.886791, 127.513069
            //34.883786, 127.511436 34.883624, 127.512519

            swan.gameObject.SetActive(true);
            eagle.gameObject.SetActive(false);
            durumi.gameObject.SetActive(false);
            owl.gameObject.SetActive(false);

        }

        else if (z < 34.886 && z > 34.881 && x < 127.516 && x > 127.513) // 두루미
        {
            //34.886665, 127.513511  34.886436, 127.516976
            //34.881796, 127.513069  34.881825, 127.515766
            swan.gameObject.SetActive(false);
            eagle.gameObject.SetActive(false);
            durumi.gameObject.SetActive(true);
            owl.gameObject.SetActive(false);

        }
        else if (z < 34.887 && z > 34.883 && x < 127.511 && x > 127.509) // owl
        {
            //34.887361, 127.509857  34.887050, 127.511707
            //34.884467, 127.509505  34.883979, 127.511138
            swan.gameObject.SetActive(false);
            eagle.gameObject.SetActive(false);
            durumi.gameObject.SetActive(false);
            owl.gameObject.SetActive(true);


        }
       else
        {
            swan.gameObject.SetActive(false);
            eagle.gameObject.SetActive(false);
            durumi.gameObject.SetActive(false);
            owl.gameObject.SetActive(false);
        }
        


    }
}
