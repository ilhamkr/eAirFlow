package com.example.eairflow_mobile

import io.flutter.embedding.android.FlutterActivity
import android.os.Bundle
import android.app.UiModeManager
import android.content.Context

class MainActivity: FlutterActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        // FORCE LIGHT MODE
        val uiModeManager = getSystemService(Context.UI_MODE_SERVICE) as UiModeManager
        uiModeManager.nightMode = UiModeManager.MODE_NIGHT_NO
    }
}
