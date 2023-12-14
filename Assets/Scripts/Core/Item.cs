using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public abstract class Item : MonoBehaviour
    {
        [SerializeField] private int id;
        [SerializeField] protected string itemName;
        [SerializeField] protected Button button;
    
        public int Id => id;
        public string Name => itemName;
    
        protected virtual void Start()
        {
            button.onClick.AddListener(OnItemClicked);
        }
    
        protected abstract void OnItemClicked();
    }
}
