package com.example.admin.csucampusassistant2;

import android.graphics.PointF;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;
import android.content.Intent;
import android.view.MotionEvent;


public class MapActivity extends ActionBarActivity {

    Button menuButton;
    PointF zoomPosition;
    boolean zooming;

    @Override
    protected void onCreate(Bundle savedInstanceState) {


        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_map);


        //Menu Button creation and eventListener
        menuButton = (Button)findViewById(R.id.menuButton);
        menuButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent menuIntent = new Intent(getApplicationContext(),MainMenu.class);
                startActivity(menuIntent);
            }
        });



        //zoomPosition = new PointF(0f,0f);
    }

    /*
    @Override
    public boolean onTouch(View view, MotionEvent event) {

        int action = event.getAction();

        zoomPosition.x = event.getX();
        zoomPosition.y = event.getY();

        switch (action) {
            case MotionEvent.ACTION_DOWN:
            case MotionEvent.ACTION_MOVE:
                zooming = true;
                view.invalidate();
                break;
            case MotionEvent.ACTION_UP:
            case MotionEvent.ACTION_CANCEL:
                zooming = false;
                view.invalidate();
                break;

            default:
                break;
        }

        return true;
    }
*/
}


 /*

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_map, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    */



// requestWindowFeature(Window.FEATURE_NO_TITLE);
// getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
//  WindowManager.LayoutParams.FLAG_FULLSCREEN);
//No Title Bar  -  Fullscreen
//requestWindowFeature(Window.FEATURE_NO_TITLE);

//this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);