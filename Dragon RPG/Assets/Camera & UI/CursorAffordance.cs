using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorAffordance : MonoBehaviour {

    [SerializeField] private Texture2D walkCursor = null;
    [SerializeField] private Texture2D attackCursor = null;
    [SerializeField] private Texture2D unknownCursor = null;

    [SerializeField] private Vector2 cursorHotspot = new Vector2(96, 96);

    CameraRaycaster camRayCaster;

	// Use this for initialization
	void Start () {
        camRayCaster = GetComponent<CameraRaycaster>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        switch (camRayCaster.layerHit)
        {
            case Layer.Walkable:
                Cursor.SetCursor(walkCursor, cursorHotspot, CursorMode.Auto);
                break;
            case Layer.Enemy:
                Cursor.SetCursor(attackCursor, cursorHotspot, CursorMode.Auto);
                break;
            case Layer.RaycastEndStop:
                Cursor.SetCursor(unknownCursor, cursorHotspot, CursorMode.Auto);
                break;
            default:
                Debug.LogError("don't know what cursor to show");
                return;
        }
	}
}
