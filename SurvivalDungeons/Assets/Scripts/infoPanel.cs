using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class infoPanel : MonoBehaviour
{
    public GameObject buttunAction;
    public GameObject butunPurches;

    [SerializeField] private Transform inventory;

    public SlotArmorPlayer slotArmorPlayer;
    private void OnEnable()
    {
        SelectItemArmor.isOpenInfoPanel += ButtonParametrs;
    }

    private void OnDisable()
    {
        SelectItemArmor.isOpenInfoPanel -= ButtonParametrs;
    }

    private void ButtonParametrs(bool isEquipped, TypeArmor typeArmor, GameObject itemObject)
    {
        Button Action;
        TextMeshProUGUI textAction;

        textAction = buttunAction.GetComponentInChildren<TextMeshProUGUI>();

        Action = buttunAction.GetComponent<Button>();
        Action.onClick.RemoveAllListeners();

        if (isEquipped == true)
        {
            Debug.Log("Снял экип");

            textAction.text = "Снять";

            Action.onClick.AddListener(() =>
            slotArmorPlayer.RemoveToInventory(typeArmor, itemObject.transform, inventory));
        }
        else
        {
            Debug.Log("Одел экип");

            textAction.text = "Одеть";

            Action.onClick.AddListener(() => slotArmorPlayer.MoveToSlotArmor(typeArmor, itemObject));
        }
    }
}
