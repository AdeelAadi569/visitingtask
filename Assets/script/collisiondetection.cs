using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class collisiondetection : MonoBehaviour
{
    private GameObject player;
    public Camera cam;
    public Text wintext,scoretext;
    public float counter=0;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text="Score : "+counter;
        player=GameObject.Find("player");
          gm=GameObject.FindGameObjectWithTag("gm").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider col){
        Debug.Log("Triggerer");
        counter+=25;
        scoretext.text="Score :"+counter;
        if(col.gameObject.tag=="firsthurdle"){
            Debug.Log("Trigger with first hurdle");
            player.transform.localScale=new Vector3(1.8f,1.8f,1);
            

        }
         if(col.gameObject.tag=="sechurdle"){
            Debug.Log("Trigger with second hurdle");
            player.transform.localScale=new Vector3(0.8f,1.5f,1);

        }
        if(col.gameObject.tag=="thirdhurdle"){
            Debug.Log("Trigger with third hurdle");
            player.transform.localScale=new Vector3(2.7f,0.7f,1);

        }
        if(col.gameObject.tag=="forthhurdle"){
            Debug.Log("Trigger with fourth hurdle");
            player.transform.localScale=new Vector3(0.8f,0.7f,1);

        }
        if(col.gameObject.tag=="win"){
            Debug.Log("Trigger with win hurdle");
            player.transform.localScale=new Vector3(1,1,1);
            player.transform.position=new Vector3(transform.position.x,transform.position.y+3,transform.position.z);
              Time.timeScale=0;
            //cam.transform.position=new Vector3(transform.position.x-5,transform.position.y,transform.position.z+2);
            wintext.text="You Win";
             gm.pauseBtn.gameObject.SetActive(false);
            gm.restartBtn.gameObject.SetActive(true);
            gm.nextlvl.gameObject.SetActive(true);                        
        }
    }
}
