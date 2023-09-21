using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public InputField IdInput;
    public InputField passWordInput;
    public GameObject popUpBox;
    private Button logincloseBtn;


    private string checkId = "1234";
    private string checkPs = "1234";


    void Start()
    {
        logincloseBtn = popUpBox.GetComponentInChildren<Button>();
        logincloseBtn.onClick.AddListener(CloseBtnClick);
    }

    public void LoginClick() 
    {
        string userId = IdInput.text;
        string userPassword = passWordInput.text;

        if (userId == checkId&& userPassword ==checkPs)
        {
            SceneManager.LoadScene("MainScene");
        }
        else 
        {
            ShowPopUpBox();
        }
    }

    void CloseBtnClick()
    {
        popUpBox.SetActive(false);
    }
    public void ShowPopUpBox()
    {
        popUpBox.SetActive(true);
    }
}
