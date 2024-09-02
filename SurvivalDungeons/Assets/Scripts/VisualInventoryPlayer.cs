using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� ������ ������������ ���������� ����� �������� Item
/// </summary>
public class VisualInventoryPlayer : MonoBehaviour
{
    public GameObject infoPanel;

    public GameObject prefabItemImage;

    public Transform spavnTransform;

    public GameObject ItemCellBuffer;

    private void OnEnable()
    {
        InventoryPlayer.OnInventoryAddView += CreateItemImage;
    }

    private void OnDisable()
    {
        InventoryPlayer.OnInventoryAddView -= CreateItemImage;
    }
    private void CreateItemImage(DataItem dataItem)
    {
        // ����� ������ Item � ���������� ��� � �������� ����������
        ItemCellBuffer = Instantiate(prefabItemImage, spavnTransform.transform);

        // �������� ������ �������� ������� ����� ������� ������
        SelectItemArmor selectItemArmor;
        selectItemArmor = ItemCellBuffer.GetComponent<SelectItemArmor>();

        // ��������� ������ ������
        selectItemArmor.typeArmor = dataItem.typeArmor;
        selectItemArmor.itemArmor = dataItem.itemArmor;
        selectItemArmor.iconArmor = dataItem.iconArmor;
        selectItemArmor.nameItem = dataItem.nameItem;
        selectItemArmor.isEquipped = dataItem.isEquipped;
        selectItemArmor.infoPanel = infoPanel;
    }


}
