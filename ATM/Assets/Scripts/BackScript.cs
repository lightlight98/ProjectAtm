using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackScript : MonoBehaviour
{
    public Button backButton;
    public GameObject deposit;
    public GameObject withdraw;
    public GameObject dwButton;
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(BackButtonClick);
        
    }

    public void BackButtonClick() 
    {
        deposit.SetActive(false);
        withdraw.SetActive(false);
        dwButton.SetActive(true);
    }
 
}
