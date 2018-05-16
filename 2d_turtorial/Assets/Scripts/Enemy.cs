using UnityEngine;

public class Enemy : Token
{

	// Use this for initialization
	void Start()
	{

		// サイズを設定
		SetSize(SpriteWidth / 2, SpriteHeight / 2);

		// ランダムな方向に移動する
		// 方向をランダムに決める
		float dir = Random.Range(0, 359);

		// 速さ2
		float speed = 2;
		SetVelocity(dir, speed);
	}

	void Update()
	{
		// カメラの左下座標
		Vector2 min = GetWorldMin();
		// カメラの右上座標
		Vector2 max = GetWorldMax();

		if (X < min.x || max.x < X)
		{
			// 画面外にでたので, X移動量を反転する
			VX *= -1;

			// 画面ないへ移動する
			ClampScreen();
		}

		if (Y < min.y || max.y < Y)
		{
			// 画面外にでたので、Y移動量を反転する
			VY *= -1;

			ClampScreen();
		}
	}

	public void OnMouseDown()
	{
		// 破棄する
		DestroyObj();
	}
}
