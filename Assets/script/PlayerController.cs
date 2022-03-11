using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerrb;
    public float speed=10;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm=GameObject.FindGameObjectWithTag("gm").GetComponent<GameManager>();
        playerrb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            Debug.Log("pressed W for forward movemment");
            playerrb.AddForce(transform.forward*speed,ForceMode.Impulse);
        }
        // if(Input.GetKey("a")){
        //     Debug.Log("Press A for left Movement");
        //     playerrb.AddForce(Vector3.left*speed,ForceMode.Impulse);
        // }
        // if (Input.GetKey("d"))
        // {
        //     Debug.Log("press d for right movement");
        //     playerrb.AddForce(Vector3.right*speed,ForceMode.Impulse);
        // }
        if (transform.position.y<=0)
        {
            Time.timeScale=0;
            gm.pauseBtn.gameObject.SetActive(false);
            gm.restartBtn.gameObject.SetActive(true);

        }
        
    }
}
