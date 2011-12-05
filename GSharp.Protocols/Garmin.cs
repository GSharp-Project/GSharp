using System;
using System.Collections.Generic;
using LibUsbDotNet;
using LibUsbDotNet.Info;
using LibUsbDotNet.Main;
using LibUsbDotNet.Descriptors;
using LibUsbDotNet.DeviceNotify;
using Mono.Addins;

namespace GSharp.Protocols
{
	public class Garmin
	{
		private static IDeviceNotifier UsbDeviceNotifier = DeviceNotifier.OpenDeviceNotifier();
		
		
		private const int GARMIN_VID = 0x091e;
		private static Garmin instance;
		public List<GarminUnit> GarminUnits {get; private set;}
		
		public Action<GarminUnit> DeviceAdded;
		
		internal Garmin ()
		{
			GarminUnits = new List<GarminUnit>();
			InitializeAddIns();
			UsbDeviceNotifier.OnDeviceNotify += HandleUsbDeviceNotifierOnDeviceNotify;
		}

		void HandleUsbDeviceNotifierOnDeviceNotify (object sender, DeviceNotifyEventArgs e)
		{
			if ( e.Device.IdVendor == GARMIN_VID )
			{
				var device_finder = new UsbDeviceFinder(e.Device.IdVendor, e.Device.IdProduct);
				var device_registry = UsbDevice.AllDevices.Find(device_finder);
				UsbDevice device;
				if ( device_registry.Open(out device) )
				{
					DeviceAdded(new GarminUnit(device));
				}
			}
		}
		
		public static Garmin GetInstance()
		{
			return instance ?? (instance = new Garmin());
		}
		
		internal void InitializeAddIns ()
		{
			AddinManager.Initialize();
			AddinManager.Registry.Update();
			foreach (IGarminUnit addin in AddinManager.GetExtensionObjects(typeof(IGarminUnit)))
			{
				Console.WriteLine("Finding units of type ", addin.Description);
				foreach ( UsbDevice dev in FindDevices(addin.VID, addin.PID))
				{
					GarminUnit unit = new GarminUnit(dev);
					unit.Init();
					GarminUnits.Add(unit);
				}
			}
		}
		
		internal List<UsbDevice> FindDevices()
		{
			var all_devices = UsbDevice.AllDevices;			
			UsbRegDeviceList devlist = all_devices.FindAll(new UsbDeviceFinder(GARMIN_VID));
			return FindDevices(devlist);
		}		
		
		internal List<UsbDevice> FindDevices(int VID)
		{
			var all_devices = UsbDevice.AllDevices;			
			UsbRegDeviceList devlist = all_devices.FindAll(new UsbDeviceFinder(VID));
			return FindDevices(devlist);
		}		
		
		internal List<UsbDevice> FindDevices(int VID, int PID)
		{
			var all_devices = UsbDevice.AllDevices;			
			UsbRegDeviceList devlist = all_devices.FindAll(new UsbDeviceFinder(VID, PID));
			return FindDevices(devlist);
		}
		
		internal List<UsbDevice> FindDevices(UsbRegDeviceList devlist)
		{
		 	List<UsbDevice> units = new List<UsbDevice>();
			
			foreach (UsbRegistry usb_registry in devlist)
			{
				UsbDevice myUsbDevice;
				if ( usb_registry.Open(out myUsbDevice))
				{
					units.Add(myUsbDevice);
				}
			}
			
			return units;
		}
	}
}

