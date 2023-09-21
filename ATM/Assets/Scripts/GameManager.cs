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
    [SerializeField] private Button closeButton;

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
        closeButton.onClick.AddListener(CloseBtnClick);
    }
    void CloseBtnClick() 
    {
        popUpBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {     
        cashInHand.text = Cash.ToString();
        totalMoney.text = Banlance.ToString();
    }

    public void ShowPopupBox()
    {
        popUpBox.SetActive(true);
    }
}
