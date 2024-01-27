using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    [SerializeField] private GameObject _targetObject;
    [SerializeField] private string _targetMessage;
    public Color highlightColor = Color.cyan;

    public void OnMouseOver()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if(sprite != null)
        {
            sprite.color = highlightColor;
        }
    }

    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = Color.white;
        }
    }

    private void OnMouseDown()
    {
        transform.localScale = new Vector3(2.1f, 2.1f, 2.1f);
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector3(2,2,2);
        if(_targetObject != null)
        {
            _targetObject.SendMessage(_targetMessage);
        }
    }
}
