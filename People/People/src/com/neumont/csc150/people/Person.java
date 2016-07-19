package com.neumont.csc150.people;

import java.io.Serializable;

abstract public class Person implements Serializable {
	public static final byte MIN_AGE = 0;
	public static final byte MAX_AGE = 127;
	
	private String name;
	private byte age;
	private Gender gender;
	
	public Person() {}
	
	public Person(String name, byte age) {
		this.setName(name);
		this.setAge(age);
	}
	
	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		if(name == null || name.length() == 0) {
			throw new IllegalArgumentException("name cannot be null or empty");
		}
		this.name = name;
	}

	public byte getAge() {
		return age;
	}

	public void setAge(byte age) {
		if(age < MIN_AGE || age > MAX_AGE) {
			throw new IllegalArgumentException("invalid age: " + age);
		}
		this.age = age;
	}
	
	public Gender getGender() {
		return gender;
	}

	public void setGender(Gender gender) {
		this.gender = gender;
	}

	@Override
	public String toString() {
		return this.getName() + " " + this.getAge();
	}
	
	@Override
	public boolean equals(Object obj) {
		Person other = (Person)obj;
		return(this.getName().equals(other.getName()) &&
				this.getAge() == other.getAge());
	}
	
	
	
	abstract void Speak();
	
	
	/*public String serializeToString() {
		return this.getName() + "|" + this.getAge() + "|" +
		(this.getGender() == null ? "" : this.getGender().toString() );
	}
	
	public void deserializeFromString(String serialData) {
		String[] pieces = serialData.split("|");
		this.setName(pieces[0]);
		this.setAge((byte)Integer.parseInt(pieces[1]));
	}*/
}




