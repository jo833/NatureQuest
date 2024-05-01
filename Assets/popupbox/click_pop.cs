using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;
public class click_pop : MonoBehaviour
{
    public string popUp;
    private GameObject popbox;
    private void Start()
    {
        popbox = GameObject.Find("VR Tracked Canvas");
    }
    public void startpop()
    {
        Color randomlySelectedColor = GetRandomColor();
        GetComponent<Renderer>().material.color = randomlySelectedColor;
        //PopUpSystem pop = 
        popbox.GetComponent<TextMeshPro>().text = popUp;
        popbox.SetActive(true);
        //pop.PopUp(popUp);
    }
    public void endpop()
    {
        GetComponent<Renderer>().material.color = new Color(0,0,0);
        popbox.SetActive(false);
        //PopUpSystem pop = GameObject.FindGameObjectWithTag("UI").GetComponent<PopUpSystem>();
        //pop.close();
    }
    private Color GetRandomColor()
    {
        return new Color(
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f));
    }
}
