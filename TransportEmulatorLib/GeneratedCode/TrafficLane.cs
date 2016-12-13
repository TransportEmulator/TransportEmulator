using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TrafficLane
{
    public Boolean hasWire {
        get { return _infrastructure[0]; }
    } 
    public Boolean hasRails {
        get { return _infrastructure[1]; }
    }
    private Boolean[] _infrastructure;
    private Vehicle _vehicle;
    public int position = 0;
    public Vehicle vehicle {
        get { return _vehicle; }
        set {
            _vehicle = value;
            if (value is Trum) _infrastructure[1] = true;
            if (value is Trolleybus) _infrastructure[0] = true;
        }
    }
    public TrafficLane() {
        _infrastructure = new Boolean[2]{false,false};
    }
    
}
