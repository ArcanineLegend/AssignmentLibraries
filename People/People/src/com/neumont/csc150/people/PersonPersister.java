package com.neumont.csc150.people;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

public class PersonPersister {
	public static final String PersonDBPath =
			"C:\\users\\rcox\\desktop\\tmp\\persondb.txt";
	
	public void savePeopleToDisk(ArrayList<Person> list) throws IOException {
		FileOutputStream outFile = new FileOutputStream(PersonDBPath);
		ObjectOutputStream out = new ObjectOutputStream(outFile);
		out.writeObject(list);
		out.close();
	}
	
	public ArrayList<Person> loadPeopleFromDisk()
			throws IOException, ClassNotFoundException {
		FileInputStream infile = new FileInputStream(PersonDBPath);
		ObjectInputStream in = new ObjectInputStream(infile);
		ArrayList<Person> p = (ArrayList<Person>)in.readObject();
		in.close();
		return p;
	}
}




