using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechCatalog.Data;
using TechCatalog.Models;
using TechCatalog.Services.Interfaces;
using System.Linq;

namespace TechCatalog.Services.Implementations
{
    public class DeviceService : DataService, IDeviceService
    {
        public DeviceService(TechCatalogDbContext context) : base(context)
        {
        }

        //pc peripherials
        public async Task<IEnumerable<DesktopPc>> AllDesktopPcs(string sortType)
        {
            var desktopPcs = from d in this.context.DesktopPcs
                                  select d;

            switch (sortType)
            {
                case "Price":
                    desktopPcs = desktopPcs.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    desktopPcs = desktopPcs.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    desktopPcs = desktopPcs.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    desktopPcs = desktopPcs.OrderBy(p => p.Brand);
                    break;
                case "Asus":
                    desktopPcs = desktopPcs.Where(d => d.Brand == "Asus");
                    break;
                case "Lenovo":
                    desktopPcs = desktopPcs.Where(d => d.Brand == "Lenovo");
                    break;
                case "Acer":
                    desktopPcs = desktopPcs.Where(d => d.Brand == "Acer");
                    break;
                case "AsusRog":
                    desktopPcs = desktopPcs.Where(d => d.DeviceModel.Contains("Rog"));
                    break;
                default:
                    desktopPcs = desktopPcs.OrderBy(p => p.Brand);
                    break;
            }

            return await desktopPcs.AsNoTracking().ToListAsync();
        }

        public async Task<DesktopPc> GetDesktopPcById(int id)
        {
            var desktopPc = await this.context.DesktopPcs.FirstOrDefaultAsync(d => d.Id == id);

            return desktopPc;
        }

        public async Task<IEnumerable<Laptop>> AllLaptops(string sortType)
        {
            var laptops = from d in this.context.Laptops
                             select d;

            switch (sortType)
            {
                case "Price":
                    laptops = laptops.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    laptops = laptops.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    laptops = laptops.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    laptops = laptops.OrderBy(p => p.Brand);
                    break;
                case "Asus":
                    laptops = laptops.Where(d => d.Brand == "Asus");
                    break;
                case "Lenovo":
                    laptops = laptops.Where(d => d.Brand == "Lenovo");
                    break;
                case "Acer":
                    laptops = laptops.Where(d => d.Brand == "Acer");
                    break;
                case "AsusRog":
                    laptops = laptops.Where(d => d.DeviceModel.Contains("Rog"));
                    break;
                default:
                    laptops = laptops.OrderBy(p => p.Brand);
                    break;
            }

            return await laptops.AsNoTracking().ToListAsync();
        }

        public async Task<Laptop> GetLaptopById(int id)
        {
            var laptop = await this.context.Laptops.FirstOrDefaultAsync(ac => ac.Id == id);

            return laptop;
        }

        //tv and gaming
        public async Task<IEnumerable<Tv>> AllTvs(string sortType)
        {
            var tvs = from d in this.context.Tvs
                          select d;

            switch (sortType)
            {
                case "Price":
                    tvs = tvs.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    tvs = tvs.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    tvs = tvs.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    tvs = tvs.OrderBy(p => p.Brand);
                    break;
                case "Sony":
                    tvs = tvs.Where(d => d.Brand == "Sony");
                    break;
                case "Samsung":
                    tvs = tvs.Where(d => d.Brand == "Samsung");
                    break;
                case "Philips":
                    tvs = tvs.Where(d => d.Brand == "Philips");
                    break;
                case "LG":
                    tvs = tvs.Where(d => d.Brand == "LG");
                    break;
                default:
                    tvs = tvs.OrderBy(p => p.Brand);
                    break;
            }

            return await tvs.AsNoTracking().ToListAsync();
        }

        public async Task<Tv> GetTvById(int id)
        {
            var tv = await this.context.Tvs.FirstOrDefaultAsync(d => d.Id == id);

            return tv;
        }

        public async Task<IEnumerable<GameConsole>> AllGameConsoles(string sortType)
        {
            var gameConsoles = from d in this.context.GameConsoles
                      select d;

            switch (sortType)
            {
                case "Price":
                    gameConsoles = gameConsoles.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    gameConsoles = gameConsoles.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    gameConsoles = gameConsoles.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    gameConsoles = gameConsoles.OrderBy(p => p.Brand);
                    break;
                case "Playstation":
                    gameConsoles = gameConsoles.Where(d => d.Brand == "Playstation");
                    break;
                case "Xbox":
                    gameConsoles = gameConsoles.Where(d => d.Brand == "Xbox");
                    break;
                default:
                    gameConsoles = gameConsoles.OrderBy(p => p.Brand);
                    break;
            }

            return await gameConsoles.AsNoTracking().ToListAsync();
        }

        public async Task<GameConsole> GetGameConsoleById(int id)
        {
            var gameConsole = await this.context.GameConsoles.FirstOrDefaultAsync(d => d.Id == id);

            return gameConsole;
        }

        //IT accessories
        public async Task<IEnumerable<Headphone>> AllHeadphones(string sortType)
        {
            var headphones = from d in this.context.Headphones
                               select d;

            switch (sortType)
            {
                case "Price":
                    headphones = headphones.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    headphones = headphones.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    headphones = headphones.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    headphones = headphones.OrderBy(p => p.Brand);
                    break;
                case "Hyper X":
                    headphones = headphones.Where(d => d.Brand == "Hyper X");
                    break;
                case "Logitech":
                    headphones = headphones.Where(d => d.Brand == "Logitech");
                    break;
                case "Steelseries":
                    headphones = headphones.Where(d => d.Brand == "Steelseries");
                    break;
                case "Razer":
                    headphones = headphones.Where(d => d.Brand == "Razer");
                    break;
                default:
                    headphones = headphones.OrderBy(p => p.Brand);
                    break;
            }

            return await headphones.AsNoTracking().ToListAsync();
        }

        public async Task<Headphone> GetHeadphoneById(int id)
        {
            var headphone = await this.context.Headphones.FirstOrDefaultAsync(d => d.Id == id);

            return headphone;
        }

        public async Task<IEnumerable<Keyboard>> AllKeyboards(string sortType)
        {
            var keyboards = from d in this.context.Keyboards
                             select d;

            switch (sortType)
            {
                case "Price":
                    keyboards = keyboards.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    keyboards = keyboards.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    keyboards = keyboards.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    keyboards = keyboards.OrderBy(p => p.Brand);
                    break;
                case "Hyper X":
                    keyboards = keyboards.Where(d => d.Brand == "Hyper X");
                    break;
                case "Logitech":
                    keyboards = keyboards.Where(d => d.Brand == "Logitech");
                    break;
                case "Steelseries":
                    keyboards = keyboards.Where(d => d.Brand == "Steelseries");
                    break;
                case "Razer":
                    keyboards = keyboards.Where(d => d.Brand == "Razer");
                    break;
                default:
                    keyboards = keyboards.OrderBy(p => p.Brand);
                    break;
            }

            return await keyboards.AsNoTracking().ToListAsync();
        }

        public async Task<Keyboard> GetKeyboardById(int id)
        {
            var keyboard = await this.context.Keyboards.FirstOrDefaultAsync(d => d.Id == id);

            return keyboard;
        }

        public async Task<IEnumerable<Monitor>> AllMonitors(string sortType)
        {
            var monitors = from d in this.context.Monitors
                             select d;

            switch (sortType)
            {
                case "Price":
                    monitors = monitors.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    monitors = monitors.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    monitors = monitors.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    monitors = monitors.OrderBy(p => p.Brand);
                    break;
                case "Asus":
                    monitors = monitors.Where(d => d.Brand == "Asus");
                    break;
                case "BenQ":
                    monitors = monitors.Where(d => d.Brand == "BenQ");
                    break;
                case "Acer":
                    monitors = monitors.Where(d => d.Brand == "Acer");
                    break;
                case "Dell":
                    monitors = monitors.Where(d => d.Brand == "Dell");
                    break;
                default:
                    monitors = monitors.OrderBy(p => p.Brand);
                    break;
            }

            return await monitors.AsNoTracking().ToListAsync();
        }

        public async Task<Monitor> GetMonitorById(int id)
        {
            var monitor = await this.context.Monitors.FirstOrDefaultAsync(d => d.Id == id);

            return monitor;
        }

        public async Task<IEnumerable<Mouse>> AllMice(string sortType)
        {
            var mice = from d in this.context.Mice
                            select d;

            switch (sortType)
            {
                case "Price":
                    mice = mice.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    mice = mice.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    mice = mice.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    mice = mice.OrderBy(p => p.Brand);
                    break;
                case "Hyper X":
                    mice = mice.Where(d => d.Brand == "Hyper X");
                    break;
                case "Logitech":
                    mice = mice.Where(d => d.Brand == "Logitech");
                    break;
                case "Steelseries":
                    mice = mice.Where(d => d.Brand == "Steelseries");
                    break;
                case "Razer":
                    mice = mice.Where(d => d.Brand == "Razer");
                    break;
                default:
                    mice = mice.OrderBy(p => p.Brand);
                    break;
            }

            return await mice.AsNoTracking().ToListAsync();
        }

        public async Task<Mouse> GetMouseById(int id)
        {
            var mouse = await this.context.Mice.FirstOrDefaultAsync(d => d.Id == id);

            return mouse;
        }

        //mobile phones and tablets
        public async Task<IEnumerable<MobilePhone>> AllMobilePhones(string sortType)
        {
            var mobilePhones = from d in this.context.MobilePhones
                       select d;

            switch (sortType)
            {
                case "Price":
                    mobilePhones = mobilePhones.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    mobilePhones = mobilePhones.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    mobilePhones = mobilePhones.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    mobilePhones = mobilePhones.OrderBy(p => p.Brand);
                    break;
                case "Iphone":
                    mobilePhones = mobilePhones.Where(d => d.Brand == "Iphone");
                    break;
                case "Samsung":
                    mobilePhones = mobilePhones.Where(d => d.Brand == "Samsung");
                    break;
                case "Huawei":
                    mobilePhones = mobilePhones.Where(d => d.Brand == "Huawei");
                    break;
                default:
                    mobilePhones = mobilePhones.OrderBy(p => p.Brand);
                    break;
            }

            return await mobilePhones.AsNoTracking().ToListAsync();
        }

        public async Task<MobilePhone> GetMobilePhoneById(int id)
        {
            var mobilePhone = await this.context.MobilePhones.FirstOrDefaultAsync(d => d.Id == id);

            return mobilePhone;
        }

        public async Task<IEnumerable<Tablet>> AllTablets(string sortType)
        {
            var tablets = from d in this.context.Tablets
                               select d;

            switch (sortType)
            {
                case "Price":
                    tablets = tablets.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    tablets = tablets.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    tablets = tablets.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    tablets = tablets.OrderBy(p => p.Brand);
                    break;
                case "Iphone":
                    tablets = tablets.Where(d => d.Brand == "Iphone");
                    break;
                case "Samsung":
                    tablets = tablets.Where(d => d.Brand == "Samsung");
                    break;
                case "Huawei":
                    tablets = tablets.Where(d => d.Brand == "Huawei");
                    break;
                default:
                    tablets = tablets.OrderBy(p => p.Brand);
                    break;
            }

            return await tablets.AsNoTracking().ToListAsync();
        }

        public async Task<Tablet> GetTabletById(int id)
        {
            var tablet = await this.context.Tablets.FirstOrDefaultAsync(d => d.Id == id);

            return tablet;
        }

        //home appliances
        public async Task<IEnumerable<AirConditioner>> AllAirConditioners(string sortType)
        {
            var airConditioners = from d in this.context.AirConditioners
                                  select d;

            switch (sortType)
            {
                case "Price":
                    airConditioners = airConditioners.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    airConditioners = airConditioners.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    airConditioners = airConditioners.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    airConditioners = airConditioners.OrderBy(p => p.Brand);
                    break;
                case "Haier":
                    airConditioners = airConditioners.Where(d => d.Brand == "Haier");
                    break;
                case "Beko":
                    airConditioners = airConditioners.Where(d => d.Brand == "Beko");
                    break;
                case "Bosch":
                    airConditioners = airConditioners.Where(d => d.Brand == "Bosch");
                    break;
                case "Panasonic":
                    airConditioners = airConditioners.Where(d => d.Brand == "Panasonic");
                    break;
                default:
                    airConditioners = airConditioners.OrderBy(p => p.Brand);
                    break;
            }

            return await airConditioners.AsNoTracking().ToListAsync();
        }

        public async Task<AirConditioner> GetAirConditionerById(int id)
        {
            var airConditioner = await this.context.AirConditioners.FirstOrDefaultAsync(ac => ac.Id == id);

            return airConditioner;
        }

        public async Task<IEnumerable<Cooker>> AllCookers(string sortType)
        {
            var cookers = from d in this.context.Cookers
                                  select d;

            switch (sortType)
            {
                case "Price":
                    cookers = cookers.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    cookers = cookers.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    cookers = cookers.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    cookers = cookers.OrderBy(p => p.Brand);
                    break;
                case "Aeg":
                    cookers = cookers.Where(d => d.Brand == "Aeg");
                    break;
                case "Beko":
                    cookers = cookers.Where(d => d.Brand == "Beko");
                    break;
                case "Bosch":
                    cookers = cookers.Where(d => d.Brand == "Bosch");
                    break;
                default:
                    cookers = cookers.OrderBy(p => p.Brand);
                    break;
            }

            return await cookers.AsNoTracking().ToListAsync();
        }

        public async Task<Cooker> GetCookerById(int id)
        {
            var cooker = await this.context.Cookers.FirstOrDefaultAsync(ac => ac.Id == id);

            return cooker;
        }

        public async Task<IEnumerable<Refrigerator>> AllRefrigerators(string sortType)
        {
            var refrigerators = from d in this.context.Refrigerators
                          select d;

            switch (sortType)
            {
                case "Price":
                    refrigerators = refrigerators.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    refrigerators = refrigerators.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    refrigerators = refrigerators.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    refrigerators = refrigerators.OrderBy(p => p.Brand);
                    break;
                case "Aeg":
                    refrigerators = refrigerators.Where(d => d.Brand == "Aeg");
                    break;
                case "Beko":
                    refrigerators = refrigerators.Where(d => d.Brand == "Beko");
                    break;
                case "Bosch":
                    refrigerators = refrigerators.Where(d => d.Brand == "Bosch");
                    break;
                default:
                    refrigerators = refrigerators.OrderBy(p => p.Brand);
                    break;
            }

            return await refrigerators.AsNoTracking().ToListAsync();
        }

        public async Task<Refrigerator> GetRefrigeratorById(int id)
        {
            var refrigerator = await this.context.Refrigerators.FirstOrDefaultAsync(ac => ac.Id == id);

            return refrigerator;
        }

        public async Task<IEnumerable<WashingMachine>> AllWashingMachines(string sortType)
        {
            var washingMachines = from d in this.context.WashingMachines
                                select d;

            switch (sortType)
            {
                case "Price":
                    washingMachines = washingMachines.OrderBy(p => p.Price);
                    break;
                case "PriceByDescending":
                    washingMachines = washingMachines.OrderByDescending(p => p.Price);
                    break;
                case "BrandByDescending":
                    washingMachines = washingMachines.OrderByDescending(p => p.Brand);
                    break;
                case "Brand":
                    washingMachines = washingMachines.OrderBy(p => p.Brand);
                    break;
                case "Aeg":
                    washingMachines = washingMachines.Where(d => d.Brand == "Aeg");
                    break;
                case "Beko":
                    washingMachines = washingMachines.Where(d => d.Brand == "Beko");
                    break;
                case "Bosch":
                    washingMachines = washingMachines.Where(d => d.Brand == "Bosch");
                    break;
                default:
                    washingMachines = washingMachines.OrderBy(p => p.Brand);
                    break;
            }

            return await washingMachines.AsNoTracking().ToListAsync();
        }

        public async Task<WashingMachine> GetWashingMachineById(int id)
        {
            var washingMachine = await this.context.WashingMachines.FirstOrDefaultAsync(ac => ac.Id == id);

            return washingMachine;
        }
    }
}
