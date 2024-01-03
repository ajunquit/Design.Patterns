using Strategy.Routes.Contexts;
using Strategy.Routes.Strategies;

Navigation navigation = new Navigation();

navigation.SetRouteStrategy(new WalkingStrategy());
navigation.BuildRoute("gye", "uio");

navigation.SetRouteStrategy(new PublicTransportStrategy());
navigation.BuildRoute("gye", "ny");

navigation.SetRouteStrategy(new RoadStrategy());
navigation.BuildRoute("ny", "cn");