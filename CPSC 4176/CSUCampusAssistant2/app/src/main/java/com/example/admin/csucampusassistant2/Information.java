package com.example.admin.csucampusassistant2;

import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.widget.Button;
import android.content.Intent;
import android.widget.TextView;


public class Information extends ActionBarActivity {



    Button menuButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_information);

        TextView infoText = (TextView)findViewById(R.id.infoText);



        //Set the information text to database text
        infoText.setText("Main Menu - To navigate, tap your choice of the features. " +
                "\n" +
                "\n" +
                "Facility List - To select a facility, tap your choice of available facilities. " +
                "\n" +
                "\n" +
                "Facility - This page displays the facility name, and has a space for a description provided by the database. " +
                "\n" +
                "\n" +
                "In the bottom right corner, you will see the “GMT” button. This is how you access Get Me There. Get Me There - This feature, currently just a camera feed, is still under development. " +
                "\n" +
                "\n" +
                "Info - Information about how to use this app. To navigate to a previous page, tap the ‘back’ button on your Android device.");



        menuButton = (Button) findViewById(R.id.menuButton);
        menuButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent menuIntent = new Intent(getApplicationContext(), MainMenu.class);
                startActivity(menuIntent);
            }
        });

















        //Make options menu






    }
}
    /*
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_information, menu);
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
}
*/