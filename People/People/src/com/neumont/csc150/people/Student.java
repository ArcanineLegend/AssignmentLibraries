package com.neumont.csc150.people;

import java.util.ArrayList;
import java.util.Calendar;

public class Student extends Person {
	private String studentID;
	private Calendar enrollmentDate;
	private ArrayList<Person> friends = new ArrayList<Person>();
	
	public Student() {
	}
	
	public void addAFriend(Person p) {
		this.friends.add(p);
	}
	
	public void unFriend(Person p) {
		this.friends.remove(p);
	}
	
	public void unFriend(int index) {
		this.friends.remove(index);
	}

	public String getStudentID() {
		return studentID;
	}

	public void setStudentID(String studentID) {
		this.studentID = studentID;
	}

	public Calendar getEnrollmentDate() {
		return enrollmentDate;
	}

	public void setEnrollmentDate(Calendar enrollmentDate) {
		this.enrollmentDate = enrollmentDate;
	}

	@Override
	void Speak() {
		System.out.println("I need a weekend");
		
	}
	
	@Override
	public boolean equals(Object obj) {
		Student other = (Student)obj;
		if(this.getStudentID().equals(other.getStudentID()) &&
				super.equals(obj)) {
			return true;
		}
		else {
			return false;
		}
	}
	
}




