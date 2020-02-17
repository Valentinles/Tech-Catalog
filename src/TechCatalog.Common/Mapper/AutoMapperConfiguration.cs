using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TechCatalog.Common.ViewModels;
using TechCatalog.Models;

namespace TechCatalog.Common.Mapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            //listings
            this.CreateMap<AirConditioner, DeviceListingViewModel>();
            this.CreateMap<Cooker, DeviceListingViewModel>();
            this.CreateMap<DesktopPc, DeviceListingViewModel>();
            this.CreateMap<GameConsole, DeviceListingViewModel>();
            this.CreateMap<Headphone, DeviceListingViewModel>();
            this.CreateMap<Keyboard, DeviceListingViewModel>();
            this.CreateMap<Laptop, DeviceListingViewModel>();
            this.CreateMap<MobilePhone, DeviceListingViewModel>();
            this.CreateMap<Monitor, DeviceListingViewModel>();
            this.CreateMap<Mouse, DeviceListingViewModel>();
            this.CreateMap<Refrigerator, DeviceListingViewModel>();
            this.CreateMap<Tablet, DeviceListingViewModel>();
            this.CreateMap<Tv, DeviceListingViewModel>();
            this.CreateMap<WashingMachine, DeviceListingViewModel>();

            //details
            this.CreateMap<AirConditioner, AirConditionerDetailViewModel>();
            this.CreateMap<Cooker, CookerDetailViewModel>();
            this.CreateMap<DesktopPc, DesktopPcDetailViewModel>();
            this.CreateMap<GameConsole, GameConsoleDetailViewModel >();
            this.CreateMap<Headphone, HeadphoneDetailViewModel>();
            this.CreateMap<Keyboard, KeyboardDetailViewModel>();
            this.CreateMap<Laptop, LaptopDetailViewModel>();
            this.CreateMap<MobilePhone, MobilePhoneDetailViewModel>();
            this.CreateMap<Monitor, MonitorDetailViewModel>();
            this.CreateMap<Mouse, MouseDetailViewModel>();
            this.CreateMap<Refrigerator, RefrigeratorDetailViewModel>();
            this.CreateMap<Tablet, TabletDetailViewModel>();
            this.CreateMap<Tv, TvDetailViewModel>();
            this.CreateMap<WashingMachine, WashingMachineDetailViewModel>();
        }
    }
}
