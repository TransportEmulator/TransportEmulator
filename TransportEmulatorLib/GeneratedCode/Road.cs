using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Road
{
    private List<TrafficLane> _lanes = new List<TrafficLane>(5);
    public List<TrafficLane> lanes
    {
        get { return _lanes; }
        set { _lanes = value; }
    }
    public const int ROAD_LENGTH_KM = 500;
    public Road()
    {
        Console.WriteLine("Traffic Lanes: "+lanes.Count);
        for (int i = 0; i < 5; i++)
            _lanes.Add(new TrafficLane());
       // _lanes = ;
    }
}
