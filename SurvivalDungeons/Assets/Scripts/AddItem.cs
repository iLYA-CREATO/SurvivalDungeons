using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{
    public static event Action<ItemArmor> OnAddItem;
    public ItemArmor itemArmor;

    public ItemArmor[] itemArmorMass;
    public void Start()
    {
        for(int i = 0; i < itemArmorMass.Length; i++)
        {
            OnAddItem?.Invoke(itemArmorMass[i]);
        }
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            OnAddItem?.Invoke(itemArmor);
        }
    }
}
