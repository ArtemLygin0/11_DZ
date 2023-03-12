using UnityEngine;

internal interface ISelectionResponse
{
    void Onselect(Transform selection);
    void OnDeselect(Transform selection);
}