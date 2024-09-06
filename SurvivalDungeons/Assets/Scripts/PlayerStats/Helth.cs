using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Helth : MonoBehaviour, IHelth, IViewHelth
{

    [SerializeField] private TextMeshProUGUI textHelth;


    private int helth;

    private int maxHelth = 100;

    public void Start()
    {
        helth = maxHelth;
        ViewHelth(helth);
    }

    public void Damage(int damage)
    {
        if(helth > damage)
        {
            helth -= damage;
        }
        else if(helth < damage)
        {
            helth = 0;
            
        }
        ViewHelth(helth);
    }

    public void Regen(int regen)
    {
        if(helth < maxHelth) 
        {
            helth = maxHelth;
        }
        ViewHelth(helth);
    }

    public void ViewHelth(int helth)
    {
        textHelth.text = helth.ToString();
    }
}
