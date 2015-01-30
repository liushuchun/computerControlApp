package com.android.baofengControl;

import java.io.IOException;

import android.app.Activity;
import android.content.Context;
import android.hardware.Sensor;
import android.hardware.SensorManager;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class Android_test2Activity extends Activity {
    Client client;
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        
        final TextView textView1=(TextView)findViewById(R.id.textView1);
        Button btnStsp=(Button)findViewById(R.id.button1);	//开始暂停
        Button btnFornt=(Button)findViewById(R.id.button2);	//快进
        Button btnBack=(Button)findViewById(R.id.button3);	//快退
        Button btnConnect=(Button)findViewById(R.id.button4);	//连接服务端
        Button btnClose=(Button)findViewById(R.id.button5);	//断开连接
        final EditText ipText=(EditText)findViewById(R.id.editText1);	//保存服务端ip
        MySensor mySensor=new MySensor();
        Context context=getBaseContext();
        client=new Client(textView1,context);
        mySensor.Listen((SensorManager)getSystemService(SENSOR_SERVICE),client);

        btnConnect.setOnClickListener(new Button.OnClickListener(){
			public void onClick(View arg0) {
				client.connectServer(ipText.getText().toString());
				textView1.setText("OK");
			}
        });
        
        //开始，暂停
        btnStsp.setOnClickListener(new Button.OnClickListener(){
			public void onClick(View arg0) {
				try {
					textView1.setText("点击按钮");
					client.sendMsg("stsp");
				} catch (IOException e) {
					textView1.setText(e.getMessage());
					e.printStackTrace();
				}
			}
        });
        
        btnFornt.setOnClickListener(new OnClickListener(){
        	public void onClick(View arg0){
        		try {
					client.sendMsg("qian");
				} catch (IOException e) {
					textView1.setText(e.getMessage());
					e.printStackTrace();
				}
        	}
        });
        
        btnBack.setOnClickListener(new OnClickListener()
        {
        	public void onClick(View arg0){
        		try {
					client.sendMsg("back");
				} catch (IOException e) {
					textView1.setText(e.getMessage());
					e.printStackTrace();
				}
        	}
        }); 
        
        btnClose.setOnClickListener(new Button.OnClickListener(){
			public void onClick(View arg0) {
				client.close();
			}
        });
    }
}