using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpBox;
    //public Animator animator;
    public TMP_Text popUpText;
    public void Start()
    {
       popUpBox.SetActive(false); 
    }
    
    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        popUpText.text = text;
        
    }
    public void close()
    {
        popUpBox.SetActive(false);
    }
    
}
