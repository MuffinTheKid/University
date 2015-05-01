package com.example.admin.csucampusassistant2;

import android.content.Intent;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;


public class Facility extends ActionBarActivity {

    Button menuButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_facility);

        String facilityNameString = getIntent().getExtras().getString("facilityName");
        String[] facilityNames = {"Clock Tower", "CCT", "Library", "Recreation Center", "Lumpkin Center", "Parking Deck", "University Hall", "Schuster", "Davidson Student Center", "Woodall", "Tucker Hall","Arnold Hall", "Stanley Hall", "Health and Wellness Center"};


        TextView facilityName = (TextView)findViewById(R.id.facilityName);
        TextView descriptionText = (TextView)findViewById(R.id.descriptionText);

        facilityName.setText(facilityNameString);


        for(int i = 0; i < facilityNames.length; i++)
        {
            if(facilityNameString.equalsIgnoreCase(facilityNames[i])){
                descriptionText.setText("This is the " + facilityNameString + " page!");
            }

        }



        menuButton = (Button) findViewById(R.id.menuButton);
        menuButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent menuIntent = new Intent(getApplicationContext(), MainMenu.class);
                startActivity(menuIntent);
            }
        });

        Button gmtButton = (Button)findViewById(R.id.gmtButton);
        gmtButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent toCameraIntent = new Intent(getApplicationContext(), GMT.class);
                startActivity(toCameraIntent);
            }
        });



    }



}
