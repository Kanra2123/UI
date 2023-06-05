using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class controller : MonoBehaviour
{
    [SerializeField] private List <Button> buttons;
    [SerializeField] private List <Sprite> monk;
    [SerializeField] private List <Sprite> demonHunter;
    [SerializeField] private List <Sprite> barbarian;

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void setMonkSkills()
    {
        UpdateSkills(monk);
    }
    public void setDHSkills()
    {
        UpdateSkills(demonHunter);
    }
    public void setBarbarianSkills()
    {
        UpdateSkills(barbarian);
    }

    private void UpdateSkills (List <Sprite> skillImages)
    {
        for (int i= 0; i < buttons.Count; i++)
        {
            buttons[i].GetComponent<Image>().sprite = skillImages[i];
        }
    }
}