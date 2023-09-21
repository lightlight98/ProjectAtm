using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Withdraw : MonoBehaviour
{

    [SerializeField] private Text totaltxt;
    [SerializeField] private Text CashInHand;
    [SerializeField] private InputField OutputMoney;

    public Button button1;
    public Button button3;
    public Button button5;

    private int cash;
    private int banlance;

    // Start is called before the first frame update
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

    public void Output()
    {
        int withdrawAmount = int.Parse(OutputMoney.text);


        if (withdrawAmount <= banlance)
        {
            banlance -= withdrawAmount;
            cash += withdrawAmount;

        }
        else
        {
            GameManager.Instance.ShowPopUpBox();
        }
        OutputMoney.text = "";

        UpdateMoney();

    }
    public void ButtonCliek(int amount) 
    {
        if (amount <= banlance)
        {
            banlance -= amount;
            cash += amount;
        }
        else
        {
            GameManager.Instance.ShowPopUpBox();
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
