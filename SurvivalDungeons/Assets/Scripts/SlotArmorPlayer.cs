using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotArmorPlayer : MonoBehaviour
{
    #region -- ����� �����
    public GameObject slotHelmet;
    public GameObject slotBib;
    public GameObject slotTrousers;
    public GameObject slotBoots;

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
    private GameObject infoPanel; // ������ ���������� � ��������
    public void MoveToSlotArmor(TypeArmor typeArmor, GameObject itemObject)
    {
        switch(typeArmor)
        {
            case TypeArmor.Helmet:
                if(isSlotHelmet != true)
                {
                    Move(slotHelmet, itemObject);
                    isSlotHelmet = true;
                }
                else
                {
                    // ��������� ����� ������� ����������
                }
                break;
            case TypeArmor.Bib:
                if (isSlotBib != true)
                {
                    Move(slotBib, itemObject);
                    isSlotBib = true;
                }
                else
                {
                    // ��������� ����� ������� ����������
                }
                break;
            case TypeArmor.Trousers:
                if (isSlotTrousers != true)
                {
                    Move(slotTrousers, itemObject);
                    isSlotTrousers = true;
                }
                else
                {
                    // ��������� ����� ������� ����������
                }
                break;
            case TypeArmor.Boots:
                if (isSlotBoots != true)
                {
                    Move(slotBoots, itemObject);
                    isSlotBoots = true;
                }
                else
                {
                    // ��������� ����� ������� ����������
                }
                break;
        }
    }

    private void Move(GameObject slot, GameObject itemObject)
    {
        cloused._ClousePanel(infoPanel); // ��������� ���� ���������� � ��������
        itemObject.transform.SetParent(slot.transform);
        itemObject.transform.position = slot.transform.position;
    }
}
