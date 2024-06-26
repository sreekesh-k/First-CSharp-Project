﻿using System;
/*
	1. Wap to create a class Mobile, the class should have following attributes and methods:
		Fields:-
			1. brand
			2. model
			3. batteryLevel

		Methods:-
			1. MakeCall()
			2. ChargeBattery(battery)
			3. UseBattery(battery)
			4. PrintDetails()

	2. After creating the class WAP to create and instance of Mobile class set the attributes brand and model.
	3. Call the ChargeBattery() to set battery level to 50%.
	4. Call the MakeCall() to simulate making a call.
	5. Call the USeBattery() to simulate battery usage.
	6. Print the details of mobile using PrintDetails().
	7. Create a sub class Android use the methods and properties inside the base class.
	8. Android has OS and Version.
	9. Create 2 interfaces:
			1. Icamera - TakePhoto()
			2. Igps - GetLocation()
		The android class should implement both these interfaces.
 */
public class Mobile
{
    string brand, model;
    int batteryLevel = 0;
    public Mobile(string brand, string model)
    {
        this.brand = brand;
        this.model = model;
    }

    public void MakeCall(int number)
    {
        Console.Write("Calling " + number + " Press any Key to end");
        Console.Read();
    }
    public void ChargeBattery(int battery)
    {
        batteryLevel = batteryLevel + battery > 100 ? 100 : batteryLevel + battery;
        if (batteryLevel == 100) Console.WriteLine("Fully Charged!");
        else Console.WriteLine("Charge: " + batteryLevel);

    }
    public void UseBattery(int battery)
    {
        batteryLevel = batteryLevel - battery < 0 ? 0 : batteryLevel - battery;
        if (batteryLevel == 0) Console.WriteLine("Please Charge Your Phone!");
        else Console.WriteLine("Charge: " + batteryLevel);
    }
    public void PrintDetails()
    {
        Console.WriteLine("===DETAILS===");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Battery: " + batteryLevel + "%");
    }

}

