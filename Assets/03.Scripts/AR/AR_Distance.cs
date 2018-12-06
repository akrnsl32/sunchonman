using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_Distance : MonoBehaviour {



    Transform AR_Guider;
    Animator ani, AR_Guider_Ani;

	void Start () {


        if (GameObject.Find("Guider"))
        {
            AR_Guider = gameObject.GetComponent<Transform>();

            ani = GameObject.Find("Guider").GetComponent<Animator>();
            AR_Guider_Ani = gameObject.GetComponent<Animator>();
        }
    }
	
	
	void Update () {

        if (GameObject.Find("Guider"))
        {
            AR_Guider = gameObject.GetComponent<Transform>();

            ani = GameObject.Find("Guider").GetComponent<Animator>();
            AR_Guider_Ani = gameObject.GetComponent<Animator>();

            if (this.ani.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Idle"))//대기
            {
                AR_Guider_Ani.SetInteger("move", 0);

          
            }

            else if (this.ani.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.WalkForwardInPlace"))
            {

                AR_Guider_Ani.SetInteger("move", 1);
       
            }
            else if (this.ani.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.JumpDance"))
            {

                AR_Guider_Ani.SetInteger("move", 2);
            
            }

   
            transform.localPosition = new Vector3(0, 0, Mathf.Clamp(transform.localPosition.z, 4, 10));

            if (Guiding.dist >= 5)
            {

                transform.Translate(new Vector3(0, 0, 1f) * Time.deltaTime);
            }
            else
            {
                transform.Translate(new Vector3(0, 0, -1f) * Time.deltaTime);
            }

        }

    }
}
