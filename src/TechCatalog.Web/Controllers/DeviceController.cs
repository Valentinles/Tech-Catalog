using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechCatalog.Common;
using TechCatalog.Common.ViewModels;
using TechCatalog.Services.Interfaces;

namespace TechCatalog.Web.Controllers
{
    public class DeviceController : Controller
    {
        private readonly IDeviceService deviceService;
        readonly IMapper mapper;
        public DeviceController(IDeviceService deviceService, IMapper mapper)
        {
            this.deviceService = deviceService;
            this.mapper = mapper;
        }

        //pc peripherials
        public async Task<IActionResult> AllDesktopPcs(string sortType)
        {
            var desktopPcs = (await this.deviceService.AllDesktopPcs(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(desktopPcs);
        }
        public async Task<IActionResult> DesktopPcDetails(int id)
        {
            var getDesktopPc = await this.deviceService.GetDesktopPcById(id);

            var desktopPc = mapper.Map<DesktopPcDetailViewModel>(getDesktopPc);

            if (desktopPc == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(desktopPc);
        }

        public async Task<IActionResult> AllLaptops(string sortType)
        {
            var laptops = (await this.deviceService.AllLaptops(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(laptops);
        }
        public async Task<IActionResult> LaptopDetails(int id)
        {
            var getLpatop = await this.deviceService.GetLaptopById(id);

            var laptop = mapper.Map<LaptopDetailViewModel>(getLpatop);

            if (laptop == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(laptop);
        }

        //tv and gaming
        public async Task<IActionResult> AllTvs(string sortType)
        {
            var tvs = (await this.deviceService.AllTvs(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(tvs);
        }
        public async Task<IActionResult> TvDetails(int id)
        {
            var getTv = await this.deviceService.GetTvById(id);

            var tv = mapper.Map<TvDetailViewModel>(getTv);

            if (tv == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(tv);
        }

        public async Task<IActionResult> AllGameConsoles(string sortType)
        {
            var gameConsoles = (await this.deviceService.AllGameConsoles(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(gameConsoles);
        }
        public async Task<IActionResult> GameConsoleDetails(int id)
        {
            var getGameConsole = await this.deviceService.GetGameConsoleById(id);

            var gameConsole = mapper.Map<GameConsoleDetailViewModel>(getGameConsole);

            if (gameConsole == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(gameConsole);
        }

        //IT accessories
        public async Task<IActionResult> AllHeadphones(string sortType)
        {
            var headphones = (await this.deviceService.AllHeadphones(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(headphones);
        }
        public async Task<IActionResult> HeadphoneDetails(int id)
        {
            var getHeadphone = await this.deviceService.GetHeadphoneById(id);

            var headphone = mapper.Map<HeadphoneDetailViewModel>(getHeadphone);

            if (headphone == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(headphone);
        }

        public async Task<IActionResult> AllKeyboards(string sortType)
        {
            var keyboards = (await this.deviceService.AllKeyboards(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(keyboards);
        }
        public async Task<IActionResult> KeyboardDetails(int id)
        {
            var getKeyboard = await this.deviceService.GetKeyboardById(id);

            var keyboard = mapper.Map<KeyboardDetailViewModel>(getKeyboard);

            if (keyboard == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(keyboard);
        }
        public async Task<IActionResult> AllMonitors(string sortType)
        {
            var monitors = (await this.deviceService.AllMonitors(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(monitors);
        }
        public async Task<IActionResult> MonitorDetails(int id)
        {
            var getMonitor = await this.deviceService.GetMonitorById(id);

            var monitor = mapper.Map<MonitorDetailViewModel>(getMonitor);

            if (monitor == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(monitor);
        }

        public async Task<IActionResult> AllMice(string sortType)
        {
            var mice = (await this.deviceService.AllMice(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(mice);
        }
        public async Task<IActionResult> MouseDetails(int id)
        {
            var getMouse = await this.deviceService.GetMouseById(id);

            var mouse = mapper.Map<MouseDetailViewModel>(getMouse);

            if (mouse == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(mouse);
        }

        //mobile phones and tablets
        public async Task<IActionResult> AllMobilePhones(string sortType)
        {
            var mobilePhones = (await this.deviceService.AllMobilePhones(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(mobilePhones);
        }
        public async Task<IActionResult> MobilePhoneDetails(int id)
        {
            var getMobilePhone = await this.deviceService.GetMobilePhoneById(id);

            var mobilePhone = mapper.Map<MobilePhoneDetailViewModel>(getMobilePhone);

            if (mobilePhone == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(mobilePhone);
        }

        public async Task<IActionResult> AllTablets(string sortType)
        {
            var tablets = (await this.deviceService.AllTablets(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(tablets);
        }
        public async Task<IActionResult> TabletDetails(int id)
        {
            var getTablet = await this.deviceService.GetTabletById(id);

            var tablet = mapper.Map<TabletDetailViewModel>(getTablet);

            if (tablet == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(tablet);
        }

        //home appliance
        public async Task<IActionResult> AllAirConditioners(string sortType)
        {
            var airConditioners = (await this.deviceService.AllAirConditioners(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(airConditioners);
        }
        public async Task<IActionResult> AirConditionerDetails(int id)
        {
            var getAc = await this.deviceService.GetAirConditionerById(id);

            var airConditioner = mapper.Map<AirConditionerDetailViewModel>(getAc);

            if (airConditioner == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(airConditioner);
        }

        public async Task<IActionResult> AllCookers(string sortType)
        {
            var cooker = (await this.deviceService.AllCookers(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(cooker);
        }
        public async Task<IActionResult> CookerDetails(int id)
        {
            var getCooker = await this.deviceService.GetCookerById(id);

            var cooker = mapper.Map<CookerDetailViewModel>(getCooker);

            if (cooker == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(cooker);
        }

        public async Task<IActionResult> AllRefrigerators(string sortType)
        {
            var refrigerators = (await this.deviceService.AllRefrigerators(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(refrigerators);
        }
        public async Task<IActionResult> RefrigeratorDetails(int id)
        {
            var getRefrigerator = await this.deviceService.GetRefrigeratorById(id);

            var refrigerator = mapper.Map<RefrigeratorDetailViewModel>(getRefrigerator);

            if (refrigerator == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(refrigerator);
        }

        public async Task<IActionResult> AllWashingMachines(string sortType)
        {
            var washingMachines = (await this.deviceService.AllWashingMachines(sortType))
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(washingMachines);
        }
        public async Task<IActionResult> WashingMachineDetails(int id)
        {
            var getWashingMachine = await this.deviceService.GetWashingMachineById(id);

            var washingMachine = mapper.Map<WashingMachineDetailViewModel>(getWashingMachine);

            if (washingMachine == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(washingMachine);
        }
    }
}