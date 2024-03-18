using System;
using DEMO_API.Model;

namespace DEMO_API.DTO.Requests
{
	public class CreateStudentRequest
	{
		public string Name { get; set; }
		public Promotion Promotion { get; set; }
	}
}

