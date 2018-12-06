using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guiding : MonoBehaviour {

    LocationInfo currentGPSPosition;

    Animator animator;
    public static float dist; // 거리
    private Transform guide;  // guide 위치
    private Transform destination; // 목적지
    NavMeshAgent nvAgent; //nvAgent에 nav경로 

    double detailed_num = 1.0;

    double x;
    double z;
    double last_x;
    double last_z;

    float movespeed = 0.05f;
    float Limit_distance = 0.32f;


    void Start () {

        animator = gameObject.GetComponent<Animator>();

        Input.location.Start(0.5f); // GPS사용 선언
        int wait = 1000;
        if (Input.location.isEnabledByUser)//GPS 사용가능 
        {
            while (Input.location.status == LocationServiceStatus.Initializing && wait > 0)//초기화 진행
            {
                wait--;
            }
            currentGPSPosition = Input.location.lastData;//gps 위치를 받음
        }

        else//GPS가 없는 경우 
        {
            Debug.Log("GPS 상태를 확인해주세요");
        }
    }


    void Update()
    {


        if (GameObject.FindWithTag("Destination"))
        {
            guide = gameObject.GetComponent<Transform>(); // Guide의 위치를 받아옴
            destination = GameObject.FindWithTag("Destination").GetComponent<Transform>(); //tag가 destination인 오브젝트의 위치를 받아옴
            nvAgent = gameObject.GetComponent<NavMeshAgent>(); // 네비메쉬의 값을 가져오기
            nvAgent.destination = destination.position; //목적지 설정
            nvAgent.speed = 0; //속도 설정

            // 이동 경로 보여주기
            if (nvAgent == null || nvAgent.path == null) return;

            var line = this.GetComponent<LineRenderer>();
            var path = nvAgent.path;
            line.SetVertexCount(path.corners.Length);


            for (int i = 0; i < path.corners.Length; i++)
            {
                line.SetPosition(i, path.corners[i]);
            }


            currentGPSPosition = Input.location.lastData;//gps 위치를 받음
            z = (currentGPSPosition.latitude * detailed_num - 34) * 10000;
            x = (currentGPSPosition.longitude * detailed_num - 127) * 10000;

            Vector3 PlayerPosition = new Vector3((float)x, 0, (float)z); // gps 위치
            Vector3 Guider_Position = guide.transform.position; //Guider의 위치 
            Vector3 Guider_Y = new Vector3(Guider_Position.x, 0, Guider_Position.z); // Guider의 위치 Y축값 제거
            Vector3 destination_Y = new Vector3(destination.position.x, 0, destination.position.z); //목적지 위치
            Vector3 last_GPS = new Vector3((float)last_x, 0, (float)last_z); // 갱신전 GPS 위치

            dist = Vector3.Distance(Guider_Y, PlayerPosition); //GPS위치와 Guider의 거리 계산

            float arrive = Vector3.Distance(Guider_Y, destination_Y); // Guider부터 목적지 거리
          //  float arrive2 = Vector3.Distance(PlayerPosition, destination_Y); // GPS부터 목적지까지 거리

            // 좌표값의 변화 확인
            float speed_add = Vector3.Distance(last_GPS, PlayerPosition);

            if (speed_add == 0) // GPS에 변화가 없을경우
            {
                last_x = x;
                last_z = z;
                speed_add = 1;
            }
            else
            {
                last_x = x;
                last_z = z;
                speed_add += 1;
            }
            
            if (dist >10 || arrive <0.5) // 나와 일정거리가 떨어질때 or 캐릭터와 목적지의 거리 차이가 얼마 안날때 
            {
                nvAgent.speed = 0;

                if (arrive < 0.1)
                {
                    animator.SetInteger("move", 2);
                }
                else
                {
                    animator.SetInteger("move", 0);
                }


                if(dist > 1.0) //위치 초기화
                {

                   transform.position = PlayerPosition;
                }

            }
            else 
            {
                nvAgent.speed = movespeed * speed_add;
                animator.SetInteger("move", 1);
            }

    
        }
    }
}
