using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WallCollider : MonoBehaviour
{
    public BoxCollider2D Colliders;
    public RectTransform rect;
    void Start()
    {
        
    }

   
    void Update()
    {
        Colliders.size = rect.rect.size;
    }
}
