using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button pauseBtn,restartBtn,resumeBtn,nextlvl;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Resume(){
      Time.timeScale=1;
      resumeBtn.gameObject.SetActive(false);
      pauseBtn.gameObject.SetActive(true);
      restartBtn.gameObject.SetActive(false);
    }
    public void Restart(){
      SceneManager.LoadScene(0);
    }
    public void Pause(){
         Time.timeScale=0;
         pauseBtn.gameObject.SetActive(false);
         resumeBtn.gameObject.SetActive(true);
         restartBtn.gameObject.SetActive(true);
    }
    public void NextLvl(){
        SceneManager.LoadScene(1);
        nextlvl.gameObject.SetActive(false);
        pauseBtn.gameObject.SetActive(true);
        restartBtn.gameObject.SetActive(false);
        resumeBtn.gameObject.SetActive(false);
    }
}
