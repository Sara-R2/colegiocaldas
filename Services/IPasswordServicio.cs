using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace proyecto_caldas.Services
{
    public interface IPasswordServicio
    {
        string HashPassword(String Password); 
    }
}