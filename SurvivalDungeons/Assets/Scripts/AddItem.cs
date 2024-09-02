using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{
    public static event Action<ItemArmor> OnAddItem;
    public ItemArmor itemArmor;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            OnAddItem?.Invoke(itemArmor);
        }
    }
}
