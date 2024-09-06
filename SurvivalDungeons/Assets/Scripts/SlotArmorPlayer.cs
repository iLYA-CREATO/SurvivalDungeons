using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotArmorPlayer : MonoBehaviour
{
    #region -- Слоты брони
    public GameObject slotHelmet;
    public GameObject slotBib;
    public GameObject slotTrousers;
    public GameObject slotBoots;


    public GameObject inventory;

    public bool isSlotHelmet;
    public bool isSlotBib;
    public bool isSlotTrousers;
    public bool isSlotBoots;
    #endregion


    [SerializeField]
    [Header("C#")]
    private Cloused cloused;

    [SerializeField]
    [Header("C#")]
    private GameObject infoPanel; // Панель информации о карточке
    public void MoveToSlotArmor(TypeArmor typeArmor, GameObject itemObject)
    {
        switch(typeArmor)
        {
            case TypeArmor.Helmet:
                if(isSlotHelmet != true)
                {
                    MoveToCell(slotHelmet, itemObject, true);
                    isSlotHelmet = true;
                }
                else
                {
                    // Реалицаия смены местами экипировки
                }
                break;
            case TypeArmor.Bib:
                if (isSlotBib != true)
                {
                    MoveToCell(slotBib, itemObject, true);
                    isSlotBib = true;
                }
                else
                {
                    // Реалицаия смены местами экипировки
                }
                break;
            case TypeArmor.Trousers:
                if (isSlotTrousers != true)
                {
                    MoveToCell(slotTrousers, itemObject, true);
                    isSlotTrousers = true;
                }
                else
                {
                    // Реалицаия смены местами экипировки
                }
                break;
            case TypeArmor.Boots:
                if (isSlotBoots != true)
                {
                    MoveToCell(slotBoots, itemObject, true);
                    isSlotBoots = true;
                }
                else
                {
                    // Реалицаия смены местами экипировки
                }
                break;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="slot">Куда</param>
    /// <param name="itemObject">Откуда и что</param>
    private void MoveToCell(GameObject slot, GameObject itemObject, bool isBool)
    {
        cloused._ClousePanel(infoPanel); // Закрываем окно информации о карточке

        itemObject.transform.SetParent(slot.transform);
        itemObject.transform.position = slot.transform.position;

        GetParametrs(itemObject, isBool);
    }
    public void RemoveToInventory(TypeArmor typeArmor, Transform item, Transform inventory)
    {
        cloused._ClousePanel(infoPanel); // Закрываем окно информации о карточке
        

        switch (typeArmor)
        {
            case TypeArmor.Helmet:
                if (isSlotHelmet == true)
                {
                    item.SetParent(inventory);
                    item.position = inventory.position;

                    GetParametrs(item.gameObject, false);
                    isSlotHelmet = false;
                }
                break;
            case TypeArmor.Bib:
                if (isSlotBib == true)
                {
                    item.SetParent(inventory);
                    item.position = inventory.position;

                    GetParametrs(item.gameObject, false);
                    isSlotBib = false;
                }
                break;
            case TypeArmor.Trousers:
                if (isSlotTrousers == true)
                {
                    item.SetParent(inventory);
                    item.position = inventory.position;

                    GetParametrs(item.gameObject, false);
                    isSlotTrousers = false;
                }
                break;
            case TypeArmor.Boots:
                if (isSlotBoots == true)
                {
                    item.SetParent(inventory);
                    item.position = inventory.position;

                    GetParametrs(item.gameObject, false);
                    isSlotBoots = false;
                }
                break;
        }
    }

    public void GetParametrs(GameObject itemObject, bool isBool)
    {
        itemObject.GetComponent<SelectItemArmor>().dataItem.isEquipped = isBool;
        itemObject.GetComponent<SelectItemArmor>().isEquipped = isBool;
    }




    private void MoveToChange()
    {

    }
}
