using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
	// 一定時間ごとに呼ばれます
	void FixedUpdate()
	{
		// キーボードの情報を取得
		var keyboard = Keyboard.current;

		// スプライトの移動処理
		if (keyboard.leftArrowKey.isPressed)
		{
			transform.Translate(-0.1f, 0, 0, Space.World);
		}
		if (keyboard.rightArrowKey.isPressed)
		{
			transform.Translate(0.1f, 0, 0, Space.World);
		}
		if (keyboard.upArrowKey.isPressed)
		{
			transform.Translate(0, 0.1f, 0, Space.World);
		}
		if (keyboard.downArrowKey.isPressed)
		{
			transform.Translate(0, -0.1f, 0, Space.World);
		}
	}
}