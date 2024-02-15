public class testing_compass {
    public void test()
    {
        List<Location> L = new List<Location>();
        int LOCATION_ID_HOME = 1;
        int LOCATION_ID_TOWN_SQUARE = 2;
        int LOCATION_ID_GUARD_POST = 3;
        int LOCATION_ID_ALCHEMIST_HUT = 4;
        int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        int LOCATION_ID_FARMHOUSE = 6;
        int LOCATION_ID_FARM_FIELD = 7;
        int LOCATION_ID_BRIDGE = 8;
        int LOCATION_ID_SPIDER_FIELD = 9;
        Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place.", null, null);
        Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain.", null, null);
        Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.", null, null);
        Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.", null, null);
        Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.", null, null);
        Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.", null, null);
        Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", null, null);
        Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.", null, null);
        Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.", null, null);
        // Link the locations together
        home.LocationToNorth = townSquare;

        townSquare.LocationToNorth = alchemistHut;
        townSquare.LocationToSouth = home;
        townSquare.LocationToEast = guardPost;
        townSquare.LocationToWest = farmhouse;

        farmhouse.LocationToEast = townSquare;
        farmhouse.LocationToWest = farmersField;

        farmersField.LocationToEast = farmhouse;

        alchemistHut.LocationToSouth = townSquare;
        alchemistHut.LocationToNorth = alchemistsGarden;

        alchemistsGarden.LocationToSouth = alchemistHut;

        guardPost.LocationToEast = bridge;
        guardPost.LocationToWest = townSquare;

        bridge.LocationToWest = guardPost;
        bridge.LocationToEast = spiderField;

        spiderField.LocationToWest = bridge;

        // Add the locations to the static list
        L.Add(home);
        L.Add(townSquare);
        L.Add(guardPost);
        L.Add(alchemistHut);
        L.Add(alchemistsGarden);
        L.Add(farmhouse);
        L.Add(farmersField);
        L.Add(bridge);
        L.Add(spiderField);
        Compass C = new(L);
        C.makeMap();
    }
}