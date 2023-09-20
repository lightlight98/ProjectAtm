using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deposit : MonoBehaviour
{
    [SerializeField] private Text totaltxt;
    [SerializeField] private Text CashInHand;
    [SerializeField] private InputField InputMoney;

    public Button button1;
    public Button button3;
    public Button button5;

    private int cash;
    private int banlance;

    void Start()
    {
 
        button1.onClick.AddListener(Click10000);
        button3.onClick.AddListener(Click30000);
        button5.onClick.AddListener(Click50000);
        
    }
    private void OnEnable()
    {
        cash = GameManager.Instance.Cash;
        banlance = GameManager.Instance.Banlance;

        UpdateMoney();
    }

    public void Input() 
    {
        int depositAmount = int.Parse(InputMoney.text);

        if (depositAmount <= cash)
        {
            cash -= depositAmount;
            banlance += depositAmount;


        }
        else 
        {
            Debug.Log("입금 할 금액이 소지금액보다 큽니다.");
        }
        InputMoney.text = "";

        UpdateMoney();
    }

    public void ButtonCliek(int amount) 
    {
        if (amount <= cash)
        {
            cash -= amount;
            banlance += amount;
        }
        else 
        {
            Debug.Log("차감할 금액이 소지금액보다 큽니다.");
        }

        UpdateMoney();

    }
    private void UpdateMoney()
    {
        GameManager.Instance.Cash = cash;
        GameManager.Instance.Banlance = banlance;
    }
    void Click10000() 
    {
        ButtonCliek(10000);
    }
    void Click30000()
    {
        ButtonCliek(30000);
    }
    void Click50000()
    {
        ButtonCliek(50000);
    }

}

