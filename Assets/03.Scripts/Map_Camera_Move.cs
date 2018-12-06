using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 



public class Map_Camera_Move : MonoBehaviour {

    public float moveSpeed;
    public Transform Map_Camera;

    Vector2 prevPos = Vector2.zero;

    float prevDistance = 0f;

    private Vector2 startPos;

    void Start () {

       Map_Camera = Camera.main.transform; // maincamera 태그의 Transfrom을 받아옴
    }

    public void OnDrag()
    {
        Vector3 temp; // 범위 제약
        temp.x = Mathf.Clamp(transform.position.x, 5087.47f, 5197.2f);
        temp.y = Mathf.Clamp(transform.position.y, 15f, 45f);
        temp.z = Mathf.Clamp(transform.position.z, 8740, 8865.9f);
        transform.position = temp;

        if (Map_Camera.GetComponent<Camera>().enabled == true)
        {
        
            int touchCount = Input.touchCount; // 화면 터치 카운터

            if (touchCount == 1)  //한손으로 터치했을경우
            {
                if (prevPos == Vector2.zero)
                {
                    prevPos = Input.GetTouch(0).position; //터치의 포지션을 받아옴
                    return;
                }
                Vector2 dir = (Input.GetTouch(0).position - prevPos).normalized;

                Vector3 vec = new Vector3(dir.x, 0, dir.y);

                Map_Camera.position -= vec * moveSpeed * Time.deltaTime;
                prevPos = Input.GetTouch(0).position;


            }

            else if (touchCount == 2)
                if (prevDistance == 0)
                {
                    prevDistance = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
                    return;

                }

            float curDistance = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
            float move = prevDistance - curDistance;

            Vector3 pos = Map_Camera.position;

            if (move < 0) pos.y -= moveSpeed * Time.deltaTime;
            else if (move > 0) pos.y += moveSpeed * Time.deltaTime;

            Map_Camera.position = pos;
            prevDistance = curDistance;
        }
    }

    public void ExitDrag()
    {
        prevPos = Vector2.zero;
        prevDistance = 0f;
    }
 
}


