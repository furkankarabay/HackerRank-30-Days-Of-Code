using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person{
    private int[] testScores;  
    
    public Student(string firstN, string lastN, int Id, int[] scores)
    {
        firstName = firstN;
        lastName = lastN;
        id = Id;
        
        testScores = scores;
    }
    
    public string Calculate()
    {
        int score = testScores.Sum() / testScores.Count();
        
        if(score <= 100 & score >= 90)
            return "O";
        else if(score < 90 & score >= 80)
            return "E";
        else if(score < 80 & score >= 70)
            return "A";
        else if(score < 70 & score >= 55)
            return "P";
        else if(score < 55 & score >= 40)
            return "D";
        else if(score < 40)
            return "T";
            
        return "";
    }
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}