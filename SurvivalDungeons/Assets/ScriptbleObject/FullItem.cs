using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Этот скрипт хранит все данные для игры
/// </summary>
[CreateAssetMenu(fileName = "FullItem", menuName = "ScriptableObjects/FullItem")]
public class FullItem : ScriptableObject
{
    
    [Header("Шлемы")] public List<ItemArmor> ItemArmorsHelmet;
    [Header("Нагрудники")] public List<ItemArmor> ItemArmorsBib;
    [Header("Штаны")] public List<ItemArmor> ItemArmorsTrousers;
    [Header("Ботинки")] public List<ItemArmor> ItemArmorsBoots;
}
