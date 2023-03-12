using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Secelctable";

    private IRayProvider _rayProvider;
    private ISelector _selector;
    private ISelectionResponse _selectionResponse;

    private Transform _currentselection;
    private Transform _selection;
    public void Awake()
    {
        _selectionResponse = GetComponent<ISelectionResponse>();
    }

    private void Update()
    {
        //Deselection/Selection Response
        if (_currentselection != null) _selectionResponse.OnDeselect(_currentselection);

        _selector.Check(_rayProvider.CreateRay());
        _currentselection = _selector.GetSelection();

        if (_currentselection != null) _selectionResponse.OnSelect(_currentselection);
    }
}