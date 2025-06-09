using UnityEngine;

public class WindowResizer : MonoBehaviour
{
    private float targetAspect = 9f / 16f;
    private void FixedUpdate()
    {
        // Lấy kích thước hiện tại của cửa sổ
        int width = Screen.width;
        int height = Screen.height;

        // Tính chiều cao đúng theo tỷ lệ 9:16 dựa trên chiều rộng hiện tại
        int correctHeight = Mathf.RoundToInt(width / targetAspect);

        // Nếu chiều cao hiện tại sai lệch nhiều, thì chỉnh lại
        if (Mathf.Abs(height - correctHeight) > 2)
        {
            Screen.SetResolution(width, correctHeight, false);
        }
    }
}
