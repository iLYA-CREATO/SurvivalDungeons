using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPlayer : MonoBehaviour
{
    // Это сообщение о том что мы добавили какойто предмет и передаём данные этого предмета
    public static event Action<DataItem> OnInventoryAddView;

    [SerializeField]
    [Header("Все Item которые есть у игрока")]
    private List<DataItem> dataItem;


    private void OnEnable()
    {
        AddItem.OnAddItem += AddItemInventory;
    }

    private void OnDisable()
    {
        AddItem.OnAddItem -= AddItemInventory;
    }


    // Метод для добавления Item в инвентарь
    private void AddItemInventory(ItemArmor _itemArmor)
    {

        //  Создаём экземпляр нового Item и заполняем его данными
        DataItem newItem = new DataItem()
        { 
            itemArmor = _itemArmor,
            iconArmor = _itemArmor.iconArmor,
            typeRarity = _itemArmor.typeRarity,
            typeArmor = _itemArmor.typeArmor,
            nameItem = _itemArmor.nameItem,
            pricePurchase = _itemArmor.pricePurchase,
            priceSale = _itemArmor.priceSale,
            protection = _itemArmor.protection,
            isSell = _itemArmor.isSell,
            isEquipped = _itemArmor.isEquipped
        };

        // А вот тут уже добавляем в на список
        dataItem.Add(newItem);
        // Сообщяем слушителям что что-то изменилось 
        OnInventoryAddView?.Invoke(newItem);
    }
}


[Serializable]
public class DataItem
{
    [Header("Сам Item:")] public ItemArmor itemArmor;

    [Header("Иконка:")] public Sprite iconArmor;

    [Header("Тип редкости:")] public TypeRarity typeRarity;
    [Header("Тип брони:")] public TypeArmor typeArmor;

    [Header("Название:")] public string nameItem;

    [Header("Стоиость продажи:")] public int pricePurchase;
    [Header("Стоиость продажи:")] public int priceSale;
    [Header("Кол-во брони:")] public int protection;

    [Header("Возможность продать:")] public bool isSell;
    [Header("Экипирован:")] public bool isEquipped;
}
