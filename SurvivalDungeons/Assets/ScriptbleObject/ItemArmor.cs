using UnityEngine;

[CreateAssetMenu(fileName = "ItemArmor", menuName = "ScriptableObjects/ItemArmor")]
public class ItemArmor : ScriptableObject
{
    [Header("Иконка")] public Sprite iconArmor;

    [Header("Тип редкости")] public TypeRarity typeRarity;

    [Header("Название")] public string nameArmor;

    [Header("Стоиость продажи")] public int pricePurchase;
    [Header("Стоиость продажи")] public int priceSale;
    [Header("Кол-во брони")]public int protection;
}
