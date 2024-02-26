using System.Runtime.Intrinsics.X86;

public static class testing_movement
{
    public static void test()
    {
        List<Location> Locations = new List<Location>();
        const int LOCATION_ID_HOME = 1;
        const int LOCATION_ID_TOWN_SQUARE = 2;
        const int LOCATION_ID_GUARD_POST = 3;
        const int LOCATION_ID_ALCHEMIST_HUT = 4;
        const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        const int LOCATION_ID_FARMHOUSE = 6;
        const int LOCATION_ID_FARM_FIELD = 7;
        const int LOCATION_ID_BRIDGE = 8;
        const int LOCATION_ID_SPIDER_FIELD = 9;
        
        Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place.");
        Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain.");
        Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.");
        Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.");
        Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.");
        Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.");
        Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.");
        Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");
        Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.");
        Location myTest = new Location(999,"TESTEST","ABCDEF");
        Location myTest2 = new Location(9999,"TESTEST2","ABCDEF");
        // Link the locations together
        home.LocationToNorth = townSquare;

        townSquare.LocationToNorth = alchemistHut;
        townSquare.LocationToSouth = home;
        townSquare.LocationToEast = guardPost;
        townSquare.LocationToWest = farmhouse;

        farmhouse.LocationToEast = townSquare;
        farmhouse.LocationToWest = farmersField;

        farmersField.LocationToEast = farmhouse;
        farmersField.LocationToSouth = myTest2;

        alchemistHut.LocationToSouth = townSquare;
        alchemistHut.LocationToNorth = alchemistsGarden;

        alchemistsGarden.LocationToSouth = alchemistHut;
        alchemistsGarden.LocationToWest = myTest;

        guardPost.LocationToEast = bridge;
        guardPost.LocationToWest = townSquare;

        bridge.LocationToWest = guardPost;
        bridge.LocationToEast = spiderField;

        spiderField.LocationToWest = bridge;

        myTest.LocationToEast = alchemistsGarden;

        myTest2.LocationToNorth = farmersField;

        // Add the locations to the static list
        Locations.Add(home);
        Locations.Add(townSquare);
        Locations.Add(guardPost);
        Locations.Add(alchemistHut);
        Locations.Add(alchemistsGarden);
        Locations.Add(farmhouse);
        Locations.Add(farmersField);
        Locations.Add(bridge);
        Locations.Add(spiderField);
        Locations.Add(myTest);
        Locations.Add(myTest2);

        // Make a player object and set location at home
        Player PC = new(100,100,0,0,0);
        Compass compass = new(Locations,home);
        PC.CurrentLocation = home;
        while (true){
            compass.showMap();
            PC.Move();
        }
    }
}