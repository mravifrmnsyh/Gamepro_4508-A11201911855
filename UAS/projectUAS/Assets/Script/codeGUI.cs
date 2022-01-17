using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class codeGUI : MonoBehaviour
{
    public static Button Lv1,Lv2,Lv3;

    void Start(){
        // membuat try catch untuk kondisi level
        try {
            ambilButton();
            int statLv = ambilLevel();
            switch (statLv){
                case 0:
                    Lv1.interactable = true;
                    break;
                case 1:
                    Lv1.interactable = true;
                    Lv2.interactable = true;
                    break;
                case 2:
                    Lv1.interactable = true;
                    Lv2.interactable = true;
                    Lv3.interactable = true;
                    break;
            }
        }
        catch (NullReferenceException e){

        }
    }

    public void OnPlay(){
        SceneManager.LoadScene("Level1");
    }
    public void OnPlay2(){
        SceneManager.LoadScene("Level2");
    }
    public void OnPlay3(){
        SceneManager.LoadScene("Level3");
    }
    public void OnMasuk(){
        SceneManager.LoadScene("Menu2");
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
    public void OnBack2(){
        SceneManager.LoadScene("Menu2");
    }
    public void OnReset(){
        // mengeset kembali key score setiap level menjadi 0
        PlayerPrefs.SetInt("highscoreLv1", 0);
        PlayerPrefs.SetInt("highscoreLv2", 0);
        PlayerPrefs.SetInt("highscoreLv3", 0);
        simpanLevel(0);
        OnMasuk();
    }
    public static int ambilLevel(){
        int lv=0;
        if (!PlayerPrefs.HasKey("level")){
            PlayerPrefs.SetInt("level", 0);
        } else{
            lv = PlayerPrefs.GetInt("level");
        }
        return lv;
    }

    public static void simpanLevel(int lv){
        if (!PlayerPrefs.HasKey("level")){
            PlayerPrefs.SetInt("level", 0);
        } else{
            PlayerPrefs.SetInt("level", lv);
        }
    }

    void ambilButton(){
        // menginisialisasi setiap variable dengan menemukan nama dikomponen button
        Lv1 = GameObject.Find("btnPlayLv1").GetComponent<Button>();
        Lv2 = GameObject.Find("btnPlayLv2").GetComponent<Button>();
        Lv3 = GameObject.Find("btnPlayLv3").GetComponent<Button>();
        Lv1.interactable = Lv2.interactable = Lv3.interactable = false;
    }
    public static bool getLv2(){
        if(Lv2.interactable==true){
            return true;
        } else{
            return false;
        }
    }
    public static bool getLv3(){
        if(Lv3.interactable==true){
            return true;
        } else{
            return false;
        }
    }
}
