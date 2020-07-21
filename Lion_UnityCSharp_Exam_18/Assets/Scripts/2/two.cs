using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class two : MonoBehaviour
{
    public Sprite[] sprites;
    public Image[] images;

    void Start()
    {
        
    }
        
    
    private void Update()
    {        
        images = gameObject.GetComponentsInChildren<Image>();
        StartCoroutine(Count());

        IEnumerator Count()
        {
            if (Input.GetMouseButton(0))
            {
                for (int i = 0; i < images.Length; i++)
                {
                    var spriteNumber = Random.Range(0, sprites.Length - 1);
                    images[i].sprite = sprites[spriteNumber];
                }

                yield return new WaitForSeconds(2);
            }
        }
    }    
}

