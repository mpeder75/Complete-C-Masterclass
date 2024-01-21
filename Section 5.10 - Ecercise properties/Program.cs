﻿/*
Objective: In this exercise, you will practice creating properties in a class and validating 
the data before it is set. 
Specifically, you'll create a Book class with properties for the title and number of pages.

Instructions:
Within the Book class, create two private fields: a string called _title 
and an integer called _pages.

Implement properties for both _title and _pages:

For the Title property, ensure that it cannot be set to an empty string. 
If an empty string is passed, set it to "Unknown".

For the Pages property, ensure that it cannot be set to a value less than 1. 
If a value less than 1 is passed, set it to 1.

Tips:

Remember to use getters and setters for creating properties.

Utilize conditional statements in the setter to perform validation.
*/


class Book
{
    private string _title;
    private int _pages;

    public string Title 
    {
        get { return _title; }
        set {
            if (_title.Length < 0)
            {
                _title = "unknown";
            }else
            {
                _title = value;
            }
        }
    }

    public int Pages 
    {
        get { return _pages; }
        set 
        {
            if (Pages < 0)
            {
                _pages = 1;
            }
        }
    }

}