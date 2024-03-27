using UnityEngine;
using System;
using UnityEngine.Events;
public class MouseManager : MonoBehaviour
{
    public static MouseManager Instance;
    public event Action<Vector3> OnMouseClick;
    RaycastHit hit;
    public Texture2D point, doorway, attact, target, arrow;
    // public UnityEvent<Vector3> OnMouseClick;
    void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        Instance = this;
    }

    void Update()
    {
        SetCursorTexture();
        MouseControl();
    }

    void SetCursorTexture()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            switch (hit.collider.gameObject.tag)
            {
                case "Ground":
                    Cursor.SetCursor(target, new Vector2(16, 16), CursorMode.Auto);
                    // print("grond");
                    break;
                case "Enemy":
                    Cursor.SetCursor(attact, new Vector2(16, 16), CursorMode.Auto);
                    // print(1);
                    break;
            }
        }
    }
    void MouseControl()
    {
        if (Input.GetMouseButtonDown(0) && hit.collider != null)
        {
            if (hit.collider.gameObject.tag == "Ground")         //如果点击的是地面，就调用方法
                OnMouseClick?.Invoke(hit.point);
        }
    }

    public void p()
    {
        print(123);
    }
}
