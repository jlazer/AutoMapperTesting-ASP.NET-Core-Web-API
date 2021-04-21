using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AutoMapperTesting.Models;
using AutoMapperTesting.Entities;

namespace AutoMapperTesting.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IMapper _mapper;

        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: api/<controller>  
        [HttpGet]
        public Student Get()
        {
            StudentDTO studentDTO = new StudentDTO()
            {
                Name = "Student 1",
                Age = 25,
                City = "New York"
            };

            return _mapper.Map<Student>(studentDTO);
        }
    }
}
