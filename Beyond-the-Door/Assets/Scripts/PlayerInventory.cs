using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory instance;

    public int keyCount = 0;

    [Header("Key UI")]
    public Image[] keyImages; // Assign your 3 UI key images in Inspector
    public Sprite goldKeySprite; // Assign your gold key sprite here

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void AddKey()
    {
        if (keyCount < keyImages.Length)
        {
            keyImages[keyCount].sprite = goldKeySprite;
            keyCount++;
        }
    }
}
