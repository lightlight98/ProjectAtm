using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private Text totalMoney;
    [SerializeField] private Text cashInHand;
    [SerializeField] private GameObject popUpBox;
    [SerializeField] private Button closeBtn;

    public int Cash { get;  set; }
    public int Banlance { get;  set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else 
        {
            Destroy(gameObject);
        }

        Cash = 100000;
        Banlance = 50000;
    }
    // Start is called before the first frame update
    void Start()
    {
        closeBtn = popUpBox.GetComponentInChildren<Button>();
        closeBtn.onClick.AddListener(CloseBtnClick);
    }
    void CloseBtnClick() 
    {
        popUpBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {     
        cashInHand.text = Cash.ToString("N0");
        totalMoney.text = Banlance.ToString("N0");
    }

    public void ShowPopUpBox()
    {
        popUpBox.SetActive(true);
    }
}
