using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PeopleProject
{
	public class PersonStatistics
	{
		public List<Person> People { private get; set; }
		public PersonStatistics(List<Person> people)
		{
			People = people ?? throw new ArgumentNullException(nameof(people));
		}

		public double GetAverageAge()
		{
			return People.Any() ? People.Average(p => p.Age) : 0;
		}

		public int GetNumberOfStudents()
		{
			return People.Count(p => p.IsStudent);
		}

		public Person? GetPersonWithHighestScore()
		{
			if (People.Count() == 0) return null;
			return People.OrderByDescending(p => p.Score).FirstOrDefault();
		}

		public double GetAverageScoreOfStudents()
		{
			var students = People.Where(p => p.IsStudent).ToList();
			return students.Any() ? students.Average(p => p.Score) : 0;
		}

		public Person? GetOldestStudent()
		{
			if (People.Count() == 0) return null;
			if (!People.Any((p) => p.IsStudent)) return null;
			return People.Where(p => p.IsStudent).OrderByDescending(p => p.Age).FirstOrDefault();
		}

		public bool IsAnyoneFailing()
		{
			return People.Any(p => p.Score < 40);
		}
	}
}
