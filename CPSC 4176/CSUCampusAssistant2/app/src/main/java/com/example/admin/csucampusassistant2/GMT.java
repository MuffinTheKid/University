package com.example.admin.csucampusassistant2;

import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.hardware.Camera;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.FrameLayout;


public class GMT extends ActionBarActivity {

    private Camera mCamera;
    private CameraPreview mPreview;

    private Button menuButton;

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_gmt);

        // Create an instance of Camera
        mCamera = getCameraInstance();

        // Create our Preview view and set it as the content of our activity.
        mPreview = new CameraPreview(this, mCamera);
        FrameLayout preview = (FrameLayout) findViewById(R.id.camera_preview);
        preview.addView(mPreview);

        menuButton = (Button)findViewById(R.id.menuButton);
        menuButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent menuIntent = new Intent(getApplicationContext(),MainMenu.class);
                startActivity(menuIntent);
            }
        });

    }

    private boolean checkCameraHardware(Context context) {
        if(context.getPackageManager().hasSystemFeature(PackageManager.FEATURE_CAMERA)){
            //device has a camera
            return true;
        }else{
            //device does not have a camera
            return false;
        }

    }

    public static Camera getCameraInstance(){
        Camera c = null;

        try {
            c = Camera.open();
        }catch(Exception e){
            //Camera is not available
        }

        return c;
    }

    @Override
    protected  void onPause(){
        super.onPause();
        releaseCamera();

    }



    private void releaseCamera() {
        if(mCamera != null){
            mCamera.release();
            mCamera = null;
        }

    }


}
