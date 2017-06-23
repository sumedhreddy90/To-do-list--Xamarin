using System;
using System.Diagnostics.Contracts;
namespace ToDo
{
	public class CreatePageViewModel
	{
		public CreatePageViewModel()
		{
		}

		public void AddTask(string taskName, string priority, DateTime dueDate, int hour, int minute, int second, int updateID, bool isDeleted)
		{
			var newToDo = new ToDoItem
			{
				TaskName = taskName,
				Priority = priority,
				DueDate = SetDueDate(dueDate, hour, minute, second),
				IsDeleted = isDeleted,
				ID = updateID
			};
			App.Database.SaveToDo(newToDo);
		}

		public DateTime SetDueDate(DateTime date, int hour, int minute, int second) {
			DateTime retVal = new DateTime(
				date.Year,
				date.Month,
				date.Day,
				hour,
				minute,
				second);
			return retVal;
		}
	}
}
