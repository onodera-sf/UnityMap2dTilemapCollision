using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
	// ��莞�Ԃ��ƂɌĂ΂�܂�
	void FixedUpdate()
	{
		// �L�[�{�[�h�̏����擾
		var keyboard = Keyboard.current;

		// �X�v���C�g�̈ړ�����
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