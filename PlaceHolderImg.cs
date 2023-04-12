using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;
using Unity.UI;

public class PlaceHolderImg : MonoBehaviour
{
    private Sprite defaultImg;
    public GameObject MyImage;
    // Start is called before the first frame update
    void Start()
    {
        MyImage.AddComponent(typeof(Image));
        defaultImg = Resources.Load<Sprite>("Assets/Sprites/Placeholder");
        MyImage.GetComponent(typeof(Image)) = defaultImg;
        Debug.Log("Placeholder image grabbed");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
