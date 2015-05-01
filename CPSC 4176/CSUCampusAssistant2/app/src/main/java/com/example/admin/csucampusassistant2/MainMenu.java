package com.example.admin.csucampusassistant2;

import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
//import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.widget.Button;
import android.content.Intent;


public class MainMenu extends ActionBarActivity {

    Button mapButton;
    Button facListButton;
    Button infoButton;



    @Override
    protected void onCreate(Bundle savedInstanceState) {

        //No Title Bar  -  Fullscreen
       // requestWindowFeature(Window.FEATURE_NO_TITLE);

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_menu);




        facListButton = (Button)findViewById(R.id.facListButton);
        infoButton = (Button)findViewById(R.id.infoButton);
        mapButton = (Button)findViewById(R.id.mapButton);



        facListButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent facListIntent = new Intent(getApplicationContext(),FacilityList.class);
                startActivity(facListIntent);
            }
        });

        infoButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent infoIntent = new Intent(getApplicationContext(),Information.class);
                startActivity(infoIntent);
            }
        });


        mapButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent mapIntent = new Intent(getApplicationContext(),MapActivity.class);
                startActivity(mapIntent);
            }
        });





    }


}


/*
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main_menu, menu);
        return true;
    }
*/

/*
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