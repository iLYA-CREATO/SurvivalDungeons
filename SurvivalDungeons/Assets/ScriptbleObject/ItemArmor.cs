using UnityEngine;

[CreateAssetMenu(fileName = "ItemArmor", menuName = "ScriptableObjects/ItemArmor")]
public class ItemArmor : ScriptableObject
{
    [Header("������")] public Sprite iconArmor;

    [Header("��� ��������")] public TypeRarity typeRarity;

    [Header("��������")] public string nameArmor;

    [Header("�������� �������")] public int pricePurchase;
    [Header("�������� �������")] public int priceSale;
    [Header("���-�� �����")]public int protection;
}
