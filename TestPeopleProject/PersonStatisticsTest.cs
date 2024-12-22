using PeopleProject;

namespace TestPeopleProject
{
	public class PersonStatisticsTests
	{
		PersonStatistics stats;

		[SetUp]
		public void SetUp()
		{
			stats = new PersonStatistics(new List<Person>());
		}

		[Test]
		public void TestGetAverageAge()
		{
			stats.People = new List<Person>
			{
				new Person (1, "Aladár", 15, true, 50),
				new Person (2, "Ferenc", 17, true, 70),
				new Person (3, "Gábor", 40, false, 99)
			};
			Assert.That(stats.GetAverageAge(), Is.EqualTo(24));
		}

		[Test]
		public void TestGetAverageAge_EmptyList()
		{
			Assert.That(stats.GetAverageAge(), Is.EqualTo(0));
		}

		[Test]
		public void TestGetNumberOfStudents()
		{
			stats.People = new List<Person>
			{
				new Person (1, "Aladár", 15, true, 50),
				new Person (2, "Ferenc", 17, true, 70),
				new Person (3, "Gábor", 20, false, 90)
			};
			Assert.That(stats.GetNumberOfStudents(), Is.EqualTo(2));
		}

		[Test]
		public void TestGetNumberOfStudents_EmptyList()
		{
			Assert.That(stats.GetNumberOfStudents(), Is.EqualTo(0));
		}

		[Test]
		public void TestGetPersonWithHighestScore()
		{
			stats.People = new List<Person>
			{
				new Person (1, "Aladár", 15, true, 50),
				new Person (2, "Ferenc", 17, true, 70),
				new Person (3, "Gábor", 20, true, 85)
			};
			Assert.That(stats.GetPersonWithHighestScore()!.Score, Is.EqualTo(85));
		}

		[Test]
		public void TestGetPersonWithHighestScore_EmptyList()
		{
			Assert.IsNull(stats.GetPersonWithHighestScore());
		}

		[Test]
		public void TestGetAverageScoreOfStudents()
		{
			stats.People = new List<Person>
			{
				new Person (1, "Aladár", 15, true, 50),
				new Person (2, "Ferenc", 17, true, 70),
				new Person (3, "Gábor", 20, true, 87)
			};
			Assert.That(stats.GetAverageScoreOfStudents(), Is.EqualTo(69));
		}

		[Test]
		public void TestGetAverageScoreOfStudents_EmptyList()
		{
			Assert.That(stats.GetAverageScoreOfStudents(), Is.EqualTo(0));
		}

		[Test]
		public void TestGetOldestStudent()
		{
			stats.People = new List<Person>
			{
				new Person (1, "Aladár", 15, true, 50),
				new Person (2, "Ferenc", 17, true, 70),
				new Person (3, "Gábor", 20, true, 87)
			};
			Assert.That(stats.GetOldestStudent()!.Age, Is.EqualTo(20));
		}

		[Test]
		public void TestGetOldestStudent_EmptyList()
		{
			Assert.IsNull(stats.GetOldestStudent());
		}

		[Test]
		public void TestIsAnyoneFailing()
		{
			stats.People = new List<Person>
			{
				new Person (1, "Aladár", 15, true, 35),
				new Person (2, "Ferenc", 17, true, 70),
				new Person (3, "Gábor", 20, true, 85)
			};
			Assert.IsTrue(stats.IsAnyoneFailing());
		}

		[Test]
		public void TestIsAnyoneFailing_EmptyList()
		{
			Assert.IsFalse(stats.IsAnyoneFailing());
		}
	}
}
