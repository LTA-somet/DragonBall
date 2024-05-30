using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using XXX.UI.Popup;

public class gameState : MonoBehaviour
{

    public static int playerGold = 999999990;
    [SerializeField] TextMeshProUGUI GOLD;
    [SerializeField] GameObject Buypanel;
    [SerializeField] GameObject errpanel;
    [SerializeField] public  GameObject[] p;
    private void Start()
    {
        playerGold = PlayerPrefs.GetInt("gold");
        GOLD.text = "Gold: "+playerGold;
        PlayerPrefs.SetInt("gold", playerGold);
        Buypanel.SetActive(false);
        if (p == null || p.Length <= 0) return;
        for (int i = 0; i < p.Length; i++)
        {
            var panel = p[i];
            if (panel != null)
            {
                
                if (PlayerPrefs.GetInt(panel.name) == 1)
                {
                    panel.active = false;
                }
                else
                {
                    panel.active = true;
                }
            }
        }
    }
    static GameObject panelSelected;
    private void Update()
    {
        GOLD.text = "Gold: " + playerGold;
        if (p == null || p.Length <= 0) return;
        for (int i = 0; i < p.Length; i++)
        {
            var panel = p[i];
            if (panel != null)
            {
                if (PlayerPrefs.GetInt(panel.name) == 1)
                {
                    panel.active = false;
                }
                else
                {
                    panel.active = true;
                }
            }
        }
    }

    public void buy()
    {
        panelSelected= EventSystem.current.currentSelectedGameObject;
        Buypanel.SetActive(true);
    }

    public void YesBtn() {
        if(playerGold >= 50)
        {
            playerGold -= 50;
            PlayerPrefs.SetInt("gold", playerGold);
            Buypanel.SetActive(false);
            PlayerPrefs.SetInt(panelSelected.name, 1);
        }
        else
        {
            errpanel.SetActive(true);
        }
    }
    public void CancelBtn()
    {
        Buypanel.SetActive(false);
        errpanel.SetActive(false);
    }


}
