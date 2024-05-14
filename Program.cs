// See https://aka.ms/new-console-template for more information

using MovieLab;
using System.Collections.Generic;
using System.Diagnostics;
Console.WriteLine("Please select a movie category.");
string input = Console.ReadLine();
//CategorySelect = new MovieSelect(input);

List<KeyValuePair<string, string>>Select = new List<KeyValuePair<string,string>>();
Select.Add(new KeyValuePair<string, string>("The Mighty Ducks", "Sports"));
Select.Add(new KeyValuePair<string, string>("Rudy", "Sports"));
Select.Add(new KeyValuePair<string, string>("Remember The Titans", "Sports"));
Select.Add(new KeyValuePair<string, string>("Above The Rim", "Sports"));
Select.Add(new KeyValuePair<string, string>("Rocky", "Sports"));
Select.Add(new KeyValuePair<string, string>("Waynes World", "Comedy"));
Select.Add(new KeyValuePair<string, string>("The Big Lebowski", "Comedy"));
Select.Add(new KeyValuePair<string, string>("Coming To America", "Comedy"));
Select.Add(new KeyValuePair<string, string>("Purple Rain", "Music"));
Select.Add(new KeyValuePair<string, string>("The God Father", "Drama"));

List<string> MovieCat = Select.Count(t => Select.Contains( input)).ToList();





   
