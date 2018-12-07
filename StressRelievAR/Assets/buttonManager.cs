using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.Receivers;
using HoloToolkit.Unity.InputModule;


public class buttonManager : InteractionReceiver
{
    private string[] AllTags = { "Food", "Porcelain", "Explosive", "BrokenPieces" };

    private void Start()
    {
        
    }
    public void turnOffVisibility(string objTag)
    {
        GameObject[] allObjWithTag = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject obj in allObjWithTag)
        {//could make a destroy object version of this
            obj.SetActive(false);
        }
    }

    public void turnOnVisibility(string OnObjTag)
    {
        foreach(string tag in AllTags){
            GameObject[] allObjWithTag = GameObject.FindGameObjectsWithTag(tag);
            foreach(GameObject obj in allObjWithTag)
            {
                if (Equals(tag, OnObjTag))
                {
                    obj.SetActive(true);
                } else
                {
                    obj.SetActive(false);
                }
            }
            
        }
    }
    protected override void InputDown(GameObject obj, InputEventData eventData)
    {
        Debug.Log(obj.name + "Input Down!");

        switch (obj.name)
        {
            case "PorcelainMode":
                turnOnVisibility("Porcelain");
                break;

            case "button2":
                turnOnVisibility("Food");
                turnOffVisibility("BrokenPieces"); 
                break;

            case "button3":
                turnOnVisibility("Explosive");
                turnOffVisibility("BrokenPieces");
                break;
        }
    }
}
