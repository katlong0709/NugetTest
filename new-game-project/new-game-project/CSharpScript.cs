using Godot;
using System;
using System.Net.NetworkInformation;

public partial class CSharpScript : Node
{
	public override void _Ready()
	{
		
	}
	
	public override void _Process(double delta)
	{
		GD.Print("hello from c sharp!!!");
		NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);
		NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(NetworkChange_NetworkAddressChanged);
	}

	public void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
	{
		GD.Print("Availability changed!!!");
	}

	public void NetworkChange_NetworkAddressChanged(object sender, EventArgs e)
	{
		GD.Print("Network changed!!!");
	}
}
