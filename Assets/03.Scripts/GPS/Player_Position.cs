using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Position : MonoBehaviour {

    LocationInfo currentGPSPosition; // GPS값을 담을 currentGPSPosition 생성 

    double detailed_num = 1.0; //좌표값을 받을떄 float형으로 변하기떄문에 
    double x; //좌표값 변환을 위해
    double z; //좌표값 변환을 위해

    void Start () {
        Input.location.Start(0.5f); //GPS 사용선언
        int wait = 1000; //대기 시간

        if (Input.location.isEnabledByUser)//GPS사용가능할경우
        {
            while (Input.location.status == LocationServiceStatus.Initializing && wait > 0)//초기화 진행중이면
            {
                wait--; // 대기시간
            }
        }

        else {

            Debug.Log("GPS 수신 상태를 확인하여 주십시요.");

        }


    }
	
	// Update is called once per frame
	void Update () {

        currentGPSPosition = Input.location.lastData;//gps를 데이터를 받습니다.
        z = (currentGPSPosition.latitude * detailed_num - 34) * 10000; // 위도
        x = (currentGPSPosition.longitude * detailed_num - 127) * 10000; // 경도
        transform.localPosition = new Vector3((float)x, 2.85f, (float)z); // Y축 제거
    }
}
