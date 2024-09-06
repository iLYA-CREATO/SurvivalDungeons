using System;
using UnityEngine;
using UnityEngine.UI;

public class SelectItemArmor : MonoBehaviour
{
    public static event Action<bool, TypeArmor, GameObject> isOpenInfoPanel;
    [SerializeField] 
    public GameObject infoPanel;
    [SerializeField] 
    private Image icon;

    #region -- Данные которые можем получить из карточки

    public DataItem dataItem;
    public GameObject itemObject;
    [Header("Сам Item:")] public ItemArmor itemArmor;

    [Header("Иконка:")] public Sprite iconArmor;

    [Header("Тип редкости:")] public TypeRarity typeRarity;
    [Header("Тип брони:")] public TypeArmor typeArmor;

    [Header("Название:")] public string nameItem;

    [Header("Стоиость продажи:")] public int pricePurchase;
    [Header("Стоиость продажи:")] public int priceSale;
    [Header("Кол-во брони:")] public int protection;

    [Header("Возможность продать:")] public bool isSell;

    [Header("Экипирован:")] public bool isEquipped;
    #endregion
    public void Start()
    {
        FillCard();
    }
    private void FillCard()
    {
        // Тут будем заполнять все нужные данные 
        itemObject = gameObject; // Заполняем сами собой
        icon.sprite = iconArmor;
        gameObject.name = nameItem;

        // Добавим стартовую возможность для открытия первой информационной панели
        gameObject.GetComponent<Button>().onClick.AddListener(OpenInfoPanel);
    }
    public void OpenInfoPanel()
    {
        infoPanel.SetActive(true);
        isOpenInfoPanel?.Invoke(isEquipped, typeArmor, itemObject); // Сразу передаем даные одета ли броня
    }
}
