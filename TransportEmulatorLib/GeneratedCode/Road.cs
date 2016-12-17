using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Road
{
    public static int DRIVER_MIN_AGE = 18;
    private static int _graphicsWidth;
    public static int graphicsWidth
    {
        get { return _graphicsWidth; }
        set { _graphicsWidth = value; }
    }
    private static double _timeCoefficient;
    public static double timeCoefficient
    {
        get { return _timeCoefficient; }
        set { _timeCoefficient = value; }
    }
    private static double _distanceCoefficient;
    public static double distanceCoefficient
    {
        get { return _distanceCoefficient; }
    }
    private List<TrafficLane> _lanes = new List<TrafficLane>(5);
    public List<TrafficLane> lanes
    {
        get { return _lanes; }
        set { _lanes = value; }
    }
    private int _notEmptyLanes;
    public int notEmptyLanes
    {
        get { return _notEmptyLanes; }
    }
    public int checkNonEmptyLine()
    {
        _notEmptyLanes = 0;
        foreach (TrafficLane tl in _lanes)
        {
            if(tl.vehicle!=null)
            {
                _notEmptyLanes++;
            }
        }
        return _notEmptyLanes;
    }
    public const int ROAD_LENGTH_KM = 500;
    public const int TIME_AVERAGE_SEC = 10;
    public const int UPDATE_DELAY_MSEC = 10;
    public Road()
    {
        Console.WriteLine("Traffic Lanes: "+lanes.Count);
        for (int i = 0; i < 5; i++)
            _lanes.Add(new TrafficLane());
        _distanceCoefficient = (double)(_graphicsWidth) / (double)(ROAD_LENGTH_KM*1.09);
    }
}
