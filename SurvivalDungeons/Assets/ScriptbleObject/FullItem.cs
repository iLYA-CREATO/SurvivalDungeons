using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� ������ ������ ��� ������ ��� ����
/// </summary>
[CreateAssetMenu(fileName = "FullItem", menuName = "ScriptableObjects/FullItem")]
public class FullItem : ScriptableObject
{
    
    [Header("�����")] public List<ItemArmor> ItemArmorsHelmet;
    [Header("����������")] public List<ItemArmor> ItemArmorsBib;
    [Header("�����")] public List<ItemArmor> ItemArmorsTrousers;
    [Header("�������")] public List<ItemArmor> ItemArmorsBoots;
}
