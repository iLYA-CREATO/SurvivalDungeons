using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� ������ ������ ��� ������ ��� ����
/// </summary>
[CreateAssetMenu(fileName = "FullItem", menuName = "ScriptableObjects/FullItem")]
public class FullItem : ScriptableObject
{
    [Header("��� �������� �����")] public List<ItemArmor> allItemArmors;
}
