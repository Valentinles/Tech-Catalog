using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechCatalog.Models;

namespace TechCatalog.Services.Interfaces
{
    public interface IDeviceService
    {
        //pc peripherials
        Task<IEnumerable<DesktopPc>> AllDesktopPcs(string sortType);

        Task<DesktopPc> GetDesktopPcById(int id);

        Task<IEnumerable<Laptop>> AllLaptops(string sortType);

        Task<Laptop> GetLaptopById(int id);

        //tv and gaming
        Task<IEnumerable<Tv>> AllTvs(string sortType);

        Task<Tv> GetTvById(int id);

        Task<IEnumerable<GameConsole>> AllGameConsoles(string sortType);

        Task<GameConsole> GetGameConsoleById(int id);

        //IT accessories
        Task<IEnumerable<Headphone>> AllHeadphones(string sortType);

        Task<Headphone> GetHeadphoneById(int id);

        Task<IEnumerable<Keyboard>> AllKeyboards(string sortType);

        Task<Keyboard> GetKeyboardById(int id);

        Task<IEnumerable<Monitor>> AllMonitors(string sortType);

        Task<Monitor> GetMonitorById(int id);

        Task<IEnumerable<Mouse>> AllMice(string sortType);

        Task<Mouse> GetMouseById(int id);

        //mobile phones and tablets
        Task<IEnumerable<MobilePhone>> AllMobilePhones(string sortType);

        Task<MobilePhone> GetMobilePhoneById(int id);

        Task<IEnumerable<Tablet>> AllTablets(string sortType);

        Task<Tablet> GetTabletById(int id);

        //home appliances
        Task<IEnumerable<AirConditioner>> AllAirConditioners(string sortType);

        Task<AirConditioner> GetAirConditionerById(int id);

        Task<IEnumerable<Cooker>> AllCookers(string sortType);

        Task<Cooker> GetCookerById(int id);

        Task<IEnumerable<Refrigerator>> AllRefrigerators(string sortType);

        Task<Refrigerator> GetRefrigeratorById(int id);

        Task<IEnumerable<WashingMachine>> AllWashingMachines(string sortType);

        Task<WashingMachine> GetWashingMachineById(int id);

    }
}
