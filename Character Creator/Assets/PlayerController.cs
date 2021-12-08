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
    // start this before the first frame
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
