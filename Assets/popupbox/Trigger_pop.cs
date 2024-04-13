using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_pop : MonoBehaviour
{
    public string popUp;

    private void OnTriggerEnter(Collider other)
    {
        Color randomlySelectedColor = GetRandomColor();
        GetComponent<Renderer>().material.color = randomlySelectedColor;
        PopUpSystem pop = GameObject.FindGameObjectWithTag("UI").GetComponent<PopUpSystem>();
        pop.PopUp(popUp);
    }
    private void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.color = new Color(0,0,0);
        PopUpSystem pop = GameObject.FindGameObjectWithTag("UI").GetComponent<PopUpSystem>();
        pop.close();
    }
    private Color GetRandomColor()
    {
        return new Color(
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f));
    }
    /*
    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();
            pop.PopUp(popUp);
        }
    }
    */
}
