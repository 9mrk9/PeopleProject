namespace PeopleProject
{
	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public bool IsStudent { get; set; }
		public int Score { get; set; }

		public Person(int Id, string Name, int Age, bool IsStudent, int Score)
		{
			this.Id = Id;
			this.Name = Name;
			this.Age = Age;
			this.IsStudent = IsStudent;
			this.Score = Score;
		}
	}
}
