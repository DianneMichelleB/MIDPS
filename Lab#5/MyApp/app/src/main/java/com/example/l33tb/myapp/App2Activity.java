package com.example.l33tb.myapp;


/**
 * Created by l33tb on 01.06.2016.
 */
import android.app.Activity;
import android.os.Bundle;
import android.widget.Button;

public class App2Activity extends Activity {

    Button button;

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.labs);
    }

}