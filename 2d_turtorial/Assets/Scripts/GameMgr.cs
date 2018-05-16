﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMgr : MonoBehaviour {

	void OnGUI()
	{
		if (Enemy.Count == 0)	
		{
			// 敵が全滅
			// フォントサイズ設定
			Util.SetFontSize(32);

			// 中央揃え
			Util.SetFontAlignment(TextAnchor.MiddleCenter);

			// フォント位置
			float w = 128; // 幅
			float h = 32;  // 高さ
			float px = Screen.width / 2 - w / 2;
			float py = Screen.height / 2 - h / 2;

			// フォント描画
			Util.GUILabel(px, py, w, h, "Game Clear!!!");

            // ボタンは少し下にずらす
            py += 60;
            if (GUI.Button(new Rect(px, py, w, h), "Back to Title"))
            {
				// タイトル画面にもどる
				SceneManager.LoadScene("Title");
            }
		}
	}

}
