using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private Sprite _image;
    [SerializeField] private GameObject _cardBack;
    [SerializeField] private SceneControler _sceneControler;

    private int _id;
    public int id
    {
        get { return _id;}
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    private void OnMouseDown()
    {
        if (_cardBack.activeSelf && _sceneControler.canReveal)
        {
            _cardBack.SetActive(false);
            _sceneControler.CardRevealed(this);
        }
    }

    public void Unreveal()
    {
        _cardBack.SetActive(true);
    }
}
