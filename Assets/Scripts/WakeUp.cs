using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp : MonoBehaviour {

    public GameObject OpenCamera;
    public GameObject FPSController;
    
    // Use this for initialization
	void Start () {
        StartCoroutine(OpeningSequence());


        }
    IEnumerator OpeningSequence ()
    {
        yield return new WaitForSeconds(5);
        FPSController.SetActive(true);
        OpenCamera.SetActive(false);
        
        
    }
}

        

        
	
	


