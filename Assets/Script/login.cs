using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class login : MonoBehaviour
{
    public Text username;
    public InputField inputName;
    public GameObject Hallogin;
    public GameObject mulai;
    public GameObject warning;
    string nama;
    void Start()
    {
        username.text = PlayerPrefs.GetString("nama");
    }
   
    public void clickSave()
    {
        if (string.IsNullOrEmpty(inputName.text))
        {
            Hallogin.gameObject.SetActive(true);
            warning.gameObject.SetActive(true);
        }

        else
        {
            Hallogin.gameObject.SetActive(false);
            PlayerPrefs.SetString("nama", inputName.text);
            mulai.gameObject.SetActive(true);
            username.text = PlayerPrefs.GetString("nama");
        }
    }
}
