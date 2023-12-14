using System.Collections.Generic;
using Core;
using UnityEngine;

namespace UI
{
    public class InventoryPanel : MonoBehaviour
    {
        [SerializeField] private List<Item> itemList;
        [SerializeField] private Transform foodContainer;
        [SerializeField] private Transform equipmentContainer;
        [SerializeField] private Transform collectableContainer;
        
        private void Start()
        {
            //TODO: Let's sort all items into their respective containers
        }
        
        private void CopyItemToContainer(Transform container, Item item)
        {
            Instantiate(item, container);
        }
    }
}
