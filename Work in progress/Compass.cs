class Compass
{
    public List<string> locationNames = new();
    List<Location> Locations;
    private string Nname;
    private string Wname;
    private string Ename;
    private string Sname;
    public List<List<string>> Map;
    public Location CurrentLocation;
    


    public Compass(List<Location> locations, Location startingLocation )
    {
        Locations = locations;
        CurrentLocation = startingLocation;
        foreach(Location location in locations)
        {
            locationNames.Add(location.Name);
        }
        Map = makeMap();
        // Add offsets
        AddOffsets();
    }

    // Makes a map based upon locations given in the constructor
    protected List<List<string>> makeMap()
    {
        
        List<List<string>> map = new List<List<string>>();
        // Fill the mapList with empty Lists to make an empty 2d representation of the map
        for (int i0 = 0; i0<=20; i0++)
        {
            List<string> emptyList = new List<string>();
            for (int i1 = 0; i1<=20; i1++)
            {
                emptyList.Add("");
            }
            map.Add(emptyList);
        }
        // Add the starting location (home) to the map
        map[10][2] = CurrentLocation.Name;
        // Go through all the locations in the initialized Locations list
        foreach (Location location in Locations)
        {
            Nname = "";
            Wname = "";
            Ename = "";
            Sname = "";
            string locName = location.Name;
            if (location.LocationToNorth != null)
                Nname = location.LocationToNorth.Name;
            if (location.LocationToWest != null) {
                Wname = location.LocationToWest.Name; }
            if (location.LocationToEast != null)
                Ename = location.LocationToEast.Name;
            if (location.LocationToSouth != null)
                Sname = location.LocationToSouth.Name;
            // Go through all the locations currently in the map
            for(int i0 = 0; i0<map.Count; i0+=2)
            {
                List<string>row = map[i0];
                for (int i1 = 0; i1<row.Count; i1+=2)
                {
                    string column = row[i1];
                    // if the current location name is the same as the locations in the row, add all the locations to the sides to the map
                    if (column == locName)
                    {
                        map[i0][i1] = locName;
                        if (Nname != "")
                            map[i0][i1 + 2] = Nname;
                        if (Wname != "")
                            map[i0 - 2][i1] = Wname;
                        if (Ename != "")
                            map[i0 + 2][i1] = Ename;
                        if (Sname != "")
                            map[i0][i1 - 2] = Sname;
                    }
                }
            }
        }
        // Add allowed directions to the location string
        for (int i0=0; i0<map.Count; i0+=2)
        {
            List<string> row = map[i0];
            for(int i1=0; i1<row.Count; i1+=2)
            {
                string column = row[i1];
                if (locationNames.Contains(column) == false)
                {
                    continue;
                }
                foreach(Location location in Locations)
                {
                    if (location.Name == column) 
                    {
                        map[i0][i1] = $"{stringTimes(i1," ")},{map[i0][i1]}";
                        if (location.LocationToNorth != null)
                        {    
                            map[i0][i1] += ",North";
                            map[i0][i1+1] ="--";
                        }
                        if (location.LocationToWest != null)
                        {
                            string Spaces = $"{stringTimes(i1+(location.LocationToWest.Name.Length/2)," ")}";
                            map[i0][i1] += ",West";
                            map[i0-1][i1] =$"{Spaces}|{Spaces}";
                        }
                        if (location.LocationToEast != null)
                        {
                            string Spaces = $"{stringTimes(i1+(location.LocationToEast.Name.Length/2)," ")}";
                            map[i0][i1] += ",East";
                            map[i0+1][i1] =$"{Spaces}|{Spaces}";
                        }
                        if (location.LocationToSouth != null)
                        {
                            map[i0][i1] += ",South";
                            map[i0][i1-1] ="--";
                        }
                    }

                }
            }
        }
        return map;
    }

    public void showMap()
    {
        for(int i0 = 0; i0<Map.Count; i0++)
        {
            var row = Map[i0];
            for(int i1 = 0; i1<row.Count; i1++)
            {
                var column = row[i1];
                if (column=="")
                    Console.Write($" ");
                else
                    if (column.Contains('|') | column.Contains("--") | ContainsOnly(column,' '))
                        Console.Write($"{Map[i0][i1]}");
                    // this condition is only for the locations that are the first in the row.
                    else if (ContainsOnly(Map[i0][i1-1],' '))
                        Console.Write($"{Map[i0][i1].Split(",")[0]}{Map[i0][i1].Split(",")[1]}");
                    // this is the default condition to print a normal location
                    else
                        Console.Write($"{Map[i0][i1].Split(",")[1]}");
            }
            Console.WriteLine();
        }
    }

    public void AddOffsets ()
    {
        for (int columnIndex = 0; columnIndex < Map.Count; columnIndex++)
        {
            int currMaxLen = 0;
            for (int rowIndex = 0; rowIndex < Map[0].Count; rowIndex++)
            {
                // Goes from up to down, left to right, through the whole map
                string currElement;
                if (Map[rowIndex][columnIndex] == "")
                    currElement = Map[rowIndex][columnIndex];
                else
                    currElement = Map[rowIndex][columnIndex].Split(",")[0];
                
                if (currElement.Length > currMaxLen)
                    currMaxLen = currElement.Length;
                // If it's the last element in the row, go again through the row and 
                // replace all places containing only "" with amount of " " equal to the currMaxLen
                if (rowIndex == Map[0].Count-1)
                {
                    for (int rowIndex_2 = 0; rowIndex_2 < Map[0].Count-1; rowIndex_2++)
                    {
                        var currElement_2 = Map[rowIndex_2][columnIndex];
                        if (ContainsOnly(currElement_2,' ') | currElement_2 == ""){
                            Map[rowIndex_2][columnIndex] = stringTimes(currMaxLen," ");}
                    }
                }
            }
        }
    }
    private string stringTimes(int times, string toMultiply)
    {
        string ret = "";
        for (int i0 = 0; i0< times; i0++)
        {
            ret += toMultiply;
        }
        return ret;
    }
    private bool ContainsOnly(string toCheck, char toCompare)
    {
        foreach(var letter in toCheck)
        {
            if (letter != toCompare)
                return false;
        }
        return true;
    }
}