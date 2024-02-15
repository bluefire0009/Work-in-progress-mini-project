using System.Data;
using System.Security.Cryptography.X509Certificates;

class Compass
{
    List<Location> Locations;
    public string Nname;
    public string Wname;
    public string Ename;
    public string Sname;


    public Compass(List<Location> locations)
    {
        Locations = locations;
    }

    public void makeMap()
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
        map[10][10] = "Home";
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
                var Test = location.LocationToWest.Name != null;
                Wname = location.LocationToWest.Name; }
            if (location.LocationToEast != null)
                Ename = location.LocationToEast.Name;
            if (location.LocationToSouth != null)
                Sname = location.LocationToSouth.Name;
            // Go through all the locations currently in the map
            for(int i0 = 0; i0<map.Count; i0++)
            {
                List<string>row = map[i0];
                for (int i1 = 0; i1<row.Count; i1++)
                {
                    string column = row[i1];
                    // if the current location name is the same as the locations in the row, add all the locations to the sides to the map
                    if (column == locName)
                    {
                        map[i0][i1] = locName;
                        if (Nname != "")
                            map[i0][i1 + 1] = Nname;
                        if (Wname != "")
                            map[i0-1][i1] = Wname;
                        if (Ename != "")
                            map[i0 + 1][i1] = Ename;
                        if (Sname != "")
                            map[i0][i1 - 1] = Sname;
                    }
                }
            }
        }
        foreach (var row in map)
        {
            int i = 0;
            foreach(var column in row)
            {
                if (column == "")
                    Console.Write($"|{i}|");
                else
                    Console.Write($"|{column}|");
                i++;
            }
            Console.WriteLine();

        }
    } 
        
}