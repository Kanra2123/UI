using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class cooldown_anim : MonoBehaviour
{
    [SerializeField] private Image image;
    public void StartCooldown()
    {
        image.DOKill();
        image.fillAmount = 1;
        image.DOFillAmount(0f, 2f);
    }
}
