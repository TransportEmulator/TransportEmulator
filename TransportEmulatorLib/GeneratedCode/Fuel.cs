﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Fuel
{
    private FuelType _type;
	public FuelType type{ get { return _type; } set {_type=value; } }
    private int _quantity;
    public int quantity{ get { return _quantity; } set { _quantity = value; } }

	public Fuel(FuelType type,int quantity)
	{
        this.type = type;
        this.quantity = quantity;
	}

}

