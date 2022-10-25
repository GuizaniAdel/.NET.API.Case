using LuukAPICase.Controllers.Enums;
using LuukAPICase.Data;
using LuukAPICase.DTO;
using LuukAPICase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LuukAPICase.Services
{
    public class AddressService : IAddressService
    {
        private readonly DatabaseContext _context;
        public AddressService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Address>> GetAll()
        {
            return await _context.Addresses.ToListAsync();
        }


        public async Task<Address> GetAddressById(Guid id)
        {
            var address = await _context.Addresses.FindAsync(id);

            return address;
        }
        public async Task<Address> PostAddress(AddressRequest addressrequest)
        {
            Address Ad = new Address();
            Ad.Street = addressrequest.Street;
            Ad.HouseNumber = addressrequest.HouseNumber;
            Ad.ZipCode = addressrequest.ZipCode;
            Ad.City = addressrequest.City;
            Ad.Country = addressrequest.Country;
            _context.Addresses.Add(Ad);
            await _context.SaveChangesAsync();
            return Ad;
        }
     
        public async Task<Address> PutAddress(UpdateRequest updateRequest)
        {

            Address PutAd = new Address();
            PutAd.Street = updateRequest.Street;
            PutAd.HouseNumber = updateRequest.HouseNumber;
            PutAd.ZipCode = updateRequest.ZipCode;
            PutAd.City = updateRequest.City;
            PutAd.Country = updateRequest.Country;
            _context.Addresses.Add(PutAd);
            await _context.SaveChangesAsync();
            return PutAd;

        }
        public async Task<IEnumerable<Address>> Search(Columns column, string comparator, Columns order, Suffix suffix)
        {


            List<Address> foundAddresses = await _context.Addresses.FromSqlRaw($"SELECT * FROM Address WHERE {column} == '{comparator}' ORDER BY {order} {suffix} ").ToListAsync();
            return foundAddresses;

        }

        public async Task<String> CalculateDistance(Guid addressId1, Guid addressId2)
        {
         
        Address address1 = await _context.Addresses.FindAsync(addressId1);
        Address address2 = await _context.Addresses.FindAsync(addressId2);
            if (address1 == null || address2 == null) return null;

        const string apiPath = "http://api.positionstack.com/v1/forward?access_key=6f0aa74c3334aa0f873f98c1b1fa8479&query=";
        HttpClient client = new();
        var jsonAddress1String = await client.GetStringAsync($"{apiPath}{address1.GetAddress()}");
        var jsonAddress2String = await client.GetStringAsync($"{apiPath}{address2.GetAddress()}");

        dynamic jsonAddress1 = JObject.Parse(jsonAddress1String);
        dynamic jsonAddress2 = JObject.Parse(jsonAddress2String);

        double latitudeAddress1 = jsonAddress1.data[0].latitude;
        double latitudeAddress2 = jsonAddress2.data[0].latitude;
        double longitudeAddress1 = jsonAddress1.data[0].longitude;
        double longitudeAddress2 = jsonAddress2.data[0].longitude;

            return  $"{CalculateDifferenceBetweenCoords(latitudeAddress1, longitudeAddress1, latitudeAddress2, longitudeAddress2):0.##} km";
    
        }
    /// <summary>
    /// Calculates the difference between two coordinates.
    /// </summary>
    /// <param name="lat1">Latitude of the first coordinate.</param>
    /// <param name="long1">Longitude of the first coordinate.</param>
    /// <param name="lat2">Latitude of the second coordinate.</param>
    /// <param name="long2">Longitude of the second coordinate.</param>
    /// <returns>The distance in kilometres as a double.</returns>
    private static double CalculateDifferenceBetweenCoords(double lat1, double long1, double lat2, double long2)
    {
        var phi1 = lat1 * Math.PI / 180;
        var phi2 = lat2 * Math.PI / 180;
        var deltaPhi = (lat2 - lat1) * Math.PI / 180;
        var deltaLambda = (long2 - long1) * Math.PI / 180;

        var a = Math.Sin(deltaPhi / 2) * Math.Sin(deltaPhi / 2) +
            Math.Cos(phi1) * Math.Cos(phi2) * Math.Sin(deltaLambda / 2) * Math.Sin(deltaLambda / 2);
        var b = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return b * 6375.5;
    }

       
    }
}
