using System.Collections;
using TMPro;
using UnityEngine;

namespace Lesson03.Tasks
{
    public enum ItemType
    {
        Weapon,
        Armor,
        Consumable,
        Key,
        Treasure
    }

    public class InventoryManager : MonoBehaviour
    {
        public TMP_Text _inventoryDisplay;
        public int maxInventorySize = 20;

        public string[] itemNames = {
            "Sword", "Shield", "Health Potion", "Magic Key", "Gold Coin",
            "Bow", "Helmet", "Mana Potion", "Silver Key", "Diamond"
        };

        public ItemType[] itemTypes = {
            ItemType.Weapon, ItemType.Armor, ItemType.Consumable, ItemType.Key, ItemType.Treasure,
            ItemType.Weapon, ItemType.Armor, ItemType.Consumable, ItemType.Key, ItemType.Treasure
        };

        public string[] inventory = new string[20];
        public int[] itemQuantities = new int[20];
        private int currentInventorySize = 0;

        private void Start()
        {
            AddItem("Health Potion", 5);
            AddItem("Sword", 1);
            AddItem("Gold Coin", 10);
            UpdateInventoryDisplay();
        }

        public void AddItem(string itemName, int quantity)
        {
            for (int i = 0; i < currentInventorySize; i++)
            {
                if (inventory[i] == itemName)
                {
                    itemQuantities[i] += quantity;
                    UpdateInventoryDisplay();
                    return;
                }
            }
            if (currentInventorySize < maxInventorySize)
            {
                inventory[currentInventorySize] = itemName;
                itemQuantities[currentInventorySize] = quantity;
                currentInventorySize++;
                UpdateInventoryDisplay();
            }
            else
            {
                Debug.Log("Inventory is full!");
            }
        }

        private void UpdateInventoryDisplay()
        {
            _inventoryDisplay.text = "";
            for (int i = 0; i < currentInventorySize; i++)
            {
                _inventoryDisplay.text += $"{inventory[i]} x{itemQuantities[i]}\n";
            }
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.I))
            {
                AddRandomItem();
            }

            if(Input.GetKeyDown(KeyCode.E))
            {
                EquipItem();
            }

            if(Input.GetKeyDown(KeyCode.U))
            {
                UseItem();
            }
        }

        private void EquipItem()
        {
            if (currentInventorySize == 0)
            {
                Debug.Log("No items to equip!");
                return;
            }
            int randomIndex = Random.Range(0, currentInventorySize);
            string itemToEquip = inventory[randomIndex];
            Debug.Log($"Equipped {itemToEquip}!");
        }

        private void UseItem()
        {
            if (currentInventorySize == 0)
            {
                Debug.Log("No items to use!");
                return;
            }
            int randomIndex = Random.Range(0, currentInventorySize);
            string itemToUse = inventory[randomIndex];
            if (itemQuantities[randomIndex] > 0)
            {
                itemQuantities[randomIndex]--;
                Debug.Log($"Used {itemToUse}!");
                if (itemQuantities[randomIndex] == 0)
                {
                    for (int i = randomIndex; i < currentInventorySize - 1; i++)
                    {
                        inventory[i] = inventory[i + 1];
                        itemQuantities[i] = itemQuantities[i + 1];
                    }
                    currentInventorySize--;
                }
                UpdateInventoryDisplay();
            }
            else
            {
                Debug.Log($"No more {itemToUse} left to use!");
            }
        }

        private void AddRandomItem()
        {
            int randomIndex = Random.Range(0, itemNames.Length);
            int randomQuantity = Random.Range(1, 4);
            AddItem(itemNames[randomIndex], randomQuantity);
        }
    }
}