package com.neumont.csc150.people;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;

public class TestDriver {

	public static void main(String[] args) throws IOException {
		Person bob = new Student();
		Person suzy = new Student();
		bob.setName("Bob");
		suzy.setName("Suzy");
		System.out.println("Person name=" + bob.getName());
		System.out.println("Person name=" + suzy.getName());
		Student frank = new Student();
		frank.setName("Frank");
		Instructor inst = new Instructor();
		frank.addAFriend(bob);
		PersonPersister pp = new PersonPersister();
		ArrayList<Person> people = new ArrayList<Person>();
		people.add(frank);
		people.add(bob);
		people.add(suzy);
		pp.savePeopleToDisk(people);
	}

}
