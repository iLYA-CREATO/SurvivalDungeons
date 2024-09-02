using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Этот скрипт обрабатывает визуальную часть создания Item
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
        // Сразу создаём Item и закидываем его в буферную переменную
        ItemCellBuffer = Instantiate(prefabItemImage, spavnTransform.transform);

        // Получаем скрипт карточки которыя будет хранить данные
        SelectItemArmor selectItemArmor;
        selectItemArmor = ItemCellBuffer.GetComponent<SelectItemArmor>();

        // заполняем нужные данные
        selectItemArmor.typeArmor = dataItem.typeArmor;
        selectItemArmor.itemArmor = dataItem.itemArmor;
        selectItemArmor.iconArmor = dataItem.iconArmor;
        selectItemArmor.nameItem = dataItem.nameItem;
        selectItemArmor.isEquipped = dataItem.isEquipped;
        selectItemArmor.infoPanel = infoPanel;
    }


}
