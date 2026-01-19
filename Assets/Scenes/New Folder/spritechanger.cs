
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class spritechanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PickARandomcolor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame) {
           PickARandomcolor();
        }


        //get the mouce position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is the mouse over the sprite
        if (spriteRenderer.bounds.Contains(mousePos) == true){
            spriteRenderer.color = col;
        }
        else {
            spriteRenderer.color = Color.white;
        }
        if (Mouse.current.leftButton.wasPressedThisFrame == true) {
            barrels.RemoveAt(0);
        }
    }
    void PickARandomcolor() {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite() {

        randomNumber = Random.Range(0, barrels.Count);

        randomNumber = Random.Range(0, 3);
        spriteRenderer.sprite = barrels[randomNumber];


    }


}
