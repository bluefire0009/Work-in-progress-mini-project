class Compass
{
    public List<string> locationNames = new();
    List<Location> Locations;
    private string Nname;
    private string Wname;
    private string Ename;
    private string Sname;
    public List<List<string>> Map;
    


    public Compass(List<Location> locations)
    {
        Locations = locations;
        foreach(Location location in locations)
        {
            locationNames.Add(location.Name);
        }
        Map = makeMap();
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
        // Add first location (home) to the map
        map[10][2] = "Home";
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
                        // add offset
                        //TO DO: make this into a function, make offset derive from something static, i.e. name length
                        map[i0][i1] = $"{stringTimes(i1," ")},{map[i0][i1]}";
                        if (location.LocationToNorth != null)
                        {    
                            map[i0][i1] += ",North";
                            map[i0][i1+1] ="--";
                        }
                        if (location.LocationToWest != null)
                        {
                            map[i0][i1] += ",West";
                            map[i0-1][i1] =$"{stringTimes(i1+(location.LocationToWest.Name.Length/2)," ")}|";
                        }
                        if (location.LocationToEast != null)
                        {
                            map[i0][i1] += ",East";
                            map[i0+1][i1] =$"{stringTimes(i1 + (location.LocationToEast.Name.Length/2)," ")}|";
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
                    if (column.Contains('|') | column.Contains("--"))
                        Console.Write($"{Map[i0][i1]}");
                    else if (Map[i0][i1-1] == "")
                        Console.Write($"{Map[i0][i1].Split(",")[0]}{Map[i0][i1].Split(",")[1]}");
                    else
                        Console.Write($"{Map[i0][i1].Split(",")[1]}");
            }
            Console.WriteLine();
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
}