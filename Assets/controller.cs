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
    [SerializeField] private Image hpFill;
    [SerializeField] private Image xpFill;
    [SerializeField] private Image manaFill;
    [SerializeField] private float healAmount = 10;
    [SerializeField] private float dmgAmount = -10;
    [SerializeField] private float addManaAmount = 10;
    [SerializeField] private float subManaAmount = -10;
    [SerializeField] private float addXpAmount = 10;
    [SerializeField] private float subXpAmount = -10;

    public void addHP()
    {
        changeFill(healAmount, hpFill);
    }
    public void subHP()
    {
        changeFill(dmgAmount, hpFill);
    }
    public void addMana()
    {
        changeFill(addManaAmount, manaFill);
    }
    public void subMana()
    {
        changeFill(subManaAmount, manaFill);
    }
    public void addXp()
    {
        changeFill(addXpAmount, xpFill);
    }
    public void subXp()
    {
        changeFill(subXpAmount, xpFill);
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

    private void changeFill(float number, Image fill)
    {
        if ((fill.fillAmount + (number / 100)) >= 0 && (fill.fillAmount + (number / 100)) <= 100)
        {
            fill.fillAmount += number / 100;
        }
        else if ((hpFill.fillAmount + (number / 100)) < 0)
        {
            fill.fillAmount = 0;
        }
        else if ((fill.fillAmount + (number / 100)) > 100)
        {
            fill.fillAmount = 1;
        }
    }

    private void UpdateSkills (List <Sprite> skillImages)
    {
        for (int i= 0; i < buttons.Count; i++)
        {
            buttons[i].GetComponent<Image>().sprite = skillImages[i];
        }
    }
}