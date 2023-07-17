using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndergroundScript : MonoBehaviour
{
    [SerializeField] Transform playerPos;
    [SerializeField] Transform undergroudPos;
    [SerializeField] Transform undergroundExitPos;
    [SerializeField] Transform groundExitPos;
    [SerializeField] GameObject undergroundCam;
    [SerializeField] GameObject mainCam;
    
    private bool canExit = false; // konrtol eediyor undergrouda girdi�ini..
    private void Start()
    {
        mainCam = GameObject.Find("Main Camera");
    }
    private void Update()
    {
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if (Input.GetKey(KeyCode.S) && !canExit)
        {
            undergroundCam.SetActive(true);
           mainCam.SetActive(false);

            playerPos.transform.position = undergroudPos.position;

            canExit = true;// e�er t�neldeyse tunelden ��kmas� i�in
            SoundManager.instance.PlayWithIndex(15);
        }

    } 
    


}
