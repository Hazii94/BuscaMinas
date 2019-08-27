using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    // Is this a mine?
    public bool mine;


    // Different Textures
    public Sprite[] emptyTextures;
    public Sprite mineTexture;

    // Use this for initialization
    void Start()
    {

        // Randomly decide if it's a mine or not
        mine = Random.value < 0.15;


        // TEST
        loadTexture(1);
    }


    // Load another texture
    public void loadTexture(int adjacentCount)
    {
        if (mine)
            GetComponent<SpriteRenderer>().sprite = mineTexture;
        else
            GetComponent<SpriteRenderer>().sprite = emptyTextures[adjacentCount];
    }

    // Is it still covered?
    public bool isCovered()
    {
        return GetComponent<SpriteRenderer>().sprite.texture.name == "default";
    }

    void OnMouseUpAsButton()
    {
        // It's a mine
        if (mine)
        {
            // TODO: uncover all mines
            // ...

            // game over
            print("you lose");
        }
        // It's not a mine
        else
        {
            // TODO: do stuff..
        }
    }
}
