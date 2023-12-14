using Core;
using UnityEngine;

namespace Items
{
    public class Gem : Item
    {
        protected override void OnItemClicked()
        {
            Debug.Log($"Collectable, Id {Id}, Name {Name} clicked!");
        }
    }
}
