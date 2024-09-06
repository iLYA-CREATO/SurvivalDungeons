using UnityEngine;

[CreateAssetMenu(fileName = "ItemArmor", menuName = "ScriptableObjects/ItemArmor")]
public class ItemArmor : ScriptableObject
{
    [Header("Иконка:")] public Sprite iconArmor;

    [Header("Тип редкости:")] public TypeRarity typeRarity;

    [Header("Тип брони:")] public TypeArmor typeArmor;

    [Header("Название:")] public string nameItem;

    [Header("Стоиость покупки:")] public int pricePurchase;
    [Header("Стоиость продажи:")] public int priceSale;
    [Header("Кол-во брони:")]public int protection;

    [Header("Возможность продать:")] public bool isSell;
    [Header("Экипирован:")] public bool isEquipped;
}
