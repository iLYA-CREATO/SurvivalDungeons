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

    #region -- ������ ������� ����� �������� �� ��������

    public DataItem dataItem;
    public GameObject itemObject;
    [Header("��� Item:")] public ItemArmor itemArmor;

    [Header("������:")] public Sprite iconArmor;

    [Header("��� ��������:")] public TypeRarity typeRarity;
    [Header("��� �����:")] public TypeArmor typeArmor;

    [Header("��������:")] public string nameItem;

    [Header("�������� �������:")] public int pricePurchase;
    [Header("�������� �������:")] public int priceSale;
    [Header("���-�� �����:")] public int protection;

    [Header("����������� �������:")] public bool isSell;

    [Header("����������:")] public bool isEquipped;
    #endregion
    public void Start()
    {
        FillCard();
    }
    private void FillCard()
    {
        // ��� ����� ��������� ��� ������ ������ 
        itemObject = gameObject; // ��������� ���� �����
        icon.sprite = iconArmor;
        gameObject.name = nameItem;

        // ������� ��������� ����������� ��� �������� ������ �������������� ������
        gameObject.GetComponent<Button>().onClick.AddListener(OpenInfoPanel);
    }
    public void OpenInfoPanel()
    {
        infoPanel.SetActive(true);
        isOpenInfoPanel?.Invoke(isEquipped, typeArmor, itemObject); // ����� �������� ����� ����� �� �����
    }
}
