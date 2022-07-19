using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finish : MonoBehaviour
{
    public GameObject Finish;

    public Text TotalText;
    //public Text highScore;
    public float TotalScor;

    void Start() {
        Finish.SetActive(false);
        //highScore.text = PlayerPrefs.GetFloat("NilaiTertinggi", 0).ToString();
    }
    private void OnTriggerEnter(Collider Goal)
    {
        if (Goal.gameObject.tag == "Player")
        {
            Finish.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);
            TotalScor = scoring.score + (1000 / timer.t);
            TotalText.text = TotalScor.ToString("f2");
        }
    }
   /* public void RolDice()
    {

        if (TotalScor > PlayerPrefs.GetFloat("NilaiTertinggi", 0))
        {
            PlayerPrefs.SetFloat("NilaiTertinggi",TotalScor);
            highScore.text = TotalScor.ToString("f2");
        }

    }*/
}
