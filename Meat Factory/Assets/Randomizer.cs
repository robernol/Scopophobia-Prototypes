using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public Sprite[] sprites;
    void Start()
    {
        int randomIndex = Random.Range(0, sprites.Length);
        GetComponent<SpriteRenderer>().sprite = sprites[randomIndex];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = Random.Range(0, sprites.Length);
            GetComponent<SpriteRenderer>().sprite = sprites[randomIndex];
        }
    }
}
