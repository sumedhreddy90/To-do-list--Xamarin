﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ToDo
{
	public partial class ListTasksPage : ContentPage
	{
		public ListTasksPage()
		{
			InitializeComponent();
		}

		void OnSelected(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var toDoItem = e.Item as ToDoItem;
			DisplayAlert("Chosen!", toDoItem.TaskName + " was selected!", "OK");
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			ToDoList.ItemsSource = App.Database.GetToDos();
		}
	}
}
