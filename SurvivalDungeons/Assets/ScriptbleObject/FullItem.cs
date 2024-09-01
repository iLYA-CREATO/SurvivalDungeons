using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Этот скрипт хранит все данные для игры
/// </summary>
[CreateAssetMenu(fileName = "FullItem", menuName = "ScriptableObjects/FullItem")]
public class FullItem : ScriptableObject
{
    [Header("Все предметы брони")] public List<ItemArmor> allItemArmors;
}
