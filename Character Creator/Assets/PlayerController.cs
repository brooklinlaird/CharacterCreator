using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public List<UnityEngine.UI.Button> WeaponButtons;
    public List<UnityEngine.UI.Button> ArmorButtons; 
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
    public void SetRandomWeapon()
    {
        int randomNumber = Random.Range(0, 7);
        this.WeaponButtons[randomNumber].onClick.Invoke();
    }
    public void  SetRandomArmor() 
    {
        int randomNumber = random range(0, 6);
        this.ArmorButtons[randomnumber].onClick.Invoke();
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
