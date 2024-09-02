using UnityEngine;
using UnityEngine.UI;

public class SelectItemArmor : MonoBehaviour
{
    [SerializeField] 
    public GameObject infoPanel;
    [SerializeField] 
    private Image icon;
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

    public void Start()
    {
        // Тут будем заполнять все нужные данные 
        icon.sprite = iconArmor;
        gameObject.name = nameItem;
        gameObject.GetComponent<Button>().onClick.AddListener(OpenInfoPanel);
    }

    public void OpenInfoPanel()
    {
        infoPanel.SetActive(true);
    }
}
