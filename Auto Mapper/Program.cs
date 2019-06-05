using AutoMapper;
using System;

namespace Auto_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUpAuttoMapper();
            var employee = new Employee() { Id = Guid.Empty, FirstName = "Jonathan", LastName = "Moore" };
            var employeeDto = Mapper.Map<EmployeeDto>(employee);
        }

        public static void SetUpAuttoMapper()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

            });
        }
    }

    public class Employee
    {
        public Guid Id;
        public string FirstName;
        public string LastName;
    }

    public class EmployeeDto
    {
        public String Name;
    }
}
