using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chkk : MonoBehaviour
{
    private Transform cube;
    private collisiondetection coll;
    public Text sc,wintext;
    public float coun=0;
    // Start is called before the first frame update
    void Start()
    {
        //coll=GetComponent<collisiondetection>();
        cube=GameObject.Find("Cube").gameObject.transform;
        sc.text="Score :"+coun;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*30*Time.deltaTime);
    }
    public void OnCollisionEnter(Collision col){
        if(col.gameObject.tag=="cube"){
            Debug.Log("collided");
            gameObject.transform.localScale=cube.lossyScale;
            coun+=50;
           sc.text="Score :"+coun;
        }
        if(col.gameObject.tag=="cube2"){
            Debug.Log("cllided with second");
            gameObject.transform.localScale=GameObject.Find("Cube2").gameObject.transform.lossyScale;
          //  transform.position=new Vector3(transform.position.x,1f,transform.position.z);
           coun+=50;
           sc.text="Score :"+coun;
        }
         if(col.gameObject.tag=="cube3"){
            Debug.Log("cllided with third");
            gameObject.transform.localScale=GameObject.Find("Cube3").gameObject.transform.lossyScale;
            //transform.position=new Vector3(transform.position.x,1f,transform.position.z);
            coun+=50;
           sc.text="Score :"+coun;
        }
        if(col.gameObject.tag=="win"){
            Debug.Log("cllided with win");
            Time.timeScale=0;
            wintext.text="You Win";
        }
    }
}
