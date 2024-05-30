using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class guidelineController : MonoBehaviour
{
    public static int indexChara { get; set; }
    private static guidelineController instance;

    public static guidelineController GetIntance()
    {
        return instance;
    }

    private guidelineController()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    

    // Update is called once per frame
    void Update()
    {

    }

   

    public GameObject bgLoading;
    public GameObject canvas;

    private IEnumerator Loading()
    {
        canvas.SetActive(false);
        bgLoading.gameObject.SetActive(true);
        for (float i = 0; i < 1f; i += 0.3f)
        {
            var colorTemp = bgLoading.GetComponent<SpriteRenderer>().color;
            colorTemp.a = i;
            bgLoading.GetComponent<SpriteRenderer>().color = colorTemp;
            yield return new WaitForSeconds(0.1f);
        }
        //bgLoading.gameObject.SetActive (false);
    }

   
    public void backYoMenuBTN()
    {
        canvas.SetActive(false);
        bgLoading.SetActive(false);
        SceneManager.LoadSceneAsync("Menu");
    }
}
