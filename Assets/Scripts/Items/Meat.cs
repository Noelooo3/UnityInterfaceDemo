using Core;
using UnityEngine;

namespace Items
{
    public class Meat : Item
    {
        protected override void OnItemClicked()
        {
            Debug.Log($"Food, Id {Id}, Name {Name} clicked!");
        }
    }
}
