// Client code

// Existing distance in meters
using Adapter.DistanceInMeters.Adaptees;
using Adapter.DistanceInMeters.Adapters;
using Adapter.DistanceInMeters.Clients;
using Adapter.DistanceInMeters.Targets;

DistanceInMeters distanceInMeters = new DistanceInMeters(5000);

// Adapter to use DistanceInMeters as IMetersToKilometersAdapter
IDistance adapter = new MetersToKilometesAdapter(distanceInMeters);

// Client code can now work with distances in kilometers
DistanceClient distanceClient = new DistanceClient();
distanceClient.DisplayDistance(adapter);