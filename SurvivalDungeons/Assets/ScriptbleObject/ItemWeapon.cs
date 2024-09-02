using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ItemWeapon", menuName = "ScriptableObjects/ItemWeapon")]
public class ItemWeapon : ScriptableObject
{
    [Header("Иконка:")] public Sprite iconArmor;

    [Header("Тип редкости:")] public TypeRarity typeRarity;

    [Header("Название:")] public string nameItem;

    [Header("Стоиость продажи:")] public int pricePurchase;
    [Header("Стоиость продажи:")] public int priceSale;
    [Header("Кол-во брони:")]public int protection;

    [Header("Возможность продать:")] public bool isSell;
    [Header("Экипирован:")] public bool isEquipped;
}
