﻿namespace MauiApp4;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        BindingContext = ServiceHelper.GetService<MainViewModel>();
    }
}
