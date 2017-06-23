using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace ToDo
{
	public partial class CreatePage : ContentPage
	{
		private CreatePageViewModel vm;
		private int updateID = 0;

		public CreatePage(int id)
		{
			vm = new CreatePageViewModel();
			BindingContext = vm;

			InitializeComponent();
			ToDoItem toDoItem = App.Database.GetToDo(id);
			toDoTask.Text = toDoItem.TaskName;
			priority.Text = toDoItem.Priority;
			date.Date = toDoItem.DueDate;
			time.Time = toDoItem.DueDate.TimeOfDay;
			updateID = id;
		}

		public CreatePage() {
			vm = new CreatePageViewModel();
			BindingContext = vm;
			InitializeComponent();
		}

		void OnSave(object sender, System.EventArgs e)
		{
			vm.AddTask(
				toDoTask.Text,
				priority.Text,
				date.Date,
				time.Time.Hours,
				time.Time.Minutes,
				time.Time.Seconds,
				updateID,
				false
			);

			Clear();
		}

		private void Clear() {
			toDoTask.Text = priority.Text = String.Empty;
			date.Date = DateTime.Now;
			time.Time = new TimeSpan(
				DateTime.Now.Hour,
				DateTime.Now.Minute,
				DateTime.Now.Second
			);
		}

		void OnCancel(object sender, System.EventArgs e)
		{

		}

		void OnReview(object sender, System.EventArgs e)
		{
			Clear();

			Navigation.PushAsync(new ListTasksPage());
		}
	}
}
