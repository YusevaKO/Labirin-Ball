using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PindahScene : MonoBehaviour
{
    // public GameObject panelPause;
    public GameObject MenuAwal;
    public GameObject login;
    public GameObject misi;
    public GameObject about;
    public GameObject warning;
    
    public void ExitButtom()
    {
        Application.Quit();
        Debug.Log("Closed");
    }
    public void Pindahscene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }


    public void pindahMenuStart(bool Move = false)
    {
        if (Move == false)
        {
            MenuAwal.SetActive(false);
            login.SetActive(true);
        }
    }
    public void back1(bool Move = false)
    {
        if (Move == false)
        {
            login.SetActive(false);
            MenuAwal.SetActive(true);
            warning.gameObject.SetActive(false);
        }
    }
   
    public void pindahMenuMisi(bool Move = false)
    {
        if (Move == false)
        {
            MenuAwal.SetActive(false);
            misi.SetActive(true);
        }
    }
    public void back3(bool Move = false)
    {
        if (Move == false)
        {
            misi.SetActive(false);
            MenuAwal.SetActive(true);

        }
    }
    public void pindahMenuabout(bool Move = false)
    {
        if (Move == false)
        {
            MenuAwal.SetActive(false);
            about.SetActive(true);
        }
    }
    public void back4(bool Move = false)
    {
        if (Move == false)
        {
            about.SetActive(false);
            MenuAwal.SetActive(true);

        }
    }
}

