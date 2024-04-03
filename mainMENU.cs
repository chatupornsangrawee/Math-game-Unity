using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainMENU : MonoBehaviour
{
    public void loadHOMEScene()
    {
        SceneManager.LoadScene("Home", LoadSceneMode.Single);
    }

    public void loadLV1Scene()
    {
        SceneManager.LoadScene("Lv1", LoadSceneMode.Single);
    }

    public void loadLV2Scene()
    {
        SceneManager.LoadScene("Lv2", LoadSceneMode.Single);
    }

    public void loadLV3Scene()
    {
        SceneManager.LoadScene("Lv3", LoadSceneMode.Single);
    }
 
    public void loadLV4Scene()
    {
        SceneManager.LoadScene("Lv4", LoadSceneMode.Single);
    }
 
    public void loadLV5Scene()
    {
        SceneManager.LoadScene("Lv5", LoadSceneMode.Single);
    }
 
 
    public void loadHowto1Scene()
    {
        SceneManager.LoadScene("How to 1", LoadSceneMode.Single);
    }

    public void loadHowto2Scene()
    {
        SceneManager.LoadScene("How to 2", LoadSceneMode.Single);
    }

    public void loadHowto3Scene()
    {
        SceneManager.LoadScene("How to 3", LoadSceneMode.Single);
    }

    public void loadHowto4Scene()
    {
        SceneManager.LoadScene("How to 4", LoadSceneMode.Single);
    }

    public void loadHowto5Scene()
    {
        SceneManager.LoadScene("How to 5", LoadSceneMode.Single);
    }

    public void loadHowto6Scene()
    {
        SceneManager.LoadScene("How to 6", LoadSceneMode.Single);
    }

    public void loadHowto7Scene()
    {
        SceneManager.LoadScene("How to 7", LoadSceneMode.Single);
    }

    public void loadHowto8Scene()
    {
        SceneManager.LoadScene("How to 8", LoadSceneMode.Single);
    }

    public void loadHowto9Scene()
    {
        SceneManager.LoadScene("How to 9", LoadSceneMode.Single);

    }

    public void loadGame1Scene()
    {
        SceneManager.LoadScene("Game1", LoadSceneMode.Single);
    }

    public void loadGift1Scene()
    {
        SceneManager.LoadScene("Gift1", LoadSceneMode.Single);
    }

     public void loadRoom1Scene()
    {
        SceneManager.LoadScene("Room1", LoadSceneMode.Single);
    }

    public void backtoMainMenu()
    {
        SceneManager.LoadScene("Home", LoadSceneMode.Single);
    }

     

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
