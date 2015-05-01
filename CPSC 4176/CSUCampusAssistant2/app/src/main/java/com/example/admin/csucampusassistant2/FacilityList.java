package com.example.admin.csucampusassistant2;

import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.content.Intent;
import android.widget.ListView;
import android.widget.TextView;


public class FacilityList extends ActionBarActivity {


    Button menuButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {


        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_facility_list);

        populateList();
        registerClicks();

        menuButton = (Button) findViewById(R.id.menuButton);
        menuButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
               Intent menuIntent = new Intent(getApplicationContext(), MainMenu.class);
                startActivity(menuIntent);
           }
       });

    }


    private void populateList() {
        String[] facilities = {"Clock Tower", "CCT", "Library", "Recreation Center", "Lumpkin Center", "Parking Deck", "University Hall", "Schuster", "Davidson Student Center", "Woodall", "Tucker Hall","Arnold Hall", "Stanley Hall", "Health and Wellness Center"};

        ArrayAdapter<String> adapter = new ArrayAdapter<String>(
                this, // Facility List Activity
                R.layout.facilities_text_view, // Layout to use
                facilities); // text to display


        ListView list = (ListView) findViewById(R.id.facilities_listView);
        list.setAdapter(adapter);


    }

    private void registerClicks() {
        ListView list = (ListView) findViewById(R.id.facilities_listView);
        list.setOnItemClickListener(new AdapterView.OnItemClickListener(){
            @Override
            public void onItemClick(AdapterView<?> parent, View viewClicked, int position, long id){
                TextView textView = (TextView) viewClicked;
                Intent facilityIntent = new Intent(getApplicationContext(), Facility.class);
                facilityIntent.putExtra("facilityName", textView.getText().toString());
                startActivity(facilityIntent);

            }

        });

    }

}

 /*
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_facility_list, menu);
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