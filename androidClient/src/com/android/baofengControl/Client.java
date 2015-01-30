package com.android.baofengControl;

import java.io.BufferedWriter;
import java.io.IOException;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.net.InetAddress;
import java.net.Socket;
import java.net.UnknownHostException;
import android.content.Context;
import android.widget.TextView;

public class Client {
	Socket client;
	PrintWriter out;
	TextView txt;
	Context context;
	
	public Client(TextView txt,Context context)
	{
		this.txt=txt;
		this.context=context;
	}
	
	///建立连接，并保持
	public void connectServer(String ip)
	{
		InetAddress serverAddress = null;
		try {
			serverAddress = InetAddress.getByName(ip);
		} catch (UnknownHostException e) {
			txt.setText(e.getLocalizedMessage()+txt.getText());
			e.printStackTrace();
		}
		
		try {
			client=new Socket(serverAddress,12121);
			out=new PrintWriter(new BufferedWriter(new OutputStreamWriter(client.getOutputStream())),true);
		} catch (IOException e) {
			txt.setText(e.getLocalizedMessage()+txt.getText());
			e.printStackTrace();
		}
	}
	
	public void sendMsg(String msg) throws IOException
	{
		out.println(msg);
	}
	
	public void close()
	{
		out.println("over");
		out.close();
		txt.setText("end"+txt.getText());
	}
}
