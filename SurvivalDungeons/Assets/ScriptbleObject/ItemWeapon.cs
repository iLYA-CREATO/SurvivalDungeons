using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ItemWeapon", menuName = "ScriptableObjects/ItemWeapon")]
public class ItemWeapon : ScriptableObject
{
    [Header("������:")] public Sprite iconArmor;

    [Header("��� ��������:")] public TypeRarity typeRarity;

    [Header("��������:")] public string nameItem;

    [Header("�������� �������:")] public int pricePurchase;
    [Header("�������� �������:")] public int priceSale;
    [Header("���-�� �����:")]public int protection;

    [Header("����������� �������:")] public bool isSell;
    [Header("����������:")] public bool isEquipped;
}
