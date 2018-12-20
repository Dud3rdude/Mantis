using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpTrigger : MonoBehaviour {

    public AudioSource Scream;
    public GameObject Player;
    public GameObject JumpCam;
    public GameObject FlashIMG;

    void OnTriggerEnter()
    {
   
        Scream.Play();
        JumpCam.SetActive(true);
        Player.SetActive(false);
        FlashIMG.SetActive(true);
        StartCoroutine(EndJump());
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(1.30f);
        Player.SetActive(true);
        JumpCam.SetActive(true);
        FlashIMG.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
}
