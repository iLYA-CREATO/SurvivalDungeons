using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPlayer : MonoBehaviour
{
    // ��� ��������� � ��� ��� �� �������� ������� ������� � ������� ������ ����� ��������
    public static event Action<DataItem> OnInventoryAddView;

    [SerializeField]
    [Header("��� Item ������� ���� � ������")]
    private List<DataItem> dataItem;


    private void OnEnable()
    {
        AddItem.OnAddItem += AddItemInventory;
    }

    private void OnDisable()
    {
        AddItem.OnAddItem -= AddItemInventory;
    }


    // ����� ��� ���������� Item � ���������
    private void AddItemInventory(ItemArmor _itemArmor)
    {

        //  ������ ��������� ������ Item � ��������� ��� �������
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

        // � ��� ��� ��� ��������� � �� ������
        dataItem.Add(newItem);
        // �������� ���������� ��� ���-�� ���������� 
        OnInventoryAddView?.Invoke(newItem);
    }
}


[Serializable]
public class DataItem
{
    [Header("��� Item:")] public ItemArmor itemArmor;

    [Header("������:")] public Sprite iconArmor;

    [Header("��� ��������:")] public TypeRarity typeRarity;
    [Header("��� �����:")] public TypeArmor typeArmor;

    [Header("��������:")] public string nameItem;

    [Header("�������� �������:")] public int pricePurchase;
    [Header("�������� �������:")] public int priceSale;
    [Header("���-�� �����:")] public int protection;

    [Header("����������� �������:")] public bool isSell;
    [Header("����������:")] public bool isEquipped;
}
