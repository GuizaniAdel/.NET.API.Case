using LuukAPICase.Controllers.Enums;
using LuukAPICase.DTO;
using LuukAPICase.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LuukAPICase.Services
{
    public interface IAddressService
    {
        public Task<IEnumerable<Address>> GetAll();
        public Task<Address> GetAddressById(Guid id);
        public Task<Address> PutAddress(UpdateRequest updateRequest);
        public Task<Address> PostAddress(AddressRequest addressrequest);
        public Task<IEnumerable<Address>> Search(Columns column, string comparator, Columns order, Suffix suffix);
        public Task<String> CalculateDistance(Guid addressId1, Guid addressId2);
       
    }
        

    
       
    
}

