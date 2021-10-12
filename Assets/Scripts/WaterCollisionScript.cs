using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class WaterCollisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.m_cursorIsLocked = false;
            SceneManager.LoadScene("GameLose");
        }
    }
}
