using Core;
using UnityEngine;

namespace Items
{
    public class Sword : Item
    {
        protected override void OnItemClicked()
        {
            Debug.Log($"Equipment, Id {Id}, Name {Name} clicked!");
        }
    }
}
