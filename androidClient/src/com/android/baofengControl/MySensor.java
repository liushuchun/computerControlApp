package com.android.baofengControl;

import java.io.IOException;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;

public class MySensor {
	SensorManager sensorManager;
	Client client;
	
	///��ʼ�������ٴ�����
	public void Listen(SensorManager sensorManager,Client client)
	{
		this.client=client;
		this.sensorManager=sensorManager;
		Sensor sensor=sensorManager.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
		sensorManager.registerListener(sensorEventListener, sensor, SensorManager.SENSOR_DELAY_NORMAL);
	}
	
	SensorEventListener sensorEventListener =new SensorEventListener(){

		long lastUpdate,lastShakeTime = 0;
        float x,y,last_x = 0,last_y = 0;
        static final int SHAKE_THRESHOLD = 750;
        
		public void onAccuracyChanged(android.hardware.Sensor arg0, int arg1) {
			// TODO Auto-generated method stub
			
		}

		public void onSensorChanged(SensorEvent e) {
            long curTime = System.currentTimeMillis();
            // detect per 100 Millis
            if ((curTime - lastUpdate) > 100) {
                long diffTime = (curTime - lastUpdate);
                lastUpdate = curTime;
                //�������˼򻯣�û����z������
                x = e.values[SensorManager.DATA_X];
                y = e.values[SensorManager.DATA_Y];
                //z = Math.abs(values[SensorManager.DATA_Z]);
                float acceChangeRate = 0;// = Math.abs(x+y - last_x - last_y) / diffTime * 1000;  
                if(last_x != 0) acceChangeRate = Math.abs(x+y - last_x - last_y) / diffTime * 10000;
                 //�����趨2����ֵ��һ���Ǽ��ٶȵģ�һ����shake�ļ��ʱ���
                if (acceChangeRate > SHAKE_THRESHOLD && curTime - lastShakeTime > 1000) {

                    lastShakeTime = curTime;
                    try {
						client.sendMsg("stsp");	//������Ϣ������������������������������
					} catch (IOException e1) {
						e1.printStackTrace();
					}
                }
                last_x = x;
                last_y = y;
            }
		}};
}
