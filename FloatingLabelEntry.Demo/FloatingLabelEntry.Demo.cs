﻿using System;
using FloatingLabelEntry;
using Xamarin.Forms;
using FloatingLabelEntry.Base;
using FloatingLabelEntry.Enumerations;

namespace FloatingLabelEntry.Demo
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new SimpleFloatingLabelEntry {
							HeightRequest=100,
							LabelText="Your Name",
							FontSize=60,
							CornerRadius = 20f,
							FontName="BebasNeueBook",
						},
						new SimpleFloatingLabelEntry {
							HeightRequest=100,
							LabelText="Your Mail",
							FontSize=60,
							CornerRadius = 20f,
							CustomKeyboard=CustomKeyboardEnum.EmailAndNumeric,
						},
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

