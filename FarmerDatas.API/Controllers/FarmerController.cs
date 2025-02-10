using FarmerDatas.API.Data;
using FarmerDatas.API.Model.Domain;
using FarmerDatas.API.Model.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmerDatas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmerController : ControllerBase
    {
        private FarmerDataDbContext dbContext;
        public FarmerController(FarmerDataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            //Get region domain model from database
            var farmersDomain = dbContext.Farmers.ToList();

            //Map Domain Model to RegionDTO
            var farmersDTO = farmersDomain.Select(farmerDomain => new FarmerDTO
            {
                Id = farmerDomain.Id,
                rmcid = farmerDomain.rmcid,
                Farmerid = farmerDomain.Farmerid,
                date = farmerDomain.date,
                time = farmerDomain.time,
                KioskId = farmerDomain.KioskId,
                weight = farmerDomain.weight
            }).ToList();


            return Ok(farmersDTO);
        }

        //GET SINGLE REGION {get region by ID}
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var farmers = dbContext.Farmers.FirstOrDefault(r => r.Id == id);
            if (farmers == null)
            {
                return NotFound();
            }
            var farmersDTO = new FarmerDTO
            {
                Id = farmers.Id,
                rmcid = farmers.rmcid,
                Farmerid = farmers.Farmerid,
                date = farmers.date,
                time = farmers.time,
                KioskId = farmers.KioskId,
                weight = farmers.weight
            };
            return Ok(farmersDTO);
        }
        [HttpPost]
        public IActionResult Create([FromBody] AddRequestDTO addRequestDTO)
        {


            // Map AddRequestDTO to Farmer domain model
            var farmerDomain = new Farmer
            {
                rmcid = addRequestDTO.rmcid,
                Farmerid = addRequestDTO.Farmerid,
                date = addRequestDTO.date,
                time = addRequestDTO.time,
                KioskId = addRequestDTO.KioskId,
                weight = addRequestDTO.weight
            };

            // Add the farmer to the database
            dbContext.Farmers.Add(farmerDomain);
            dbContext.SaveChanges();

            var farmerDto = new FarmerDTO
            {
                Id = farmerDomain.Id,
                rmcid = farmerDomain.rmcid,
                Farmerid = farmerDomain.Farmerid,
                date = farmerDomain.date,
                time = farmerDomain.time,
                KioskId = farmerDomain.KioskId,
                weight = farmerDomain.weight
            };

            // Return a response
            return CreatedAtAction(nameof(GetById), new { id = farmerDto.Id }, farmerDto);
        }
    }
}
