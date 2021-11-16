using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class codeGUI : MonoBehaviour
{
    public void OnPlay(){
        SceneManager.LoadScene("SampleScene");
    }
    public void OnSet(){
        SceneManager.LoadScene("Setting");
    }
    public void OnInfo(){
        SceneManager.LoadScene("Info");
    }
    public void OnBack(){
        SceneManager.LoadScene("Menu1");
    }
}
