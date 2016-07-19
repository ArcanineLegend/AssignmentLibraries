package com.neumont.csc150.people;

import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.PrintWriter;

public class FileManager {
	public void writeToTextFile(String filePath, String data, boolean append)
			throws FileNotFoundException {
		OutputStream outFile = new FileOutputStream(filePath, append);
		PrintWriter out = new PrintWriter(outFile);
		out.println(data);
		out.close();
	}
	
	public String readFromTextFile(String filePath)
			throws IOException {
		InputStream inStream = new FileInputStream(filePath);
		InputStreamReader reader = new InputStreamReader(inStream);
		BufferedReader in = new BufferedReader(reader);
		String myReturnString = "";
		while(in.ready()) {
			myReturnString += in.readLine() + "\n";
		}
		in.close();
		return myReturnString;
	}
}







