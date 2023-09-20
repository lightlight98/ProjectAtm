using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DWSetActive : MonoBehaviour
{

    public GameObject dwButton;

    public GameObject deposit;
    public GameObject withdraw;

    public Button withdrawBtn;
    public Button depositBtn;



    void Start()
    {
        depositBtn.onClick.AddListener(depositBunClick);
        withdrawBtn.onClick.AddListener(withDrawClick);
    }
  

    public void depositBunClick() 
    {
        dwButton.SetActive(false);
        deposit.SetActive(true);

    }
    public void withDrawClick() 
    {
        dwButton.SetActive(false);
        withdraw.SetActive(true);
    }
}
