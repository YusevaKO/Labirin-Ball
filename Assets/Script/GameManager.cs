using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject panelPause;
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        scoring.score = 0;
        Time.timeScale = 1;
    }
    public void Pindahscene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            panelPause.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            panelPause.SetActive(false);
        }
    }
}
