using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer ArmorRenderer;

    public void SetArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
    }
      public SpriteRenderer WeaponRenderer;

    public void SetWeapon(Sprite newSprite)
    {
        WeaponRenderer.sprite = newSprite;
    }
    // start this before the first frame
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
