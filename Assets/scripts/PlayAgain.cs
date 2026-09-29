using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  

    public void playagain(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }
}
