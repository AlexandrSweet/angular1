using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ComputerService
{
    public interface IComputerService
    {
        public string AddManufacturer(ComputerManufacturerDto computerManufacturer);
        public List<ComputerManufacturerDto> GetComputerManufacturers();
        public bool DeleteManufacturer(string id);
    }
}
