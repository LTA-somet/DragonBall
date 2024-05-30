using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XXX.UI.Popup;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class PopupBuy : BasePopup
{

    public UnityEngine.UI.Button buy;
    public UnityEngine.UI.Button cancel;

    
    public override void Initialized(object data = null)
    {
        Time.timeScale = 0;
        base.Initialized(data);
        cancel.onClick.RemoveAllListeners();
        cancel.onClick.AddListener(OnClickCancel);
        buy.onClick.RemoveAllListeners();
        buy.onClick.AddListener(OnClickBuy);

    }
    private void OnClickCancel()
    {
        Close();
        Time.timeScale = 1;
    }
    private void OnClickBuy()
    {
        if(gameState.playerGold >= 50)
        {
            gameState.playerGold -= 50;
            
        }
        Close();
        Time.timeScale = 1;
    }
}
