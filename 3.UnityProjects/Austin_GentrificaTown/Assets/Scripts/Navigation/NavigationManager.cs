//NavigationManager.cs
using System.Collections.Generic;
using UnityEngine.SceneManagement;

//notice that the NavigaitonManager is a static class
public static class NavigationManager{

	//checks whether a route is traversable or not. 
	public struct Route{
		public string RouteDescription;
		public bool CanTravel;
	}

	//RouteInformation: 
	//list of all the possible destinations 
	//a dictionary container structure
	public static Dictionary<string, Route> RouteInformation = new Dictionary<string, Route>() {
		{ "CoffeeShop", new Route { RouteDescription = "The big bad world", CanTravel = true} },
		{ "Deli", new Route { RouteDescription = "The construction area", CanTravel = false}},
		{ "Town", new Route { RouteDescription = "Back to town", CanTravel = true}},

	};

	//GetRouteInfo: 
	//return the text to be displayed in the prompt, which allows
	public static string GetRouteInfo(string destination){
		return RouteInformation.ContainsKey(destination) ? 
			RouteInformation[destination].RouteDescription :
			null;
	}

	//CanNavigate: 
	//This is a test to see if navigation is possible
	public static bool CanNavigate(string destination){
		return RouteInformation.ContainsKey(destination) ? 
			RouteInformation[destination].CanTravel : 
			false;
	}

	//NavigateTo
	//load the destination scene
	public static void NavigateTo(string destination){
		SceneManager.LoadScene(destination);
	}
}