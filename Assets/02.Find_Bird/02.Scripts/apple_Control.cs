using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple_Control : MonoBehaviour {

    

	void Update () {

            apple_go();
     
        if(GetComponent<Rigidbody>().isKinematic == false)
        {
            transform.Rotate(10, 0, 0);
        }

    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == "eagle")
        {
            GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.GetComponent<Animator>().SetTrigger("Eat");
            Destroy(this.gameObject, 2f);

        }

        else if (other.gameObject.name == "swan")
        {
            GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.GetComponent<Animator>().SetTrigger("Eat");
            Destroy(this.gameObject, 0.8f);

        }

        else if (other.gameObject.name == "durumi")
        {
            GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.GetComponent<Animator>().SetTrigger("Eat");
            Destroy(this.gameObject, 0.8f);

        }
        else if (other.gameObject.name == "owl")
        {
            GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.GetComponent<Animator>().SetTrigger("Eat");
            Destroy(this.gameObject, 0.3f);

        }
    }

        public void apple_go()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, 1);
      
       
    }
     
}
